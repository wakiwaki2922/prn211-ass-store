using BusinessObjects.Model;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(Order order) => OrderDAO.Instance.DeleteOrder(order);

        public List<Order> GetAllOrders() => OrderDAO.Instance.GetAllOrder();

        public int GetMaxOrderID() => OrderDAO.Instance.GetMaxOrderID();

        public void InsertOrder(Order order) => OrderDAO.Instance.InsertOrder(order);

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
