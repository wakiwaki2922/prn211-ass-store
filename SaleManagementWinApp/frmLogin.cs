using BusinessObjects.Model;
using DataAccessObjects;
using Repositories.Repository;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        private ICustomerRepository customerRepository;

        public frmLogin()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Customer? customer = customerRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
            (string, string) adminAccount = customerRepository.checkLoginAdmin();
            if (customer != null)
            {
                frmMain frmMain = new frmMain()
                {
                    Customer = customer,
                    isAdmin = false
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Visible = true;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else if (txtEmail.Text.Equals(adminAccount.Item1) && txtPassword.Text.Equals(adminAccount.Item2))
            {
                frmMain frmMain = new frmMain()
                {
                    Customer = null,
                    isAdmin = true
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Visible = true;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Email or password is incorrect", "Cannot log in", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
            }
        }


    }
}
