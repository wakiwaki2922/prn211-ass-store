namespace SaleManagementWinApp
{
    partial class frmCustomer
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
            lbName = new Label();
            txtName = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            lbBirthday = new Label();
            lbStatus = new Label();
            dtpBirthday = new DateTimePicker();
            cbIsActive = new CheckBox();
            btnAdd = new Button();
            btnClose = new Button();
            lbCustomerID = new Label();
            txtCustomerID = new TextBox();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(60, 64);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 62);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(60, 98);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 95);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(42, 135);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(108, 130);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 23);
            txtPassword.TabIndex = 1;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(387, 64);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(436, 61);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(213, 23);
            txtCity.TabIndex = 1;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(365, 98);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(436, 95);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(213, 23);
            txtCountry.TabIndex = 1;
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(364, 135);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(51, 15);
            lbBirthday.TabIndex = 0;
            lbBirthday.Text = "Birthday";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(60, 172);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "Status";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(436, 135);
            dtpBirthday.Margin = new Padding(3, 2, 3, 2);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(213, 23);
            dtpBirthday.TabIndex = 2;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Location = new Point(108, 172);
            cbIsActive.Margin = new Padding(3, 2, 3, 2);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(59, 19);
            cbIsActive.TabIndex = 3;
            cbIsActive.Text = "Active";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(436, 15);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(567, 15);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new Point(26, 22);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new Size(73, 15);
            lbCustomerID.TabIndex = 0;
            lbCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(108, 19);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(213, 23);
            txtCustomerID.TabIndex = 1;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 216);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(cbIsActive);
            Controls.Add(dtpBirthday);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerID);
            Controls.Add(txtName);
            Controls.Add(lbStatus);
            Controls.Add(lbBirthday);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbCustomerID);
            Controls.Add(lbName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private TextBox txtName;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbCountry;
        private TextBox txtCountry;
        private Label lbBirthday;
        private Label lbStatus;
        private DateTimePicker dtpBirthday;
        private CheckBox cbIsActive;
        private Button btnAdd;
        private Button btnClose;
        private Label lbCustomerID;
        private TextBox txtCustomerID;
    }
}