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
    public partial class frmOrderDetail : Form
    {
        private int orderID;

        private IOrderDetailRepository OrderDetailRepository;

        private decimal totalPrice;

        private int totalQuantity;

        public frmOrderDetail(int orderID)
        {
            OrderDetailRepository = new OrderDetailRepository();
            InitializeComponent();
            this.orderID = orderID;
        }

        private void LoadOrderDetail()
        {
            var orderDetails = OrderDetailRepository.GetOrderDetailByOrderID(orderID)
                                .Select(c => new
                                {
                                    c.OrderId,
                                    c.FlowerBouquet.FlowerBouquetName,
                                    c.UnitPrice,
                                    c.Quantity,
                                    c.Discount
                                }).ToList();

            dgvOrderDetail.DataSource = orderDetails;

            totalPrice = orderDetails.Sum(c => c.UnitPrice * c.Quantity);
            totalQuantity = orderDetails.Sum(c => c.Quantity);

        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderDetail();
            txtTotalQuantity.Text = totalQuantity.ToString();
            txtTotalPrice.Text = totalPrice.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

    }

}
