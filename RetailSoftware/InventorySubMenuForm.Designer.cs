namespace RetailSoftware
{
    partial class InventorySubMenuForm
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
            this.tblpSubFormInventory = new System.Windows.Forms.TableLayoutPanel();
            this.btnProductReturn = new System.Windows.Forms.CheckBox();
            this.btnManageWarehouse = new System.Windows.Forms.CheckBox();
            this.btnProductInventory = new System.Windows.Forms.CheckBox();
            this.btnProductList = new System.Windows.Forms.CheckBox();
            this.tblpSubFormInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpSubFormInventory
            // 
            this.tblpSubFormInventory.ColumnCount = 2;
            this.tblpSubFormInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.701031F));
            this.tblpSubFormInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.29897F));
            this.tblpSubFormInventory.Controls.Add(this.btnProductReturn, 1, 3);
            this.tblpSubFormInventory.Controls.Add(this.btnManageWarehouse, 1, 2);
            this.tblpSubFormInventory.Controls.Add(this.btnProductInventory, 1, 1);
            this.tblpSubFormInventory.Controls.Add(this.btnProductList, 1, 0);
            this.tblpSubFormInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpSubFormInventory.Location = new System.Drawing.Point(0, 0);
            this.tblpSubFormInventory.Margin = new System.Windows.Forms.Padding(0);
            this.tblpSubFormInventory.Name = "tblpSubFormInventory";
            this.tblpSubFormInventory.RowCount = 4;
            this.tblpSubFormInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpSubFormInventory.Size = new System.Drawing.Size(194, 108);
            this.tblpSubFormInventory.TabIndex = 16;
            // 
            // btnProductReturn
            // 
            this.btnProductReturn.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProductReturn.AutoSize = true;
            this.btnProductReturn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProductReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductReturn.FlatAppearance.BorderSize = 0;
            this.btnProductReturn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnProductReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductReturn.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductReturn.Location = new System.Drawing.Point(12, 81);
            this.btnProductReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductReturn.Name = "btnProductReturn";
            this.btnProductReturn.Size = new System.Drawing.Size(182, 27);
            this.btnProductReturn.TabIndex = 19;
            this.btnProductReturn.Text = "Product Return";
            this.btnProductReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductReturn.UseVisualStyleBackColor = false;
            this.btnProductReturn.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // btnManageWarehouse
            // 
            this.btnManageWarehouse.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnManageWarehouse.AutoSize = true;
            this.btnManageWarehouse.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnManageWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageWarehouse.FlatAppearance.BorderSize = 0;
            this.btnManageWarehouse.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnManageWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageWarehouse.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageWarehouse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageWarehouse.Location = new System.Drawing.Point(12, 54);
            this.btnManageWarehouse.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageWarehouse.Name = "btnManageWarehouse";
            this.btnManageWarehouse.Size = new System.Drawing.Size(182, 27);
            this.btnManageWarehouse.TabIndex = 18;
            this.btnManageWarehouse.Text = "Manage Warehouse";
            this.btnManageWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageWarehouse.UseVisualStyleBackColor = false;
            this.btnManageWarehouse.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // btnProductInventory
            // 
            this.btnProductInventory.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProductInventory.AutoSize = true;
            this.btnProductInventory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProductInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductInventory.FlatAppearance.BorderSize = 0;
            this.btnProductInventory.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnProductInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInventory.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInventory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductInventory.Location = new System.Drawing.Point(12, 27);
            this.btnProductInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductInventory.Name = "btnProductInventory";
            this.btnProductInventory.Size = new System.Drawing.Size(182, 27);
            this.btnProductInventory.TabIndex = 17;
            this.btnProductInventory.Text = "Product Inventory";
            this.btnProductInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductInventory.UseVisualStyleBackColor = false;
            this.btnProductInventory.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // btnProductList
            // 
            this.btnProductList.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProductList.AutoSize = true;
            this.btnProductList.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductList.FlatAppearance.BorderSize = 0;
            this.btnProductList.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductList.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductList.Location = new System.Drawing.Point(12, 0);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(182, 27);
            this.btnProductList.TabIndex = 16;
            this.btnProductList.Text = "Product Master List";
            this.btnProductList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.SubMenu_Clicked);
            // 
            // InventorySubMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(194, 108);
            this.Controls.Add(this.tblpSubFormInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventorySubMenuForm";
            this.Text = "InventorySubMenu";
            this.Resize += new System.EventHandler(this.SubMenu_Resize);
            this.tblpSubFormInventory.ResumeLayout(false);
            this.tblpSubFormInventory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpSubFormInventory;
        private System.Windows.Forms.CheckBox btnManageWarehouse;
        private System.Windows.Forms.CheckBox btnProductInventory;
        private System.Windows.Forms.CheckBox btnProductList;
        private System.Windows.Forms.CheckBox btnProductReturn;
    }
}