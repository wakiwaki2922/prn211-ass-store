using BusinessObjects.Model;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetail> GetOrderDetailByOrderID(int orderID) => OrderDetailDAO.Instance.GetOrderDetailByOrderID(orderID);

        public void InsertOrderDetail(List<OrderDetail> orderDetailList) => OrderDetailDAO.Instance.InsertOrderDetail(orderDetailList);
    }
}
