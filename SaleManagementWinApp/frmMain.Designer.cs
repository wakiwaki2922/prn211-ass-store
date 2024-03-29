
namespace SaleManagementWinApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlAdmin = new Panel();
            btnCustomer = new Button();
            pnlCustomer = new Panel();
            btnProfile = new Button();
            btnProduct = new Button();
            btnOrder = new Button();
            pnlDefault = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            pnlFront = new Panel();
            btnCategory = new Button();
            pnlAdmin.SuspendLayout();
            pnlCustomer.SuspendLayout();
            pnlDefault.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdmin
            // 
            pnlAdmin.Controls.Add(btnCategory);
            pnlAdmin.Controls.Add(btnCustomer);
            pnlAdmin.Dock = DockStyle.Top;
            pnlAdmin.Location = new Point(0, 0);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(520, 127);
            pnlAdmin.TabIndex = 0;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(40, 42);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(184, 50);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(btnProfile);
            pnlCustomer.Controls.Add(btnProduct);
            pnlCustomer.Controls.Add(btnOrder);
            pnlCustomer.Dock = DockStyle.Top;
            pnlCustomer.Location = new Point(0, 127);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(520, 127);
            pnlCustomer.TabIndex = 1;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(356, 39);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(123, 50);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(195, 39);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(123, 50);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(40, 39);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(123, 50);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // pnlDefault
            // 
            pnlDefault.Controls.Add(btnExit);
            pnlDefault.Controls.Add(btnLogout);
            pnlDefault.Dock = DockStyle.Bottom;
            pnlDefault.Location = new Point(0, 303);
            pnlDefault.Name = "pnlDefault";
            pnlDefault.Size = new Size(520, 124);
            pnlDefault.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(195, 41);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 50);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(40, 41);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 50);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlFront
            // 
            pnlFront.Dock = DockStyle.Right;
            pnlFront.Location = new Point(0, 0);
            pnlFront.Name = "pnlFront";
            pnlFront.Size = new Size(525, 395);
            pnlFront.TabIndex = 1;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(295, 42);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(184, 50);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 427);
            Controls.Add(pnlDefault);
            Controls.Add(pnlCustomer);
            Controls.Add(pnlAdmin);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            pnlAdmin.ResumeLayout(false);
            pnlCustomer.ResumeLayout(false);
            pnlDefault.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdmin;
        private Button btnCustomer;
        private Panel pnlCustomer;
        private Button btnProfile;
        private Button btnProduct;
        private Button btnOrder;
        private Panel pnlDefault;
        private Button btnExit;
        private Button btnLogout;
        private Panel pnlFront;
        private Button btnCategory;
    }
}