using BusinessObjects;
using BusinessObjects.Model;
using Repositories;
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
    public partial class frmCheckout : Form
    {
        private IOrderRepository orderRepository;
        private IOrderDetailRepository orderDetailRepository;
        private IProductRepository productRepository;
        public Customer? Customer { get; set; }
        public List<OrderDetail> orderItems { get; set; }
        public frmCheckout()
        {
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
            productRepository = new ProductRepository();
            InitializeComponent();
        }
        private void LoadCheckoutList()
        {
            dgvProductListCheckOut.DataSource = orderItems.Select(c => new
            {
                c.OrderId,
                c.FlowerBouquetId,
                c.UnitPrice,
                c.Quantity,
                c.Discount
            }).ToList();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            LoadCheckoutList();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<OrderDetail> orderedItems = new List<OrderDetail>();
            int generatedID = orderRepository.GetMaxOrderID() + 1;
            decimal total = 0;
            bool sufficientStock = true;

            foreach (DataGridViewRow row in dgvProductListCheckOut.Rows)
            {
                int productId = (int)row.Cells[1].Value;
                int quantity = (int)row.Cells[3].Value;

                // Kiểm tra số lượng sản phẩm có sẵn trong kho
                int availableStock = productRepository.GetStockQuantity(productId);

                if (quantity > availableStock)
                {
                    sufficientStock = false;
                    MessageBox.Show($"The product '{row.Cells[5].Value}' is out of stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                total += ((decimal)row.Cells[2].Value * (1 - decimal.Parse(row.Cells[4].Value.ToString()) / 100)) * quantity;
                orderedItems.Add(new OrderDetail()
                {
                    OrderId = (int)row.Cells[0].Value,
                    FlowerBouquetId = productId,
                    UnitPrice = (decimal)row.Cells[2].Value,
                    Quantity = quantity,
                    Discount = (double)row.Cells[4].Value
                });
            }

            if (sufficientStock)
            {
                // Thực hiện đặt hàng
                Order order = new Order()
                {
                    OrderId = generatedID,
                    CustomerId = Customer?.CustomerId,
                    OrderDate = DateTime.Now,
                    ShippedDate = DateTime.Now.AddMonths(1),
                    Total = total,
                    OrderStatus = "0"
                };

                orderRepository.InsertOrder(order);
                orderDetailRepository.InsertOrderDetail(orderedItems);
                MessageBox.Show("Order successfully", "Order Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trừ đi số lượng hàng trong kho
                foreach (var item in orderedItems)
                {
                    productRepository.UpdateStock(item.FlowerBouquetId, item.Quantity);
                }

                this.Close();
            }
        }


        private void btnChangeAmount_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvProductListCheckOut.CurrentRow.Index;
            if (numericAmount.Value < 0)
            {
                MessageBox.Show("Amount number is invalid", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (numericAmount.Value == 0)
            {
                orderItems.RemoveAt(rowIndex);
            }
            else
            {
                orderItems[rowIndex].Quantity = (int)numericAmount.Value;
            }
            LoadCheckoutList();
        }

        private void dgvProductListCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvProductListCheckOut.CurrentCell.ColumnIndex;
            if (index == 3)
            {
                numericAmount.Enabled = true;
                btnChangeAmount.Enabled = true;
            }
            else
            {
                numericAmount.Enabled = false;
                btnChangeAmount.Enabled = false;
            }
        }
    }
}
