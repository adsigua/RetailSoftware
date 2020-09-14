namespace RetailSoftware
{
    partial class MainForm
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
            this.tblpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tblpDashBoard = new System.Windows.Forms.TableLayoutPanel();
            this.tblpDBButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDBSales = new System.Windows.Forms.CheckBox();
            this.btnDBInventory = new System.Windows.Forms.CheckBox();
            this.btnDBPurchase = new System.Windows.Forms.CheckBox();
            this.btnDBAccounts = new System.Windows.Forms.CheckBox();
            this.btnDBReports = new System.Windows.Forms.CheckBox();
            this.btnDBSettings = new System.Windows.Forms.CheckBox();
            this.btnDBExit = new System.Windows.Forms.CheckBox();
            this.panelDashBoardSubItems = new System.Windows.Forms.Panel();
            this.tblpMain.SuspendLayout();
            this.tblpDashBoard.SuspendLayout();
            this.tblpDBButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpMain
            // 
            this.tblpMain.BackColor = System.Drawing.SystemColors.Menu;
            this.tblpMain.ColumnCount = 2;
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.87302F));
            this.tblpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.12698F));
            this.tblpMain.Controls.Add(this.panelBody, 0, 1);
            this.tblpMain.Controls.Add(this.tblpDashBoard, 0, 0);
            this.tblpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpMain.Location = new System.Drawing.Point(0, 0);
            this.tblpMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblpMain.Name = "tblpMain";
            this.tblpMain.RowCount = 2;
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.846154F));
            this.tblpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.15385F));
            this.tblpMain.Size = new System.Drawing.Size(948, 536);
            this.tblpMain.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(150, 42);
            this.panelBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(798, 494);
            this.panelBody.TabIndex = 2;
            // 
            // tblpDashBoard
            // 
            this.tblpDashBoard.BackColor = System.Drawing.Color.MidnightBlue;
            this.tblpDashBoard.ColumnCount = 1;
            this.tblpDashBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpDashBoard.Controls.Add(this.tblpDBButtons, 0, 1);
            this.tblpDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpDashBoard.Location = new System.Drawing.Point(0, 0);
            this.tblpDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.tblpDashBoard.Name = "tblpDashBoard";
            this.tblpDashBoard.RowCount = 2;
            this.tblpMain.SetRowSpan(this.tblpDashBoard, 2);
            this.tblpDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.538462F));
            this.tblpDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.46154F));
            this.tblpDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblpDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblpDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblpDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblpDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblpDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblpDashBoard.Size = new System.Drawing.Size(150, 536);
            this.tblpDashBoard.TabIndex = 0;
            // 
            // tblpDBButtons
            // 
            this.tblpDBButtons.ColumnCount = 1;
            this.tblpDBButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpDBButtons.Controls.Add(this.btnDBSales, 0, 0);
            this.tblpDBButtons.Controls.Add(this.btnDBInventory, 0, 1);
            this.tblpDBButtons.Controls.Add(this.btnDBPurchase, 0, 2);
            this.tblpDBButtons.Controls.Add(this.btnDBAccounts, 0, 3);
            this.tblpDBButtons.Controls.Add(this.btnDBReports, 0, 4);
            this.tblpDBButtons.Controls.Add(this.btnDBSettings, 0, 5);
            this.tblpDBButtons.Controls.Add(this.btnDBExit, 0, 6);
            this.tblpDBButtons.Controls.Add(this.panelDashBoardSubItems, 0, 7);
            this.tblpDBButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpDBButtons.Location = new System.Drawing.Point(2, 42);
            this.tblpDBButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblpDBButtons.Name = "tblpDBButtons";
            this.tblpDBButtons.RowCount = 8;
            this.tblpDBButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpDBButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpDBButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpDBButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpDBButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpDBButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpDBButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpDBButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblpDBButtons.Size = new System.Drawing.Size(146, 492);
            this.tblpDBButtons.TabIndex = 0;
            // 
            // btnDBSales
            // 
            this.btnDBSales.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDBSales.AutoSize = true;
            this.btnDBSales.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDBSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDBSales.FlatAppearance.BorderSize = 0;
            this.btnDBSales.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDBSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBSales.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBSales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDBSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBSales.Location = new System.Drawing.Point(0, 0);
            this.btnDBSales.Margin = new System.Windows.Forms.Padding(0);
            this.btnDBSales.Name = "btnDBSales";
            this.btnDBSales.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDBSales.Size = new System.Drawing.Size(146, 61);
            this.btnDBSales.TabIndex = 16;
            this.btnDBSales.Text = "Sales";
            this.btnDBSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDBSales.UseVisualStyleBackColor = false;
            this.btnDBSales.Click += new System.EventHandler(this.btnDashBoard_Clicked);
            // 
            // btnDBInventory
            // 
            this.btnDBInventory.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDBInventory.AutoSize = true;
            this.btnDBInventory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDBInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDBInventory.FlatAppearance.BorderSize = 0;
            this.btnDBInventory.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDBInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBInventory.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBInventory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDBInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBInventory.Location = new System.Drawing.Point(0, 61);
            this.btnDBInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnDBInventory.Name = "btnDBInventory";
            this.btnDBInventory.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDBInventory.Size = new System.Drawing.Size(146, 61);
            this.btnDBInventory.TabIndex = 17;
            this.btnDBInventory.Text = "Inventory";
            this.btnDBInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDBInventory.UseVisualStyleBackColor = false;
            this.btnDBInventory.Click += new System.EventHandler(this.btnDashBoard_Clicked);
            // 
            // btnDBPurchase
            // 
            this.btnDBPurchase.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDBPurchase.AutoSize = true;
            this.btnDBPurchase.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDBPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDBPurchase.FlatAppearance.BorderSize = 0;
            this.btnDBPurchase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDBPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBPurchase.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBPurchase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDBPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBPurchase.Location = new System.Drawing.Point(0, 122);
            this.btnDBPurchase.Margin = new System.Windows.Forms.Padding(0);
            this.btnDBPurchase.Name = "btnDBPurchase";
            this.btnDBPurchase.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDBPurchase.Size = new System.Drawing.Size(146, 61);
            this.btnDBPurchase.TabIndex = 18;
            this.btnDBPurchase.Text = "Purchase";
            this.btnDBPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDBPurchase.UseVisualStyleBackColor = false;
            this.btnDBPurchase.Click += new System.EventHandler(this.btnDashBoard_Clicked);
            // 
            // btnDBAccounts
            // 
            this.btnDBAccounts.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDBAccounts.AutoSize = true;
            this.btnDBAccounts.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDBAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDBAccounts.FlatAppearance.BorderSize = 0;
            this.btnDBAccounts.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDBAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBAccounts.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBAccounts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDBAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBAccounts.Location = new System.Drawing.Point(0, 183);
            this.btnDBAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.btnDBAccounts.Name = "btnDBAccounts";
            this.btnDBAccounts.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDBAccounts.Size = new System.Drawing.Size(146, 61);
            this.btnDBAccounts.TabIndex = 19;
            this.btnDBAccounts.Text = "Accounts";
            this.btnDBAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDBAccounts.UseVisualStyleBackColor = false;
            this.btnDBAccounts.Click += new System.EventHandler(this.btnDashBoard_Clicked);
            // 
            // btnDBReports
            // 
            this.btnDBReports.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDBReports.AutoSize = true;
            this.btnDBReports.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDBReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDBReports.FlatAppearance.BorderSize = 0;
            this.btnDBReports.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDBReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBReports.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBReports.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDBReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBReports.Location = new System.Drawing.Point(0, 244);
            this.btnDBReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnDBReports.Name = "btnDBReports";
            this.btnDBReports.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDBReports.Size = new System.Drawing.Size(146, 61);
            this.btnDBReports.TabIndex = 20;
            this.btnDBReports.Text = "Reports";
            this.btnDBReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDBReports.UseVisualStyleBackColor = false;
            this.btnDBReports.Click += new System.EventHandler(this.btnDashBoard_Clicked);
            // 
            // btnDBSettings
            // 
            this.btnDBSettings.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDBSettings.AutoSize = true;
            this.btnDBSettings.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDBSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDBSettings.FlatAppearance.BorderSize = 0;
            this.btnDBSettings.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDBSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBSettings.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDBSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBSettings.Location = new System.Drawing.Point(0, 305);
            this.btnDBSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnDBSettings.Name = "btnDBSettings";
            this.btnDBSettings.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDBSettings.Size = new System.Drawing.Size(146, 61);
            this.btnDBSettings.TabIndex = 21;
            this.btnDBSettings.Text = "Settings";
            this.btnDBSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDBSettings.UseVisualStyleBackColor = false;
            this.btnDBSettings.Click += new System.EventHandler(this.btnDashBoard_Clicked);
            // 
            // btnDBExit
            // 
            this.btnDBExit.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnDBExit.AutoSize = true;
            this.btnDBExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDBExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDBExit.FlatAppearance.BorderSize = 0;
            this.btnDBExit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDBExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBExit.Font = new System.Drawing.Font("Segoe UI", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDBExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBExit.Location = new System.Drawing.Point(0, 366);
            this.btnDBExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnDBExit.Name = "btnDBExit";
            this.btnDBExit.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDBExit.Size = new System.Drawing.Size(146, 61);
            this.btnDBExit.TabIndex = 22;
            this.btnDBExit.Text = "Sign Out";
            this.btnDBExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDBExit.UseVisualStyleBackColor = false;
            this.btnDBExit.Click += new System.EventHandler(this.btnDashBoard_Clicked);
            // 
            // panelDashBoardSubItems
            // 
            this.panelDashBoardSubItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashBoardSubItems.Location = new System.Drawing.Point(0, 427);
            this.panelDashBoardSubItems.Margin = new System.Windows.Forms.Padding(0);
            this.panelDashBoardSubItems.Name = "panelDashBoardSubItems";
            this.panelDashBoardSubItems.Size = new System.Drawing.Size(146, 65);
            this.panelDashBoardSubItems.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(948, 536);
            this.Controls.Add(this.tblpMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(964, 575);
            this.Name = "MainForm";
            this.Text = "Retail Software";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tblpMain.ResumeLayout(false);
            this.tblpDashBoard.ResumeLayout(false);
            this.tblpDBButtons.ResumeLayout(false);
            this.tblpDBButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblpMain;
        private System.Windows.Forms.TableLayoutPanel tblpDashBoard;
        private System.Windows.Forms.TableLayoutPanel tblpDBButtons;
        private System.Windows.Forms.Panel panelDashBoardSubItems;
        private System.Windows.Forms.CheckBox btnDBSales;
        private System.Windows.Forms.CheckBox btnDBInventory;
        private System.Windows.Forms.CheckBox btnDBExit;
        private System.Windows.Forms.CheckBox btnDBSettings;
        private System.Windows.Forms.CheckBox btnDBReports;
        private System.Windows.Forms.CheckBox btnDBAccounts;
        private System.Windows.Forms.CheckBox btnDBPurchase;
        private System.Windows.Forms.Panel panelBody;
    }
}

