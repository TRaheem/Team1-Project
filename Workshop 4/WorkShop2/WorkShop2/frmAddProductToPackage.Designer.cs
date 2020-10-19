namespace WorkShop2
{
    partial class frmAddProductToPackage
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
            System.Windows.Forms.Label lblPackageID;
            System.Windows.Forms.Label lblProductSupplierID;
            System.Windows.Forms.Label lblProductName;
            System.Windows.Forms.Label lblSupName;
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtProductSupplierId = new System.Windows.Forms.TextBox();
            this.prodNameListBox = new System.Windows.Forms.ListBox();
            this.supNameListBox = new System.Windows.Forms.ListBox();
            this.btnSaveProductToPackage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlProdSupIdForAddProduct = new System.Windows.Forms.Panel();
            lblPackageID = new System.Windows.Forms.Label();
            lblProductSupplierID = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            lblSupName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).BeginInit();
            this.pnlProdSupIdForAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPackageID
            // 
            lblPackageID.AutoSize = true;
            lblPackageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPackageID.Location = new System.Drawing.Point(84, 88);
            lblPackageID.Name = "lblPackageID";
            lblPackageID.Size = new System.Drawing.Size(115, 22);
            lblPackageID.TabIndex = 1;
            lblPackageID.Text = "Package Id:";
            // 
            // lblProductSupplierID
            // 
            lblProductSupplierID.AutoSize = true;
            lblProductSupplierID.Location = new System.Drawing.Point(19, 34);
            lblProductSupplierID.Name = "lblProductSupplierID";
            lblProductSupplierID.Size = new System.Drawing.Size(148, 20);
            lblProductSupplierID.TabIndex = 2;
            lblProductSupplierID.Text = "Product Supplier Id:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProductName.Location = new System.Drawing.Point(84, 196);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(89, 22);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Products";
            // 
            // lblSupName
            // 
            lblSupName.AutoSize = true;
            lblSupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSupName.Location = new System.Drawing.Point(468, 196);
            lblSupName.Name = "lblSupName";
            lblSupName.Size = new System.Drawing.Size(94, 22);
            lblSupName.TabIndex = 6;
            lblSupName.Text = "Suppliers";
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(WorkShop2.Package);
            // 
            // txtPackageID
            // 
            this.txtPackageID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.txtPackageID.Enabled = false;
            this.txtPackageID.Location = new System.Drawing.Point(294, 84);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(100, 26);
            this.txtPackageID.TabIndex = 2;
            // 
            // products_SupplierBindingSource
            // 
            this.products_SupplierBindingSource.DataSource = typeof(WorkShop2.Products_Supplier);
            // 
            // txtProductSupplierId
            // 
            this.txtProductSupplierId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SupplierBindingSource, "ProductSupplierId", true));
            this.txtProductSupplierId.Location = new System.Drawing.Point(213, 31);
            this.txtProductSupplierId.Name = "txtProductSupplierId";
            this.txtProductSupplierId.Size = new System.Drawing.Size(100, 26);
            this.txtProductSupplierId.TabIndex = 3;
            // 
            // prodNameListBox
            // 
            this.prodNameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SupplierBindingSource, "Product.ProdName", true));
            this.prodNameListBox.FormattingEnabled = true;
            this.prodNameListBox.ItemHeight = 20;
            this.prodNameListBox.Location = new System.Drawing.Point(225, 196);
            this.prodNameListBox.Name = "prodNameListBox";
            this.prodNameListBox.Size = new System.Drawing.Size(187, 104);
            this.prodNameListBox.TabIndex = 5;
            this.prodNameListBox.SelectedIndexChanged += new System.EventHandler(this.prodNameListBox_SelectedIndexChanged);
            // 
            // supNameListBox
            // 
            this.supNameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.products_SupplierBindingSource, "Supplier.SupName", true));
            this.supNameListBox.FormattingEnabled = true;
            this.supNameListBox.ItemHeight = 20;
            this.supNameListBox.Location = new System.Drawing.Point(596, 196);
            this.supNameListBox.Name = "supNameListBox";
            this.supNameListBox.Size = new System.Drawing.Size(222, 184);
            this.supNameListBox.TabIndex = 7;
            this.supNameListBox.SelectedIndexChanged += new System.EventHandler(this.supNameListBox_SelectedIndexChanged);
            // 
            // btnSaveProductToPackage
            // 
            this.btnSaveProductToPackage.BackColor = System.Drawing.Color.SeaShell;
            this.btnSaveProductToPackage.Location = new System.Drawing.Point(88, 353);
            this.btnSaveProductToPackage.Name = "btnSaveProductToPackage";
            this.btnSaveProductToPackage.Size = new System.Drawing.Size(122, 54);
            this.btnSaveProductToPackage.TabIndex = 8;
            this.btnSaveProductToPackage.Text = "&Save";
            this.btnSaveProductToPackage.UseVisualStyleBackColor = false;
            this.btnSaveProductToPackage.Click += new System.EventHandler(this.btnSaveProductToPackage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancel.Location = new System.Drawing.Point(369, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 54);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlProdSupIdForAddProduct
            // 
            this.pnlProdSupIdForAddProduct.Controls.Add(lblProductSupplierID);
            this.pnlProdSupIdForAddProduct.Controls.Add(this.txtProductSupplierId);
            this.pnlProdSupIdForAddProduct.Location = new System.Drawing.Point(449, 60);
            this.pnlProdSupIdForAddProduct.Name = "pnlProdSupIdForAddProduct";
            this.pnlProdSupIdForAddProduct.Size = new System.Drawing.Size(380, 100);
            this.pnlProdSupIdForAddProduct.TabIndex = 10;
            // 
            // frmAddProductToPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.pnlProdSupIdForAddProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveProductToPackage);
            this.Controls.Add(lblSupName);
            this.Controls.Add(this.supNameListBox);
            this.Controls.Add(lblProductName);
            this.Controls.Add(this.prodNameListBox);
            this.Controls.Add(lblPackageID);
            this.Controls.Add(this.txtPackageID);
            this.Name = "frmAddProductToPackage";
            this.Text = "frmAddProductToPackage";
            this.Load += new System.EventHandler(this.frmAddProductToPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).EndInit();
            this.pnlProdSupIdForAddProduct.ResumeLayout(false);
            this.pnlProdSupIdForAddProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.BindingSource products_SupplierBindingSource;
        private System.Windows.Forms.TextBox txtProductSupplierId;
        private System.Windows.Forms.ListBox prodNameListBox;
        private System.Windows.Forms.ListBox supNameListBox;
        private System.Windows.Forms.Button btnSaveProductToPackage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlProdSupIdForAddProduct;
    }
}