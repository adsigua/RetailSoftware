namespace RetailSoftware
{
    partial class ReportsSubMenuForm
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
            this.tblpSubFormReports = new System.Windows.Forms.TableLayoutPanel();
            this.btnPayments = new System.Windows.Forms.CheckBox();
            this.btnReports = new System.Windows.Forms.CheckBox();
            this.btnChecksInventory = new System.Windows.Forms.CheckBox();
            this.tblpSubFormReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpSubFormReports
            // 
            this.tblpSubFormReports.ColumnCount = 2;
            this.tblpSubFormReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.701031F));
            this.tblpSubFormReports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.29897F));
            this.tblpSubFormReports.Controls.Add(this.btnPayments, 1, 2);
            this.tblpSubFormReports.Controls.Add(this.btnReports, 1, 1);
            this.tblpSubFormReports.Controls.Add(this.btnChecksInventory, 1, 0);
            this.tblpSubFormReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpSubFormReports.Location = new System.Drawing.Point(0, 0);
            this.tblpSubFormReports.Margin = new System.Windows.Forms.Padding(0);
            this.tblpSubFormReports.Name = "tblpSubFormReports";
            this.tblpSubFormReports.RowCount = 3;
            this.tblpSubFormReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormReports.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormReports.Size = new System.Drawing.Size(194, 81);
            this.tblpSubFormReports.TabIndex = 18;
            // 
            // btnPayments
            // 
            this.btnPayments.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPayments.AutoSize = true;
            this.btnPayments.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPayments.Location = new System.Drawing.Point(12, 54);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(182, 27);
            this.btnPayments.TabIndex = 18;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // btnReports
            // 
            this.btnReports.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnReports.AutoSize = true;
            this.btnReports.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReports.Location = new System.Drawing.Point(12, 27);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(182, 27);
            this.btnReports.TabIndex = 17;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // btnChecksInventory
            // 
            this.btnChecksInventory.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnChecksInventory.AutoSize = true;
            this.btnChecksInventory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnChecksInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChecksInventory.FlatAppearance.BorderSize = 0;
            this.btnChecksInventory.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnChecksInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecksInventory.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecksInventory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChecksInventory.Location = new System.Drawing.Point(12, 0);
            this.btnChecksInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnChecksInventory.Name = "btnChecksInventory";
            this.btnChecksInventory.Size = new System.Drawing.Size(182, 27);
            this.btnChecksInventory.TabIndex = 16;
            this.btnChecksInventory.Text = "Checks Inventory";
            this.btnChecksInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChecksInventory.UseVisualStyleBackColor = false;
            this.btnChecksInventory.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // ReportsSubMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(194, 81);
            this.Controls.Add(this.tblpSubFormReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsSubMenuForm";
            this.Text = "ReportsSubMenuForm";
            this.tblpSubFormReports.ResumeLayout(false);
            this.tblpSubFormReports.PerformLayout();
            this.Resize += new System.EventHandler(this.SubMenu_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpSubFormReports;
        private System.Windows.Forms.CheckBox btnPayments;
        private System.Windows.Forms.CheckBox btnReports;
        private System.Windows.Forms.CheckBox btnChecksInventory;
    }
}