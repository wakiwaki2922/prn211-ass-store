namespace SaleManagementWinApp
{
    partial class frmProfile
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
            lbCustomerID = new Label();
            txtCustomerID = new TextBox();
            lbCustomerName = new Label();
            txtCustomerName = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            lbBirthday = new Label();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            dtpBirthday = new DateTimePicker();
            lbConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lbPassword = new Label();
            SuspendLayout();
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new Point(26, 43);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new Size(70, 15);
            lbCustomerID.TabIndex = 0;
            lbCustomerID.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(117, 40);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(182, 23);
            txtCustomerID.TabIndex = 1;
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(2, 70);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(94, 15);
            lbCustomerName.TabIndex = 0;
            lbCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(117, 67);
            txtCustomerName.Margin = new Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(182, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(60, 178);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 175);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(182, 23);
            txtEmail.TabIndex = 1;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(68, 97);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(117, 94);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(182, 23);
            txtCity.TabIndex = 1;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(46, 124);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(117, 121);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(182, 23);
            txtCountry.TabIndex = 1;
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(45, 151);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(51, 15);
            lbBirthday.TabIndex = 0;
            lbBirthday.Text = "Birthday";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(430, 43);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(182, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(430, 107);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 49);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(521, 107);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 49);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(117, 148);
            dtpBirthday.Margin = new Padding(3, 2, 3, 2);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(182, 23);
            dtpBirthday.TabIndex = 3;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(320, 73);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(104, 15);
            lbConfirmPassword.TabIndex = 0;
            lbConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(430, 70);
            txtConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(182, 23);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(367, 43);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 221);
            Controls.Add(dtpBirthday);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(lbPassword);
            Controls.Add(lbConfirmPassword);
            Controls.Add(lbBirthday);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbEmail);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCustomerID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProfile";
            Load += frmProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCustomerID;
        private TextBox txtCustomerID;
        private Label lbCustomerName;
        private TextBox txtCustomerName;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbCountry;
        private TextBox txtCountry;
        private Label lbBirthday;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnClose;
        private DateTimePicker dtpBirthday;
        private Label lbConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lbPassword;
    }
}