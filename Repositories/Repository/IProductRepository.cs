using BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public interface IProductRepository
    {
        List<FlowerBouquet> GetAllProduct();
        void AddProduct(FlowerBouquet product);
        void UpdateProduct(FlowerBouquet product);
        void DeleteProduct(FlowerBouquet product);
        public string GetNameById(int id);
        public int GetIdByName(string name);
        int GetStockQuantity(int productId);
        void UpdateStock(int flowerBouquetId, int quantity);
    }
}
