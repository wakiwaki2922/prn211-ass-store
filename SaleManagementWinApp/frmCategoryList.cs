using BusinessObjects.Model;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmCategoryList : Form
    {
        private ICategoryRepository categoryRepository;

        public frmCategoryList()
        {
            categoryRepository = new CategoryRepository();
            InitializeComponent();
        }

        private void LoadCategoryList()
        {
            dgvCategoryList.DataSource = categoryRepository.GetAllCategories().Select(c => new
            {
                c.CategoryId,
                c.CategoryName,
                c.CategoryDescription,
                c.CategoryNote
            }).ToList();
        }

        private void frmCategoryList_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            int lastIndex = dgvCategoryList.RowCount - 1;
            frmCategory frmCategory = new frmCategory()
            {
                Text = "New Category",
                generatedID = (int)dgvCategoryList.Rows[lastIndex].Cells[0].Value + 1,
                isAdd = true,
            };
            frmCategory.ShowDialog();
            LoadCategoryList();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvCategoryList.CurrentRow.Index;
            DataGridViewRow row = dgvCategoryList.Rows[currentIndex];
            frmCategory frmCategory = new frmCategory()
            {
                Text = "Update Category",
                isAdd = false,
                Category = new Category()
                {
                    CategoryId = (int)row.Cells[0].Value,
                    CategoryName = (string)row.Cells[1].Value,
                    CategoryDescription = (string)row.Cells[2].Value,
                    CategoryNote = (string)row.Cells[3].Value
                }
            };
            frmCategory.ShowDialog();
            LoadCategoryList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbCategoryID.Checked)
            {
                if (txtSearch.Text.Equals(string.Empty))
                {
                    LoadCategoryList();
                }
                else
                {
                    dgvCategoryList.DataSource = categoryRepository.GetAllCategories().Where(c => c.CategoryId.ToString().Equals(txtSearch.Text)).Select(c => new
                    {
                        c.CategoryId,
                        c.CategoryName,
                        c.CategoryDescription
                    }).ToList();
                }
            }
            else if (rbCategoryName.Checked)
            {
                dgvCategoryList.DataSource = categoryRepository.GetAllCategories().Where(c => c.CategoryName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).Select(c => new
                {
                    c.CategoryId,
                    c.CategoryName,
                    c.CategoryDescription
                }).ToList();
            }
        }

    }
}
