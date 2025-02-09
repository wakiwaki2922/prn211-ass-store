﻿using BusinessObjects.Model;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmOrderList : Form
    {
        private IOrderRepository orderRepository;
        private IOrderDetailRepository orderDetailRepository;
        private ICustomerRepository customerRepository;
        public Customer? Customer { get; set; }
        public bool isAdmin { get; set; }

        public int OrderID { get; set; }

        public frmOrderList()
        {
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        private void LoadOrderList()
        {
            if (Customer != null)
            {
                dgvOrder.DataSource = orderRepository.GetAllOrders().Where(c => c.CustomerId == Customer.CustomerId).Select(c => new
                {
                    c.OrderId,
                    c.Customer.CustomerName,
                    c.OrderDate,
                    c.ShippedDate,
                    c.Total,
                    c.OrderStatus
                }).ToList();
            }
            else
            {
                dgvOrder.DataSource = orderRepository.GetAllOrders().Select(c => new
                {
                    c.OrderId,
                    c.Customer.CustomerName,
                    c.OrderDate,
                    c.ShippedDate,
                    c.Total,
                    c.OrderStatus
                }).ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void frmOrder_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                pnlSearchByDate.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            LoadOrderList();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0 && index < dgvOrder.Rows.Count)
            {
                DataGridViewRow row = dgvOrder.Rows[index];

                int orderID = (int)row.Cells[0].Value;

                frmOrderDetail orderDetailForm = new frmOrderDetail(orderID);

                orderDetailForm.Show();
            }
        }



        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartDate.Value.AddDays(-1);
            DateTime end = dtpEndDate.Value;
            if (start.CompareTo(end) > 0)
            {
                MessageBox.Show("Start date must be earlier or equal to end date", "Invalid Date", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                dgvOrder.DataSource = orderRepository.GetAllOrders().Where(c => DateTime.Compare(c.OrderDate, start) >= 0 && DateTime.Compare(c.OrderDate, end) <= 0).OrderByDescending(c => c.Total).Select(c => new
                {
                    c.OrderId,
                    c.Customer.CustomerName,
                    c.OrderDate,
                    c.ShippedDate,
                    c.Total,
                    c.OrderStatus
                }).ToList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvOrder.CurrentCell.RowIndex;
            DataGridViewRow row = dgvOrder.Rows[index];
            frmOrder frmOrder = new frmOrder()
            {
                Order = new Order()
                {
                    OrderId = (int)row.Cells[0].Value,
                    CustomerId = customerRepository.GetIdByName((string)row.Cells[1].Value),
                    OrderDate = (DateTime)row.Cells[2].Value,
                    ShippedDate = (DateTime)row.Cells[3].Value,
                    Total = (decimal)row.Cells[4].Value,
                    OrderStatus = (string)row.Cells[5].Value
                }
            };
            frmOrder.ShowDialog();
            LoadOrderList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvOrder.CurrentCell.RowIndex;
            DataGridViewRow row = dgvOrder.Rows[index];
            Order order = new Order()
            {
                OrderId = (int)row.Cells[0].Value,
            };
            orderRepository.DeleteOrder(order);
            LoadOrderList();
        }
    }
}
