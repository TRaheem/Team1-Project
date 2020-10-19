namespace WorkShop2
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbTableList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAvailablePackages = new System.Windows.Forms.Panel();
            this.pkgNameListBox = new System.Windows.Forms.ListBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.package_ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPkdName = new System.Windows.Forms.TextBox();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgID = new System.Windows.Forms.TextBox();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgCommission = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxPackageProducts = new System.Windows.Forms.ListBox();
            this.btnAddProductToPackage = new System.Windows.Forms.Button();
            this.lblPackageTable = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.packageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExitProductSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.products_SupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btnCloseProductSupplier = new System.Windows.Forms.Button();
            this.btnEditProductSupplier = new System.Windows.Forms.Button();
            this.btnAddProductSupplier = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tltipAddPackage = new System.Windows.Forms.ToolTip(this.components);
            this.tltipEditPackages = new System.Windows.Forms.ToolTip(this.components);
            this.tltipExitPackages = new System.Windows.Forms.ToolTip(this.components);
            this.package_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packages_Products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.package_ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            pkgStartDateLabel = new System.Windows.Forms.Label();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlAvailablePackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.package_ProductDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.package_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.package_ProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(429, 154);
            pkgStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(102, 20);
            pkgStartDateLabel.TabIndex = 15;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            packageIdLabel.Location = new System.Drawing.Point(16, 137);
            packageIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(30, 20);
            packageIdLabel.TabIndex = 3;
            packageIdLabel.Text = "Id:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(16, 100);
            pkgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(63, 20);
            pkgNameLabel.TabIndex = 13;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(16, 177);
            pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(185, 20);
            pkgAgencyCommissionLabel.TabIndex = 5;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(429, 212);
            pkgEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(93, 20);
            pkgEndDateLabel.TabIndex = 11;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(16, 217);
            pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(108, 20);
            pkgBasePriceLabel.TabIndex = 7;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(429, 95);
            pkgDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(106, 20);
            pkgDescLabel.TabIndex = 9;
            pkgDescLabel.Text = "Description";
            // 
            // cmbTableList
            // 
            this.cmbTableList.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbTableList.FormattingEnabled = true;
            this.cmbTableList.Items.AddRange(new object[] {
            "Package Details",
            "Packages ",
            "Products/Suppliers",
            "Product_Suplier"});
            this.cmbTableList.Location = new System.Drawing.Point(28, 94);
            this.cmbTableList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTableList.Name = "cmbTableList";
            this.cmbTableList.Size = new System.Drawing.Size(508, 28);
            this.cmbTableList.TabIndex = 0;
            this.cmbTableList.SelectedIndexChanged += new System.EventHandler(this.cmbTableList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Travel Experts Database Management System";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(22, 151);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 691);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage1.Controls.Add(this.btnExitApplication);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pnlAvailablePackages);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.package_ProductDataGridView);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPkdName);
            this.tabPage1.Controls.Add(this.dtpPkgStartDate);
            this.tabPage1.Controls.Add(pkgStartDateLabel);
            this.tabPage1.Controls.Add(packageIdLabel);
            this.tabPage1.Controls.Add(pkgNameLabel);
            this.tabPage1.Controls.Add(this.txtPkgID);
            this.tabPage1.Controls.Add(this.dtpPkgEndDate);
            this.tabPage1.Controls.Add(pkgAgencyCommissionLabel);
            this.tabPage1.Controls.Add(pkgEndDateLabel);
            this.tabPage1.Controls.Add(this.txtPkgCommission);
            this.tabPage1.Controls.Add(this.txtPkgDesc);
            this.tabPage1.Controls.Add(pkgBasePriceLabel);
            this.tabPage1.Controls.Add(pkgDescLabel);
            this.tabPage1.Controls.Add(this.txtPkgBasePrice);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1152, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Package Details";
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.SeaShell;
            this.btnExitApplication.Location = new System.Drawing.Point(26, 592);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(130, 51);
            this.btnExitApplication.TabIndex = 31;
            this.btnExitApplication.Text = "&Exit";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Package Products And Suppliers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Select a package name to see detailed information";
            // 
            // pnlAvailablePackages
            // 
            this.pnlAvailablePackages.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlAvailablePackages.Controls.Add(this.pkgNameListBox);
            this.pnlAvailablePackages.Controls.Add(this.label2);
            this.pnlAvailablePackages.Location = new System.Drawing.Point(952, 20);
            this.pnlAvailablePackages.Name = "pnlAvailablePackages";
            this.pnlAvailablePackages.Size = new System.Drawing.Size(188, 246);
            this.pnlAvailablePackages.TabIndex = 28;
            // 
            // pkgNameListBox
            // 
            this.pkgNameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.packageBindingSource, "PkgName", true));
            this.pkgNameListBox.FormattingEnabled = true;
            this.pkgNameListBox.ItemHeight = 20;
            this.pkgNameListBox.Location = new System.Drawing.Point(4, 72);
            this.pkgNameListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgNameListBox.Name = "pkgNameListBox";
            this.pkgNameListBox.Size = new System.Drawing.Size(168, 144);
            this.pkgNameListBox.TabIndex = 18;
            this.pkgNameListBox.SelectedIndexChanged += new System.EventHandler(this.pkgNameListBox_SelectedIndexChanged);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(WorkShop2.Package);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Available Packages";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lstSuppliers);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbProductList);
            this.panel1.Location = new System.Drawing.Point(465, 326);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 320);
            this.panel1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "Suppliers";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 20;
            this.lstSuppliers.Location = new System.Drawing.Point(178, 92);
            this.lstSuppliers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(478, 204);
            this.lstSuppliers.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "Products";
            // 
            // cmbProductList
            // 
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(178, 32);
            this.cmbProductList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(476, 28);
            this.cmbProductList.TabIndex = 0;
            this.cmbProductList.SelectedIndexChanged += new System.EventHandler(this.cmbProductList_SelectedIndexChanged);
            // 
            // package_ProductDataGridView
            // 
            this.package_ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.package_ProductDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.package_ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.package_ProductDataGridView.Enabled = false;
            this.package_ProductDataGridView.Location = new System.Drawing.Point(21, 326);
            this.package_ProductDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.package_ProductDataGridView.Name = "package_ProductDataGridView";
            this.package_ProductDataGridView.RowHeadersWidth = 62;
            this.package_ProductDataGridView.Size = new System.Drawing.Size(352, 172);
            this.package_ProductDataGridView.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Package Products ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 65);
            this.label3.TabIndex = 20;
            this.label3.Text = " Package Information Details - ";
            // 
            // txtPkdName
            // 
            this.txtPkdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.txtPkdName.Enabled = false;
            this.txtPkdName.Location = new System.Drawing.Point(208, 89);
            this.txtPkdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPkdName.Name = "txtPkdName";
            this.txtPkdName.Size = new System.Drawing.Size(163, 26);
            this.txtPkdName.TabIndex = 14;
            this.txtPkdName.Tag = "Package Name";
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Enabled = false;
            this.dtpPkgStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPkgStartDate.Location = new System.Drawing.Point(561, 149);
            this.dtpPkgStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(366, 26);
            this.dtpPkgStartDate.TabIndex = 16;
            // 
            // txtPkgID
            // 
            this.txtPkgID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.txtPkgID.Enabled = false;
            this.txtPkgID.Location = new System.Drawing.Point(208, 132);
            this.txtPkgID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPkgID.Name = "txtPkgID";
            this.txtPkgID.Size = new System.Drawing.Size(163, 26);
            this.txtPkgID.TabIndex = 4;
            this.txtPkgID.Tag = "Package ID";
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Enabled = false;
            this.dtpPkgEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPkgEndDate.Location = new System.Drawing.Point(561, 206);
            this.dtpPkgEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(366, 26);
            this.dtpPkgEndDate.TabIndex = 12;
            // 
            // txtPkgCommission
            // 
            this.txtPkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.txtPkgCommission.Enabled = false;
            this.txtPkgCommission.Location = new System.Drawing.Point(208, 172);
            this.txtPkgCommission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPkgCommission.Name = "txtPkgCommission";
            this.txtPkgCommission.Size = new System.Drawing.Size(163, 26);
            this.txtPkgCommission.TabIndex = 6;
            this.txtPkgCommission.Tag = "Package Agency Commission";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.txtPkgDesc.Enabled = false;
            this.txtPkgDesc.Location = new System.Drawing.Point(561, 91);
            this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(366, 26);
            this.txtPkgDesc.TabIndex = 10;
            this.txtPkgDesc.Tag = "Package Description";
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.txtPkgBasePrice.Enabled = false;
            this.txtPkgBasePrice.Location = new System.Drawing.Point(208, 208);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(163, 26);
            this.txtPkgBasePrice.TabIndex = 8;
            this.txtPkgBasePrice.Tag = "Package Base Price";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.listBoxPackageProducts);
            this.tabPage2.Controls.Add(this.btnAddProductToPackage);
            this.tabPage2.Controls.Add(this.lblPackageTable);
            this.tabPage2.Controls.Add(this.btnExit);
            this.tabPage2.Controls.Add(this.btnEditPackage);
            this.tabPage2.Controls.Add(this.btnAddPackage);
            this.tabPage2.Controls.Add(this.packageDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1152, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Packages";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "Products In Selected Package:";
            // 
            // listBoxPackageProducts
            // 
            this.listBoxPackageProducts.Enabled = false;
            this.listBoxPackageProducts.FormattingEnabled = true;
            this.listBoxPackageProducts.ItemHeight = 20;
            this.listBoxPackageProducts.Location = new System.Drawing.Point(372, 443);
            this.listBoxPackageProducts.Name = "listBoxPackageProducts";
            this.listBoxPackageProducts.Size = new System.Drawing.Size(321, 124);
            this.listBoxPackageProducts.TabIndex = 28;
            // 
            // btnAddProductToPackage
            // 
            this.btnAddProductToPackage.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddProductToPackage.Location = new System.Drawing.Point(677, 309);
            this.btnAddProductToPackage.Name = "btnAddProductToPackage";
            this.btnAddProductToPackage.Size = new System.Drawing.Size(122, 54);
            this.btnAddProductToPackage.TabIndex = 27;
            this.btnAddProductToPackage.Text = "&Add Product";
            this.btnAddProductToPackage.UseVisualStyleBackColor = false;
            this.btnAddProductToPackage.Click += new System.EventHandler(this.btnAddProductToPackage_Click);
            // 
            // lblPackageTable
            // 
            this.lblPackageTable.AutoSize = true;
            this.lblPackageTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageTable.Location = new System.Drawing.Point(24, 17);
            this.lblPackageTable.Name = "lblPackageTable";
            this.lblPackageTable.Size = new System.Drawing.Size(178, 22);
            this.lblPackageTable.TabIndex = 7;
            this.lblPackageTable.Text = "Maintain Packages";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SeaShell;
            this.btnExit.Location = new System.Drawing.Point(1023, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 54);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEditPackage.Location = new System.Drawing.Point(357, 309);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(122, 54);
            this.btnEditPackage.TabIndex = 5;
            this.btnEditPackage.Text = "&Edit Package";
            this.btnEditPackage.UseVisualStyleBackColor = false;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddPackage.Location = new System.Drawing.Point(28, 309);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(122, 54);
            this.btnAddPackage.TabIndex = 4;
            this.btnAddPackage.Text = "&Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = false;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // packageDataGridView
            // 
            this.packageDataGridView.AllowUserToDeleteRows = false;
            this.packageDataGridView.AutoGenerateColumns = false;
            this.packageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.packageDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.packageDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.packageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.packageDataGridView.DataSource = this.packageBindingSource;
            this.packageDataGridView.Location = new System.Drawing.Point(28, 60);
            this.packageDataGridView.Name = "packageDataGridView";
            this.packageDataGridView.RowHeadersWidth = 62;
            this.packageDataGridView.RowTemplate.Height = 28;
            this.packageDataGridView.Size = new System.Drawing.Size(1118, 220);
            this.packageDataGridView.TabIndex = 0;
            this.packageDataGridView.SelectionChanged += new System.EventHandler(this.packageDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PackageId";
            this.dataGridViewTextBoxColumn1.FillWeight = 50.37879F;
            this.dataGridViewTextBoxColumn1.HeaderText = "PackageId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 121;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn2.FillWeight = 50.37879F;
            this.dataGridViewTextBoxColumn2.HeaderText = "PkgName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 114;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            this.dataGridViewTextBoxColumn3.FillWeight = 397.7273F;
            this.dataGridViewTextBoxColumn3.HeaderText = "PkgStartDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 142;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            this.dataGridViewTextBoxColumn4.FillWeight = 50.37879F;
            this.dataGridViewTextBoxColumn4.HeaderText = "PkgEndDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 136;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn5.FillWeight = 50.37879F;
            this.dataGridViewTextBoxColumn5.HeaderText = "PkgDesc";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 109;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.FillWeight = 50.37879F;
            this.dataGridViewTextBoxColumn6.HeaderText = "PkgBasePrice";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 144;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn7.FillWeight = 50.37879F;
            this.dataGridViewTextBoxColumn7.HeaderText = "PkgAgencyCommission";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 211;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnExitProductSupplier);
            this.tabPage3.Controls.Add(this.btnEditSupplier);
            this.tabPage3.Controls.Add(this.btnAddSupplier);
            this.tabPage3.Controls.Add(this.btnEditProduct);
            this.tabPage3.Controls.Add(this.btnAddProduct);
            this.tabPage3.Controls.Add(this.supplierDataGridView);
            this.tabPage3.Controls.Add(this.productDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1152, 658);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Suppliers/Products";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Maintain Products and Suppliers";
            // 
            // btnExitProductSupplier
            // 
            this.btnExitProductSupplier.BackColor = System.Drawing.Color.SeaShell;
            this.btnExitProductSupplier.Location = new System.Drawing.Point(464, 415);
            this.btnExitProductSupplier.Name = "btnExitProductSupplier";
            this.btnExitProductSupplier.Size = new System.Drawing.Size(108, 53);
            this.btnExitProductSupplier.TabIndex = 9;
            this.btnExitProductSupplier.Text = "&Close";
            this.btnExitProductSupplier.UseVisualStyleBackColor = false;
            this.btnExitProductSupplier.Click += new System.EventHandler(this.btnExitProductSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEditSupplier.Location = new System.Drawing.Point(836, 320);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(114, 49);
            this.btnEditSupplier.TabIndex = 8;
            this.btnEditSupplier.Text = "&Edit Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddSupplier.Location = new System.Drawing.Point(560, 320);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(122, 49);
            this.btnAddSupplier.TabIndex = 7;
            this.btnAddSupplier.Text = "&Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEditProduct.Location = new System.Drawing.Point(340, 320);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(114, 49);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "&Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddProduct.Location = new System.Drawing.Point(70, 320);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(122, 49);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "&Add Products";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            this.supplierDataGridView.Location = new System.Drawing.Point(560, 83);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.RowHeadersWidth = 62;
            this.supplierDataGridView.RowTemplate.Height = 28;
            this.supplierDataGridView.Size = new System.Drawing.Size(390, 220);
            this.supplierDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn14.FillWeight = 79.54546F;
            this.dataGridViewTextBoxColumn14.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn15.FillWeight = 120.4545F;
            this.dataGridViewTextBoxColumn15.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(WorkShop2.Supplier);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(70, 83);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            this.productDataGridView.RowTemplate.Height = 28;
            this.productDataGridView.Size = new System.Drawing.Size(384, 220);
            this.productDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn12.FillWeight = 90.90909F;
            this.dataGridViewTextBoxColumn12.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn13.FillWeight = 109.0909F;
            this.dataGridViewTextBoxColumn13.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WorkShop2.Product);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage4.Controls.Add(this.products_SupplierDataGridView);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.btnCloseProductSupplier);
            this.tabPage4.Controls.Add(this.btnEditProductSupplier);
            this.tabPage4.Controls.Add(this.btnAddProductSupplier);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1152, 658);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Product/Supplier";
            // 
            // products_SupplierDataGridView
            // 
            this.products_SupplierDataGridView.AutoGenerateColumns = false;
            this.products_SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_SupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.products_SupplierDataGridView.DataSource = this.products_SuppliersBindingSource;
            this.products_SupplierDataGridView.Location = new System.Drawing.Point(80, 61);
            this.products_SupplierDataGridView.Name = "products_SupplierDataGridView";
            this.products_SupplierDataGridView.RowHeadersWidth = 62;
            this.products_SupplierDataGridView.RowTemplate.Height = 28;
            this.products_SupplierDataGridView.Size = new System.Drawing.Size(771, 220);
            this.products_SupplierDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductSupplierId";
            this.dataGridViewTextBoxColumn8.HeaderText = "ProductSupplierId";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn9.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn10.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // products_SuppliersBindingSource
            // 
            this.products_SuppliersBindingSource.DataMember = "Products_Suppliers";
            this.products_SuppliersBindingSource.DataSource = this.supplierBindingSource;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(76, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Maintain Product Suppliers";
            // 
            // btnCloseProductSupplier
            // 
            this.btnCloseProductSupplier.BackColor = System.Drawing.Color.SeaShell;
            this.btnCloseProductSupplier.Location = new System.Drawing.Point(408, 377);
            this.btnCloseProductSupplier.Name = "btnCloseProductSupplier";
            this.btnCloseProductSupplier.Size = new System.Drawing.Size(122, 60);
            this.btnCloseProductSupplier.TabIndex = 6;
            this.btnCloseProductSupplier.Text = "&Close";
            this.btnCloseProductSupplier.UseVisualStyleBackColor = false;
            this.btnCloseProductSupplier.Click += new System.EventHandler(this.btnCloseProductSupplier_Click);
            // 
            // btnEditProductSupplier
            // 
            this.btnEditProductSupplier.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEditProductSupplier.Location = new System.Drawing.Point(729, 316);
            this.btnEditProductSupplier.Name = "btnEditProductSupplier";
            this.btnEditProductSupplier.Size = new System.Drawing.Size(122, 60);
            this.btnEditProductSupplier.TabIndex = 5;
            this.btnEditProductSupplier.Text = "&Edit Products Suppliers";
            this.btnEditProductSupplier.UseVisualStyleBackColor = false;
            this.btnEditProductSupplier.Click += new System.EventHandler(this.btnEditProductSupplier_Click);
            // 
            // btnAddProductSupplier
            // 
            this.btnAddProductSupplier.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAddProductSupplier.Location = new System.Drawing.Point(80, 316);
            this.btnAddProductSupplier.Name = "btnAddProductSupplier";
            this.btnAddProductSupplier.Size = new System.Drawing.Size(122, 60);
            this.btnAddProductSupplier.TabIndex = 4;
            this.btnAddProductSupplier.Text = "&Add Products Suppliers";
            this.btnAddProductSupplier.UseVisualStyleBackColor = false;
            this.btnAddProductSupplier.Click += new System.EventHandler(this.btnAddProductSupplier_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tltipAddPackage
            // 
            this.tltipAddPackage.IsBalloon = true;
            this.tltipAddPackage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tltipEditPackages
            // 
            this.tltipEditPackages.IsBalloon = true;
            this.tltipEditPackages.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tltipExitPackages
            // 
            this.tltipExitPackages.IsBalloon = true;
            this.tltipExitPackages.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // package_ProductsBindingSource
            // 
            this.package_ProductsBindingSource.DataMember = "Package_Products";
            this.package_ProductsBindingSource.DataSource = this.packageBindingSource;
            // 
            // products_SupplierBindingSource
            // 
            this.products_SupplierBindingSource.DataSource = typeof(WorkShop2.Products_Supplier);
            // 
            // packages_Products_SupplierBindingSource
            // 
            this.packages_Products_SupplierBindingSource.DataSource = typeof(WorkShop2.Packages_Products_Supplier);
            // 
            // package_ProductBindingSource
            // 
            this.package_ProductBindingSource.DataSource = typeof(WorkShop2.Package_Product);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1578, 906);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTableList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHome";
            this.Text = "Desktop Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlAvailablePackages.ResumeLayout(false);
            this.pnlAvailablePackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.package_ProductDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.package_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packages_Products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.package_ProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTableList;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox txtPkgID;
        private System.Windows.Forms.TextBox txtPkgCommission;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.TextBox txtPkdName;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.ListBox pkgNameListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView package_ProductDataGridView;
        private System.Windows.Forms.BindingSource package_ProductBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.Panel pnlAvailablePackages;
        private System.Windows.Forms.BindingSource packages_Products_SupplierBindingSource;
        private System.Windows.Forms.DataGridView packageDataGridView;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource products_SupplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolTip tltipAddPackage;
        private System.Windows.Forms.ToolTip tltipEditPackages;
        private System.Windows.Forms.ToolTip tltipExitPackages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnExitProductSupplier;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Label lblPackageTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource package_ProductsBindingSource;
        private System.Windows.Forms.Button btnCloseProductSupplier;
        private System.Windows.Forms.Button btnEditProductSupplier;
        private System.Windows.Forms.Button btnAddProductSupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddProductToPackage;
        private System.Windows.Forms.ListBox listBoxPackageProducts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView products_SupplierDataGridView;
        private System.Windows.Forms.BindingSource products_SuppliersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}

