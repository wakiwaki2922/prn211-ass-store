using BusinessObjects.Model;
using Repositories.Repository;

namespace SaleManagementWinApp
{
    public partial class frmCategory : Form
    {
        private ICategoryRepository categoryRepository;

        public int generatedID { get; set; }
        public bool isAdd { get; set; }
        public Category Category { get; set; }

        public frmCategory()
        {
            categoryRepository = new CategoryRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void frmCategory_Load(object sender, EventArgs e)
        {
            txtCategoryId.Text = generatedID.ToString();
            if (Category != null)
            {
                txtCategoryId.Text = Category.CategoryId.ToString();
                txtCategoryName.Text = Category.CategoryName;
                txtCategoryDescription.Text = Category.CategoryDescription;
                txtCategoryNote.Text = Category.CategoryNote;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Category Name is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtCategoryDescription.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Category Description is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Category category = new Category()
                {
                    CategoryId = int.Parse(txtCategoryId.Text),
                    CategoryName = txtCategoryName.Text,
                    CategoryDescription = txtCategoryDescription.Text,
                    CategoryNote = txtCategoryNote.Text
                };

                if (isAdd)
                {
                    categoryRepository.addCategory(category);
                }
                else
                {
                    categoryRepository.updateCategory(category);
                }
                this.Close();
            }
        }
    }
}
