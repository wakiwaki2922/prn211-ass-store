using BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SupplierDAO
    {
        private static SupplierDAO? instance = null;
        private static readonly object instanceLock = new object();
        private SupplierDAO() { }
        public static SupplierDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SupplierDAO();
                    }
                    return instance;
                }
            }
        }


        public List<Supplier> GetAllSupplier()
        {
            List<Supplier> supplierList = new List<Supplier>();
            try
            {
                using (FuflowerBouquetManagementV4Context context = new FuflowerBouquetManagementV4Context())
                {
                    supplierList = context.Suppliers.ToList();
                    return supplierList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetNameById(int? supplierId)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context context = new FuflowerBouquetManagementV4Context())
                {
                    return context.Suppliers.FirstOrDefault(x => x.SupplierId == supplierId).SupplierName;
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
                    return context.Suppliers.FirstOrDefault(x => x.SupplierName.Equals(name)).SupplierId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
