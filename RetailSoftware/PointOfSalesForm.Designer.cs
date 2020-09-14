namespace RetailSoftware
{
    partial class PointOfSalesForm
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
            this.tblpPOSMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblpSales = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSalesItems = new System.Windows.Forms.Panel();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.cQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSellingUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cItemReservation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbplProducts = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.cProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.cProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProductCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNewSales = new FontAwesome.Sharp.IconButton();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.tblpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lbDate = new System.Windows.Forms.Label();
            this.panelDate = new System.Windows.Forms.Panel();
            this.tblpDetailsBot = new System.Windows.Forms.TableLayoutPanel();
            this.tblpDetailsTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelInvoiceNumber = new System.Windows.Forms.Panel();
            this.lbInvoiceNumber = new System.Windows.Forms.Label();
            this.tbInvoiceNumber = new System.Windows.Forms.TextBox();
            this.panelCustomerName = new System.Windows.Forms.Panel();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tblpProductsTop = new System.Windows.Forms.TableLayoutPanel();
            this.tblpInvoiceNumber = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblpPOSMain.SuspendLayout();
            this.tblpSales.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlSalesItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            this.tbplProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.tblpDetails.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.tblpDetailsBot.SuspendLayout();
            this.tblpDetailsTop.SuspendLayout();
            this.tblpProductsTop.SuspendLayout();
            this.tblpInvoiceNumber.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpPOSMain
            // 
            this.tblpPOSMain.ColumnCount = 2;
            this.tblpPOSMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblpPOSMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblpPOSMain.Controls.Add(this.tblpSales, 0, 0);
            this.tblpPOSMain.Controls.Add(this.tbplProducts, 1, 0);
            this.tblpPOSMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpPOSMain.Location = new System.Drawing.Point(0, 0);
            this.tblpPOSMain.Name = "tblpPOSMain";
            this.tblpPOSMain.RowCount = 1;
            this.tblpPOSMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpPOSMain.Size = new System.Drawing.Size(1044, 556);
            this.tblpPOSMain.TabIndex = 0;
            // 
            // tblpSales
            // 
            this.tblpSales.ColumnCount = 1;
            this.tblpSales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpSales.Controls.Add(this.tblpDetails, 0, 0);
            this.tblpSales.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tblpSales.Controls.Add(this.pnlSalesItems, 0, 1);
            this.tblpSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpSales.Location = new System.Drawing.Point(10, 0);
            this.tblpSales.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tblpSales.Name = "tblpSales";
            this.tblpSales.RowCount = 3;
            this.tblpSales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.88316F));
            this.tblpSales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.11684F));
            this.tblpSales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblpSales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpSales.Size = new System.Drawing.Size(407, 556);
            this.tblpSales.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelCustomerName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 433);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(407, 123);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // pnlSalesItems
            // 
            this.pnlSalesItems.Controls.Add(this.dataGridItems);
            this.pnlSalesItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesItems.Location = new System.Drawing.Point(3, 106);
            this.pnlSalesItems.Name = "pnlSalesItems";
            this.pnlSalesItems.Size = new System.Drawing.Size(401, 324);
            this.pnlSalesItems.TabIndex = 0;
            // 
            // dataGridItems
            // 
            this.dataGridItems.AllowDrop = true;
            this.dataGridItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cQuantity,
            this.cItemName,
            this.cSellingUnit,
            this.cItemReservation,
            this.cUnitPrice});
            this.dataGridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridItems.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridItems.MultiSelect = false;
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowHeadersVisible = false;
            this.dataGridItems.RowHeadersWidth = 56;
            this.dataGridItems.RowTemplate.Height = 24;
            this.dataGridItems.Size = new System.Drawing.Size(401, 324);
            this.dataGridItems.TabIndex = 0;
            // 
            // cQuantity
            // 
            this.cQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cQuantity.FillWeight = 8F;
            this.cQuantity.Frozen = true;
            this.cQuantity.HeaderText = "Qty.";
            this.cQuantity.MinimumWidth = 7;
            this.cQuantity.Name = "cQuantity";
            this.cQuantity.Width = 63;
            // 
            // cItemName
            // 
            this.cItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cItemName.FillWeight = 38F;
            this.cItemName.HeaderText = "Product";
            this.cItemName.MinimumWidth = 7;
            this.cItemName.Name = "cItemName";
            this.cItemName.ReadOnly = true;
            // 
            // cSellingUnit
            // 
            this.cSellingUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cSellingUnit.FillWeight = 15F;
            this.cSellingUnit.HeaderText = "Unit";
            this.cSellingUnit.MinimumWidth = 7;
            this.cSellingUnit.Name = "cSellingUnit";
            // 
            // cItemReservation
            // 
            this.cItemReservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cItemReservation.FillWeight = 24F;
            this.cItemReservation.HeaderText = "Reservation";
            this.cItemReservation.MinimumWidth = 7;
            this.cItemReservation.Name = "cItemReservation";
            this.cItemReservation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cItemReservation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cUnitPrice
            // 
            this.cUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cUnitPrice.FillWeight = 15F;
            this.cUnitPrice.HeaderText = "Price";
            this.cUnitPrice.MinimumWidth = 7;
            this.cUnitPrice.Name = "cUnitPrice";
            this.cUnitPrice.ReadOnly = true;
            // 
            // tbplProducts
            // 
            this.tbplProducts.ColumnCount = 1;
            this.tbplProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbplProducts.Controls.Add(this.panelInvoiceNumber, 0, 2);
            this.tbplProducts.Controls.Add(this.dataGridProducts, 0, 1);
            this.tbplProducts.Controls.Add(this.tblpProductsTop, 0, 0);
            this.tbplProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbplProducts.Location = new System.Drawing.Point(420, 3);
            this.tbplProducts.Name = "tbplProducts";
            this.tbplProducts.RowCount = 3;
            this.tbplProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.26059F));
            this.tbplProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.73941F));
            this.tbplProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tbplProducts.Size = new System.Drawing.Size(621, 550);
            this.tbplProducts.TabIndex = 1;
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProductImage,
            this.cProductName,
            this.cProductCategory,
            this.cProductCompany,
            this.cAddProduct});
            this.dataGridProducts.Location = new System.Drawing.Point(10, 60);
            this.dataGridProducts.Margin = new System.Windows.Forms.Padding(10, 15, 15, 15);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.RowHeadersVisible = false;
            this.dataGridProducts.RowHeadersWidth = 56;
            this.dataGridProducts.RowTemplate.Height = 24;
            this.dataGridProducts.Size = new System.Drawing.Size(596, 367);
            this.dataGridProducts.TabIndex = 0;
            // 
            // cProductImage
            // 
            this.cProductImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cProductImage.FillWeight = 20F;
            this.cProductImage.HeaderText = "Image";
            this.cProductImage.MinimumWidth = 7;
            this.cProductImage.Name = "cProductImage";
            this.cProductImage.ReadOnly = true;
            // 
            // cProductName
            // 
            this.cProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cProductName.FillWeight = 45F;
            this.cProductName.HeaderText = "Product";
            this.cProductName.MinimumWidth = 7;
            this.cProductName.Name = "cProductName";
            this.cProductName.ReadOnly = true;
            // 
            // cProductCategory
            // 
            this.cProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cProductCategory.FillWeight = 15F;
            this.cProductCategory.HeaderText = "Category";
            this.cProductCategory.MinimumWidth = 7;
            this.cProductCategory.Name = "cProductCategory";
            this.cProductCategory.ReadOnly = true;
            // 
            // cProductCompany
            // 
            this.cProductCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cProductCompany.FillWeight = 15F;
            this.cProductCompany.HeaderText = "Company";
            this.cProductCompany.MinimumWidth = 7;
            this.cProductCompany.Name = "cProductCompany";
            this.cProductCompany.ReadOnly = true;
            // 
            // cAddProduct
            // 
            this.cAddProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAddProduct.FillWeight = 5F;
            this.cAddProduct.HeaderText = "Add";
            this.cAddProduct.MinimumWidth = 7;
            this.cAddProduct.Name = "cAddProduct";
            this.cAddProduct.ReadOnly = true;
            // 
            // btnNewSales
            // 
            this.btnNewSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewSales.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNewSales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNewSales.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNewSales.IconColor = System.Drawing.Color.White;
            this.btnNewSales.IconSize = 20;
            this.btnNewSales.Location = new System.Drawing.Point(3, 3);
            this.btnNewSales.Name = "btnNewSales";
            this.btnNewSales.Rotation = 0D;
            this.btnNewSales.Size = new System.Drawing.Size(41, 39);
            this.btnNewSales.TabIndex = 4;
            this.btnNewSales.UseVisualStyleBackColor = false;
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductSearch.Font = new System.Drawing.Font("Lucida Console", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbProductSearch.Location = new System.Drawing.Point(304, 5);
            this.tbProductSearch.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.tbProductSearch.MaxLength = 100;
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.Size = new System.Drawing.Size(292, 37);
            this.tbProductSearch.TabIndex = 3;
            this.tbProductSearch.Text = "Search";
            this.tbProductSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbProductSearch.Click += new System.EventHandler(this.tbProductSearch_Click);
            this.tbProductSearch.Leave += new System.EventHandler(this.tbProductSearch_Leave);
            // 
            // tblpDetails
            // 
            this.tblpDetails.ColumnCount = 1;
            this.tblpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.5985F));
            this.tblpDetails.Controls.Add(this.tblpDetailsBot, 0, 1);
            this.tblpDetails.Controls.Add(this.tblpDetailsTop, 0, 0);
            this.tblpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpDetails.Location = new System.Drawing.Point(0, 0);
            this.tblpDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tblpDetails.Name = "tblpDetails";
            this.tblpDetails.RowCount = 2;
            this.tblpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.14433F));
            this.tblpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.85567F));
            this.tblpDetails.Size = new System.Drawing.Size(407, 103);
            this.tblpDetails.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDate.Location = new System.Drawing.Point(77, 15);
            this.lbDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbDate.Name = "lbDate";
            this.lbDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDate.Size = new System.Drawing.Size(124, 21);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "Year, Month Day";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDate.Controls.Add(this.lbDate);
            this.panelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDate.Location = new System.Drawing.Point(203, 0);
            this.panelDate.Margin = new System.Windows.Forms.Padding(0);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(204, 39);
            this.panelDate.TabIndex = 2;
            // 
            // tblpDetailsBot
            // 
            this.tblpDetailsBot.ColumnCount = 1;
            this.tblpDetailsBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDetailsBot.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblpDetailsBot.Controls.Add(this.tblpInvoiceNumber, 0, 0);
            this.tblpDetailsBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpDetailsBot.Location = new System.Drawing.Point(0, 39);
            this.tblpDetailsBot.Margin = new System.Windows.Forms.Padding(0);
            this.tblpDetailsBot.Name = "tblpDetailsBot";
            this.tblpDetailsBot.RowCount = 2;
            this.tblpDetailsBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDetailsBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDetailsBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpDetailsBot.Size = new System.Drawing.Size(407, 64);
            this.tblpDetailsBot.TabIndex = 3;
            // 
            // tblpDetailsTop
            // 
            this.tblpDetailsTop.ColumnCount = 2;
            this.tblpDetailsTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDetailsTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDetailsTop.Controls.Add(this.panelDate, 1, 0);
            this.tblpDetailsTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpDetailsTop.Location = new System.Drawing.Point(0, 0);
            this.tblpDetailsTop.Margin = new System.Windows.Forms.Padding(0);
            this.tblpDetailsTop.Name = "tblpDetailsTop";
            this.tblpDetailsTop.RowCount = 1;
            this.tblpDetailsTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDetailsTop.Size = new System.Drawing.Size(407, 39);
            this.tblpDetailsTop.TabIndex = 4;
            // 
            // panelInvoiceNumber
            // 
            this.panelInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoiceNumber.Location = new System.Drawing.Point(0, 442);
            this.panelInvoiceNumber.Margin = new System.Windows.Forms.Padding(0);
            this.panelInvoiceNumber.Name = "panelInvoiceNumber";
            this.panelInvoiceNumber.Size = new System.Drawing.Size(621, 108);
            this.panelInvoiceNumber.TabIndex = 2;
            // 
            // lbInvoiceNumber
            // 
            this.lbInvoiceNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbInvoiceNumber.AutoSize = true;
            this.lbInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoiceNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbInvoiceNumber.Location = new System.Drawing.Point(3, 4);
            this.lbInvoiceNumber.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lbInvoiceNumber.Name = "lbInvoiceNumber";
            this.lbInvoiceNumber.Size = new System.Drawing.Size(114, 20);
            this.lbInvoiceNumber.TabIndex = 11;
            this.lbInvoiceNumber.Text = "Invoice Number";
            this.lbInvoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInvoiceNumber
            // 
            this.tbInvoiceNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceNumber.Location = new System.Drawing.Point(142, 4);
            this.tbInvoiceNumber.MaximumSize = new System.Drawing.Size(210, 35);
            this.tbInvoiceNumber.MinimumSize = new System.Drawing.Size(4, 22);
            this.tbInvoiceNumber.Name = "tbInvoiceNumber";
            this.tbInvoiceNumber.Size = new System.Drawing.Size(210, 23);
            this.tbInvoiceNumber.TabIndex = 7;
            // 
            // panelCustomerName
            // 
            this.panelCustomerName.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerName.Margin = new System.Windows.Forms.Padding(0);
            this.panelCustomerName.Name = "panelCustomerName";
            this.panelCustomerName.Size = new System.Drawing.Size(401, 31);
            this.panelCustomerName.TabIndex = 2;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(142, 3);
            this.tbCustomerName.MaximumSize = new System.Drawing.Size(190, 35);
            this.tbCustomerName.MinimumSize = new System.Drawing.Size(4, 22);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(175, 23);
            this.tbCustomerName.TabIndex = 8;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCustomerName.Location = new System.Drawing.Point(3, 0);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(116, 20);
            this.lbCustomerName.TabIndex = 9;
            this.lbCustomerName.Text = "Customer Name";
            this.lbCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCustomerName.Click += new System.EventHandler(this.lbCustomerName_Click);
            // 
            // tblpProductsTop
            // 
            this.tblpProductsTop.ColumnCount = 3;
            this.tblpProductsTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.88245F));
            this.tblpProductsTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpProductsTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.tblpProductsTop.Controls.Add(this.btnNewSales, 0, 0);
            this.tblpProductsTop.Controls.Add(this.tbProductSearch, 2, 0);
            this.tblpProductsTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpProductsTop.Location = new System.Drawing.Point(5, 0);
            this.tblpProductsTop.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tblpProductsTop.Name = "tblpProductsTop";
            this.tblpProductsTop.RowCount = 1;
            this.tblpProductsTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpProductsTop.Size = new System.Drawing.Size(616, 45);
            this.tblpProductsTop.TabIndex = 3;
            // 
            // tblpInvoiceNumber
            // 
            this.tblpInvoiceNumber.ColumnCount = 2;
            this.tblpInvoiceNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.39803F));
            this.tblpInvoiceNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.60197F));
            this.tblpInvoiceNumber.Controls.Add(this.lbInvoiceNumber, 0, 0);
            this.tblpInvoiceNumber.Controls.Add(this.tbInvoiceNumber, 1, 0);
            this.tblpInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpInvoiceNumber.Location = new System.Drawing.Point(0, 0);
            this.tblpInvoiceNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tblpInvoiceNumber.Name = "tblpInvoiceNumber";
            this.tblpInvoiceNumber.RowCount = 1;
            this.tblpInvoiceNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpInvoiceNumber.Size = new System.Drawing.Size(407, 32);
            this.tblpInvoiceNumber.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.39803F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.60197F));
            this.tableLayoutPanel1.Controls.Add(this.tbCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCustomerName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PointOfSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1044, 556);
            this.Controls.Add(this.tblpPOSMain);
            this.Name = "PointOfSalesForm";
            this.Text = "Sales Form";
            this.Resize += new System.EventHandler(this.PointOfSalesForm_Resize);
            this.tblpPOSMain.ResumeLayout(false);
            this.tblpSales.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlSalesItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            this.tbplProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.tblpDetails.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.tblpDetailsBot.ResumeLayout(false);
            this.tblpDetailsTop.ResumeLayout(false);
            this.tblpProductsTop.ResumeLayout(false);
            this.tblpProductsTop.PerformLayout();
            this.tblpInvoiceNumber.ResumeLayout(false);
            this.tblpInvoiceNumber.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpPOSMain;
        private System.Windows.Forms.TableLayoutPanel tblpSales;
        private System.Windows.Forms.Panel pnlSalesItems;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.TableLayoutPanel tbplProducts;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.DataGridViewImageColumn cProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProductCompany;
        private System.Windows.Forms.DataGridViewButtonColumn cAddProduct;
        private FontAwesome.Sharp.IconButton btnNewSales;
        private System.Windows.Forms.TextBox tbProductSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cSellingUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn cItemReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnitPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblpDetails;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TableLayoutPanel tblpDetailsBot;
        private System.Windows.Forms.TableLayoutPanel tblpDetailsTop;
        private System.Windows.Forms.Panel panelCustomerName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Panel panelInvoiceNumber;
        private System.Windows.Forms.Label lbInvoiceNumber;
        private System.Windows.Forms.TextBox tbInvoiceNumber;
        private System.Windows.Forms.TableLayoutPanel tblpProductsTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblpInvoiceNumber;
    }
}