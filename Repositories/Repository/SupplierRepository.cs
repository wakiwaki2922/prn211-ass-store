using BusinessObjects.Model;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        public List<Supplier> GetAllSupplier() => SupplierDAO.Instance.GetAllSupplier();

        public int GetIdByName(string name) => SupplierDAO.Instance.GetIdByName(name);

        public string GetNameById(int? id) => SupplierDAO.Instance.GetNameById(id);

    }
}
