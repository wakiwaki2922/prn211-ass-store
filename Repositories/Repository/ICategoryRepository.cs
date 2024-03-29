using BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();

        void addCategory(Category category);

        void updateCategory(Category category);

        string GetNameById(int id);

        int GetIdByName(string name);
    }
}
