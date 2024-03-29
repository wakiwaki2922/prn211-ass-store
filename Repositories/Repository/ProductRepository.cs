using BusinessObjects.Model;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<FlowerBouquet> GetAllProduct() => ProductDAO.Instance.GetAllProduct();

        public void AddProduct(FlowerBouquet product) => ProductDAO.Instance.InsertProduct(product);

        public void UpdateProduct(FlowerBouquet product) => ProductDAO.Instance.UpdateProduct(product);

        public void DeleteProduct(FlowerBouquet product) => ProductDAO.Instance.DeleteProduct(product);

        public int GetIdByName(string name) => ProductDAO.Instance.GetIdByName(name);

        public string GetNameById(int id) => ProductDAO.Instance.GetNameById(id);

        public int GetStockQuantity(int productId) => ProductDAO.Instance.GetStockQuantity(productId);

        public void UpdateStock(int flowerBouquetId, int quantity) => ProductDAO.Instance.UpdateStock(flowerBouquetId, quantity);
    }
}
