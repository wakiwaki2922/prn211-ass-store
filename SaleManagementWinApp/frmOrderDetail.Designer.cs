namespace SaleManagementWinApp
{
    partial class frmOrderDetail
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
            dgvOrderDetail = new DataGridView();
            btnClose = new Button();
            lblTotalQuantity = new Label();
            lbTotalPrice = new Label();
            txtTotalQuantity = new TextBox();
            txtTotalPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(0, 1);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.Size = new Size(601, 449);
            dgvOrderDetail.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(633, 42);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 67);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(621, 157);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(81, 15);
            lblTotalQuantity.TabIndex = 2;
            lblTotalQuantity.Text = "Total Quantity";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(621, 227);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(61, 15);
            lbTotalPrice.TabIndex = 3;
            lbTotalPrice.Text = "Total Price";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(661, 175);
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.ReadOnly = true;
            txtTotalQuantity.Size = new Size(100, 23);
            txtTotalQuantity.TabIndex = 4;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(661, 247);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(100, 23);
            txtTotalPrice.TabIndex = 5;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtTotalQuantity);
            Controls.Add(lbTotalPrice);
            Controls.Add(lblTotalQuantity);
            Controls.Add(btnClose);
            Controls.Add(dgvOrderDetail);
            Name = "frmOrderDetail";
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetail;
        private Button btnClose;
        private Label lblTotalQuantity;
        private Label lbTotalPrice;
        private TextBox txtTotalQuantity;
        private TextBox txtTotalPrice;
    }
}