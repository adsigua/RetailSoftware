namespace RetailSoftware
{
    partial class AccountsSubMenuForm
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
            this.tblpSubFormAccounts = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreditMemo = new System.Windows.Forms.CheckBox();
            this.btnCustomer = new System.Windows.Forms.CheckBox();
            this.btnEmployee = new System.Windows.Forms.CheckBox();
            this.tblpSubFormAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpSubFormAccounts
            // 
            this.tblpSubFormAccounts.ColumnCount = 2;
            this.tblpSubFormAccounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.701031F));
            this.tblpSubFormAccounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.29897F));
            this.tblpSubFormAccounts.Controls.Add(this.btnCreditMemo, 1, 2);
            this.tblpSubFormAccounts.Controls.Add(this.btnCustomer, 1, 1);
            this.tblpSubFormAccounts.Controls.Add(this.btnEmployee, 1, 0);
            this.tblpSubFormAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpSubFormAccounts.Location = new System.Drawing.Point(0, 0);
            this.tblpSubFormAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.tblpSubFormAccounts.Name = "tblpSubFormAccounts";
            this.tblpSubFormAccounts.RowCount = 3;
            this.tblpSubFormAccounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormAccounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormAccounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormAccounts.Size = new System.Drawing.Size(194, 81);
            this.tblpSubFormAccounts.TabIndex = 17;
            // 
            // btnCreditMemo
            // 
            this.btnCreditMemo.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCreditMemo.AutoSize = true;
            this.btnCreditMemo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreditMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreditMemo.FlatAppearance.BorderSize = 0;
            this.btnCreditMemo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreditMemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditMemo.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditMemo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreditMemo.Location = new System.Drawing.Point(12, 54);
            this.btnCreditMemo.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreditMemo.Name = "btnCreditMemo";
            this.btnCreditMemo.Size = new System.Drawing.Size(182, 27);
            this.btnCreditMemo.TabIndex = 18;
            this.btnCreditMemo.Text = "Credit Memo";
            this.btnCreditMemo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreditMemo.UseVisualStyleBackColor = false;
            this.btnCreditMemo.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCustomer.AutoSize = true;
            this.btnCustomer.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustomer.Location = new System.Drawing.Point(12, 27);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(182, 27);
            this.btnCustomer.TabIndex = 17;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnEmployee.AutoSize = true;
            this.btnEmployee.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmployee.Location = new System.Drawing.Point(12, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(182, 27);
            this.btnEmployee.TabIndex = 16;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // AccountsSubMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(194, 81);
            this.Controls.Add(this.tblpSubFormAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsSubMenuForm";
            this.Text = "AccountsSubMenuForm";
            this.Resize += new System.EventHandler(this.SubMenu_Resize);
            this.tblpSubFormAccounts.ResumeLayout(false);
            this.tblpSubFormAccounts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpSubFormAccounts;
        private System.Windows.Forms.CheckBox btnCreditMemo;
        private System.Windows.Forms.CheckBox btnCustomer;
        private System.Windows.Forms.CheckBox btnEmployee;
    }
}