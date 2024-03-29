using BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public interface ICustomerRepository
    {
        public Customer CheckLogin(string email, string password);

        public (string, string) checkLoginAdmin();

        List<Customer> GetAllCustomer();

        void AddCustomer(Customer customer);

        void UpdateCustomer(Customer customer);

        void DeleteCustomer(Customer customer);

        int GetIdByName(string name);

        string GetNameById(int id);
    }
}
