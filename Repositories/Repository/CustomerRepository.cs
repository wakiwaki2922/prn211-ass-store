using BusinessObjects.Model;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer? CheckLogin(string email, string password) => CustomerDAO.Instance.CheckLogin(email, password);

        public (string, string) checkLoginAdmin() => CustomerDAO.Instance.checkLoginAdmin();

        public List<Customer> GetAllCustomer() => CustomerDAO.Instance.GetAllCustomer();

        public void AddCustomer(Customer customer) => CustomerDAO.Instance.InsertCustomer(customer);

        public void UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);

        public void DeleteCustomer(Customer customer) => CustomerDAO.Instance.DeleteCustomer(customer);
      
        public int GetIdByName(string name) => CustomerDAO.Instance.GetIdByName(name);

        public string GetNameById(int id) => CustomerDAO.Instance.GetNameById(id);

    }
}
