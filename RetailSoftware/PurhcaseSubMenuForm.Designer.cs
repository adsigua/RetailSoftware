namespace RetailSoftware
{
    partial class PurhcaseSubMenuForm
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
            this.tblpSubFormPurchase = new System.Windows.Forms.TableLayoutPanel();
            this.btnExpenses = new System.Windows.Forms.CheckBox();
            this.btnSuppliers = new System.Windows.Forms.CheckBox();
            this.btnPurchaseHistory = new System.Windows.Forms.CheckBox();
            this.tblpSubFormPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpSubFormPurchase
            // 
            this.tblpSubFormPurchase.ColumnCount = 2;
            this.tblpSubFormPurchase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.701031F));
            this.tblpSubFormPurchase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.29897F));
            this.tblpSubFormPurchase.Controls.Add(this.btnExpenses, 1, 2);
            this.tblpSubFormPurchase.Controls.Add(this.btnSuppliers, 1, 1);
            this.tblpSubFormPurchase.Controls.Add(this.btnPurchaseHistory, 1, 0);
            this.tblpSubFormPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpSubFormPurchase.Location = new System.Drawing.Point(0, 0);
            this.tblpSubFormPurchase.Margin = new System.Windows.Forms.Padding(0);
            this.tblpSubFormPurchase.Name = "tblpSubFormPurchase";
            this.tblpSubFormPurchase.RowCount = 3;
            this.tblpSubFormPurchase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpSubFormPurchase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpSubFormPurchase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpSubFormPurchase.Size = new System.Drawing.Size(194, 81);
            this.tblpSubFormPurchase.TabIndex = 16;
            this.tblpSubFormPurchase.Resize += new System.EventHandler(this.tblpSubFormPurchase_Resize);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnExpenses.AutoSize = true;
            this.btnExpenses.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExpenses.Location = new System.Drawing.Point(12, 54);
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(182, 27);
            this.btnExpenses.TabIndex = 18;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.subMenu_Clicked);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSuppliers.AutoSize = true;
            this.btnSuppliers.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuppliers.Location = new System.Drawing.Point(12, 27);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(182, 27);
            this.btnSuppliers.TabIndex = 17;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.subMenu_Clicked);
            // 
            // btnPurchaseHistory
            // 
            this.btnPurchaseHistory.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPurchaseHistory.AutoSize = true;
            this.btnPurchaseHistory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPurchaseHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            this.btnPurchaseHistory.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPurchaseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseHistory.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPurchaseHistory.Location = new System.Drawing.Point(12, 0);
            this.btnPurchaseHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnPurchaseHistory.Name = "btnPurchaseHistory";
            this.btnPurchaseHistory.Size = new System.Drawing.Size(182, 27);
            this.btnPurchaseHistory.TabIndex = 16;
            this.btnPurchaseHistory.Text = "Purchase History";
            this.btnPurchaseHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPurchaseHistory.UseVisualStyleBackColor = false;
            this.btnPurchaseHistory.Click += new System.EventHandler(this.subMenu_Clicked);
            // 
            // PurhcaseSubMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(194, 81);
            this.Controls.Add(this.tblpSubFormPurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurhcaseSubMenuForm";
            this.Text = "PurhcaseSubMenuForm";
            this.tblpSubFormPurchase.ResumeLayout(false);
            this.tblpSubFormPurchase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpSubFormPurchase;
        private System.Windows.Forms.CheckBox btnExpenses;
        private System.Windows.Forms.CheckBox btnSuppliers;
        private System.Windows.Forms.CheckBox btnPurchaseHistory;
    }
}