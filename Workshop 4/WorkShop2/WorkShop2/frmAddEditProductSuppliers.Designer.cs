namespace WorkShop2
{
    partial class frmAddEditProductSuppliers
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
            System.Windows.Forms.Label lblProdSupID;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label productIdLabel;
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.supprodNameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodsupplierNameComboBox = new System.Windows.Forms.ComboBox();
            this.btnSaveProductSupplier = new System.Windows.Forms.Button();
            this.btnCancelSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlTpSaveProductSuppliers = new System.Windows.Forms.ToolTip(this.components);
            this.tlTpCancelProductSuppliers = new System.Windows.Forms.ToolTip(this.components);
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            lblProdSupID = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProdSupID
            // 
            lblProdSupID.AutoSize = true;
            lblProdSupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProdSupID.ForeColor = System.Drawing.SystemColors.ControlText;
            lblProdSupID.Location = new System.Drawing.Point(17, 36);
            lblProdSupID.Name = "lblProdSupID";
            lblProdSupID.Size = new System.Drawing.Size(175, 22);
            lblProdSupID.TabIndex = 6;
            lblProdSupID.Text = "ProductSupplierId:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel.Location = new System.Drawing.Point(209, 211);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(108, 22);
            supNameLabel.TabIndex = 8;
            supNameLabel.Text = "Sup Name:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(209, 144);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(115, 22);
            prodNameLabel.TabIndex = 9;
            prodNameLabel.Text = "Prod Name:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(3, 57);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(89, 20);
            supplierIdLabel.TabIndex = 13;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(3, 15);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(86, 20);
            productIdLabel.TabIndex = 14;
            productIdLabel.Text = "Product Id:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 26);
            this.textBox2.TabIndex = 7;
            // 
            // supprodNameComboBox
            // 
            this.supprodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupName", true));
            this.supprodNameComboBox.FormattingEnabled = true;
            this.supprodNameComboBox.Location = new System.Drawing.Point(396, 211);
            this.supprodNameComboBox.Name = "supprodNameComboBox";
            this.supprodNameComboBox.Size = new System.Drawing.Size(223, 28);
            this.supprodNameComboBox.TabIndex = 9;
            this.supprodNameComboBox.SelectedIndexChanged += new System.EventHandler(this.supprodNameComboBox_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(WorkShop2.Supplier);
            // 
            // products_SuppliersBindingSource
            // 
            this.products_SuppliersBindingSource.DataMember = "Products_Suppliers";
            this.products_SuppliersBindingSource.DataSource = this.supplierBindingSource;
            // 
            // prodsupplierNameComboBox
            // 
            this.prodsupplierNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.products_SuppliersBindingSource, "Product.ProdName", true));
            this.prodsupplierNameComboBox.FormattingEnabled = true;
            this.prodsupplierNameComboBox.Location = new System.Drawing.Point(396, 144);
            this.prodsupplierNameComboBox.Name = "prodsupplierNameComboBox";
            this.prodsupplierNameComboBox.Size = new System.Drawing.Size(223, 28);
            this.prodsupplierNameComboBox.TabIndex = 0;
            this.prodsupplierNameComboBox.SelectedIndexChanged += new System.EventHandler(this.prodsupplierNameComboBox_SelectedIndexChanged);
            // 
            // btnSaveProductSupplier
            // 
            this.btnSaveProductSupplier.BackColor = System.Drawing.Color.SeaShell;
            this.btnSaveProductSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProductSupplier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSaveProductSupplier.Location = new System.Drawing.Point(197, 294);
            this.btnSaveProductSupplier.Name = "btnSaveProductSupplier";
            this.btnSaveProductSupplier.Size = new System.Drawing.Size(150, 63);
            this.btnSaveProductSupplier.TabIndex = 11;
            this.btnSaveProductSupplier.Text = "&Save";
            this.btnSaveProductSupplier.UseVisualStyleBackColor = false;
            this.btnSaveProductSupplier.Click += new System.EventHandler(this.btnSaveProductSupplier_Click);
            // 
            // btnCancelSupplier
            // 
            this.btnCancelSupplier.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSupplier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelSupplier.Location = new System.Drawing.Point(530, 294);
            this.btnCancelSupplier.Name = "btnCancelSupplier";
            this.btnCancelSupplier.Size = new System.Drawing.Size(140, 63);
            this.btnCancelSupplier.TabIndex = 12;
            this.btnCancelSupplier.Text = "&Cancel";
            this.btnCancelSupplier.UseVisualStyleBackColor = false;
            this.btnCancelSupplier.Click += new System.EventHandler(this.btnCancelSupplier_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(lblProdSupID);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(166, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 72);
            this.panel1.TabIndex = 13;
            // 
            // tlTpSaveProductSuppliers
            // 
            this.tlTpSaveProductSuppliers.AutomaticDelay = 200;
            this.tlTpSaveProductSuppliers.IsBalloon = true;
            this.tlTpSaveProductSuppliers.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tlTpCancelProductSuppliers
            // 
            this.tlTpCancelProductSuppliers.AutomaticDelay = 200;
            this.tlTpCancelProductSuppliers.IsBalloon = true;
            this.tlTpCancelProductSuppliers.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierId", true));
            this.supplierIdTextBox.Location = new System.Drawing.Point(95, 51);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.supplierIdTextBox.TabIndex = 14;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductId", true));
            this.productIdTextBox.Location = new System.Drawing.Point(95, 9);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.productIdTextBox.TabIndex = 15;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WorkShop2.Product);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(productIdLabel);
            this.panel2.Controls.Add(this.supplierIdTextBox);
            this.panel2.Controls.Add(supplierIdLabel);
            this.panel2.Controls.Add(this.productIdTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 16;
            // 
            // frmAddEditProductSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelSupplier);
            this.Controls.Add(this.btnSaveProductSupplier);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodsupplierNameComboBox);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supprodNameComboBox);
            this.Name = "frmAddEditProductSuppliers";
            this.Text = "ADD/EDIT PRODUCT SUPPLIERS";
            this.Load += new System.EventHandler(this.frmAddEditProductSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ComboBox supprodNameComboBox;
        private System.Windows.Forms.BindingSource products_SuppliersBindingSource;
        private System.Windows.Forms.ComboBox prodsupplierNameComboBox;
        private System.Windows.Forms.Button btnSaveProductSupplier;
        private System.Windows.Forms.Button btnCancelSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip tlTpSaveProductSuppliers;
        private System.Windows.Forms.ToolTip tlTpCancelProductSuppliers;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Panel panel2;
    }
}