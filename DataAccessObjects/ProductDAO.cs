using BusinessObjects.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        private static ProductDAO? instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public List<FlowerBouquet> GetAllProduct()
        {
            List<FlowerBouquet> productList = new List<FlowerBouquet>();
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    productList = context.FlowerBouquets.Include(c => c.Category).Include(c => c.Supplier).ToList();
                    return productList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertProduct(FlowerBouquet flowerBouquet)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    context.FlowerBouquets.Add(flowerBouquet);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(FlowerBouquet flowerBouquet)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {
                    context.Entry<FlowerBouquet>(flowerBouquet).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProduct(FlowerBouquet flowerBouquet)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context? context = new FuflowerBouquetManagementV4Context())
                {

                    var deleteProduct = context.FlowerBouquets.SingleOrDefault(c => c.FlowerBouquetId == flowerBouquet.FlowerBouquetId);
                    context.FlowerBouquets.Remove(deleteProduct);
                    context.SaveChanges();
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

                    return context.FlowerBouquets.FirstOrDefault(x => x.FlowerBouquetName.Equals(name)).FlowerBouquetId;
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

                    return context.FlowerBouquets.Find(id).FlowerBouquetName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetStockQuantity(int productId)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context context = new FuflowerBouquetManagementV4Context())
                {
                    var product = context.FlowerBouquets.SingleOrDefault(p => p.FlowerBouquetId == productId);
                    if (product != null)
                    {
                        return product.UnitsInStock;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void UpdateStock(int flowerBouquetId, int quantity)
        {
            try
            {
                using (FuflowerBouquetManagementV4Context context = new FuflowerBouquetManagementV4Context())
                {
                    var product = context.FlowerBouquets.SingleOrDefault(p => p.FlowerBouquetId == flowerBouquetId);
                    if (product != null)
                    {
                        product.UnitsInStock -= quantity;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
