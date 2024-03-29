namespace SaleManagementWinApp
{
    partial class frmCheckout
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
            btnCheckout = new Button();
            btnClose = new Button();
            numericAmount = new NumericUpDown();
            lbAmount = new Label();
            btnChangeAmount = new Button();
            dgvProductListCheckOut = new DataGridView();
            pnlControl = new Panel();
            pnlChange = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductListCheckOut).BeginInit();
            pnlControl.SuspendLayout();
            pnlChange.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(16, 60);
            btnCheckout.Margin = new Padding(3, 2, 3, 2);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(82, 57);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(124, 60);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 57);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // numericAmount
            // 
            numericAmount.Enabled = false;
            numericAmount.Location = new Point(81, 13);
            numericAmount.Margin = new Padding(3, 2, 3, 2);
            numericAmount.Name = "numericAmount";
            numericAmount.Size = new Size(125, 23);
            numericAmount.TabIndex = 5;
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Location = new Point(16, 13);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(51, 15);
            lbAmount.TabIndex = 6;
            lbAmount.Text = "Amount";
            // 
            // btnChangeAmount
            // 
            btnChangeAmount.Enabled = false;
            btnChangeAmount.Location = new Point(102, 40);
            btnChangeAmount.Margin = new Padding(3, 2, 3, 2);
            btnChangeAmount.Name = "btnChangeAmount";
            btnChangeAmount.Size = new Size(104, 36);
            btnChangeAmount.TabIndex = 7;
            btnChangeAmount.Text = "Change";
            btnChangeAmount.UseVisualStyleBackColor = true;
            btnChangeAmount.Click += btnChangeAmount_Click;
            // 
            // dgvProductListCheckOut
            // 
            dgvProductListCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductListCheckOut.Location = new Point(1, 0);
            dgvProductListCheckOut.Name = "dgvProductListCheckOut";
            dgvProductListCheckOut.Size = new Size(426, 323);
            dgvProductListCheckOut.TabIndex = 8;
            dgvProductListCheckOut.CellClick += dgvProductListCheckOut_CellClick;
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(btnCheckout);
            pnlControl.Controls.Add(btnClose);
            pnlControl.Location = new Point(433, 100);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(228, 211);
            pnlControl.TabIndex = 9;
            // 
            // pnlChange
            // 
            pnlChange.Controls.Add(lbAmount);
            pnlChange.Controls.Add(btnChangeAmount);
            pnlChange.Controls.Add(numericAmount);
            pnlChange.Location = new Point(433, 7);
            pnlChange.Name = "pnlChange";
            pnlChange.Size = new Size(228, 88);
            pnlChange.TabIndex = 10;
            // 
            // frmCheckout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 317);
            Controls.Add(dgvProductListCheckOut);
            Controls.Add(pnlControl);
            Controls.Add(pnlChange);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCheckout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCheckout";
            Load += frmCheckout_Load;
            ((System.ComponentModel.ISupportInitialize)numericAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductListCheckOut).EndInit();
            pnlControl.ResumeLayout(false);
            pnlChange.ResumeLayout(false);
            pnlChange.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCheckout;
        private Button btnClose;
        private NumericUpDown numericAmount;
        private Label lbAmount;
        private Button btnChangeAmount;
        private DataGridView dgvProductListCheckOut;
        private Panel pnlControl;
        private Panel pnlChange;
    }
}