using BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DataAccessObjects
{
    public class CustomerDAO
    {

        private static CustomerDAO? instance = null;
        private static readonly object instanceLock = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        public Customer CheckLogin(string email, string password)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context context = new FuflowerBouquetManagementV4Context())
                {
                    Customer customer = context.Customers.SingleOrDefault(c => c.Email.Equals(email) && c.Password.Equals(password));

                    if (customer != null && customer.CustomerStatus != 0)
                    {
                        return customer;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public (string, string) checkLoginAdmin()
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    return context.GetAdminAccount();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Customer> GetAllCustomer()
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    List<Customer> customerList = context.Customers.ToList();
                    return customerList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void InsertCustomer(Customer customer)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    context.Entry<Customer>(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context context = new FuflowerBouquetManagementV4Context())
                {
                    var deleteCustomer = context.Customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);
                    if (deleteCustomer != null)
                    {
                        deleteCustomer.CustomerStatus = 0;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }       

        public string GetNameById(int id)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    return context.Customers.Find(id).CustomerName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetIdByName(string name)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    return context.Customers.FirstOrDefault(x => x.CustomerName.Equals(name)).CustomerId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

