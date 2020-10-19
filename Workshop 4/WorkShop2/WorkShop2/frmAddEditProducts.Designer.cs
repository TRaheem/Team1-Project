namespace WorkShop2
{
    partial class frmAddEditProducts
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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label lblProductId;
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.tltpSaveProduct = new System.Windows.Forms.ToolTip(this.components);
            this.tltpCancelProduct = new System.Windows.Forms.ToolTip(this.components);
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.pnlProductId = new System.Windows.Forms.Panel();
            prodNameLabel = new System.Windows.Forms.Label();
            lblProductId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.pnlProductId.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(158, 172);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(155, 25);
            prodNameLabel.TabIndex = 1;
            prodNameLabel.Text = "Product Name:";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProductId.Location = new System.Drawing.Point(14, 35);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new System.Drawing.Size(117, 25);
            lblProductId.TabIndex = 3;
            lblProductId.Text = "Product Id:";
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.prodNameTextBox.Location = new System.Drawing.Point(380, 172);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.prodNameTextBox.TabIndex = 2;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WorkShop2.Product);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.SeaShell;
            this.btnSaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.Location = new System.Drawing.Point(150, 280);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(152, 63);
            this.btnSaveProduct.TabIndex = 5;
            this.btnSaveProduct.Text = "&Save";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProduct.Location = new System.Drawing.Point(430, 280);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(152, 63);
            this.btnCancelProduct.TabIndex = 6;
            this.btnCancelProduct.Text = "&Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = false;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // tltpSaveProduct
            // 
            this.tltpSaveProduct.AutomaticDelay = 200;
            this.tltpSaveProduct.IsBalloon = true;
            this.tltpSaveProduct.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tltpCancelProduct
            // 
            this.tltpCancelProduct.AutomaticDelay = 200;
            this.tltpCancelProduct.IsBalloon = true;
            this.tltpCancelProduct.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductId", true));
            this.productIdTextBox.Location = new System.Drawing.Point(230, 35);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.productIdTextBox.TabIndex = 4;
            // 
            // pnlProductId
            // 
            this.pnlProductId.Controls.Add(this.productIdTextBox);
            this.pnlProductId.Controls.Add(lblProductId);
            this.pnlProductId.Location = new System.Drawing.Point(150, 32);
            this.pnlProductId.Name = "pnlProductId";
            this.pnlProductId.Size = new System.Drawing.Size(454, 85);
            this.pnlProductId.TabIndex = 7;
            // 
            // frmAddEditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.pnlProductId);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameTextBox);
            this.Name = "frmAddEditProducts";
            this.Text = "ADD/EDIT PRODUCTS";
            this.Load += new System.EventHandler(this.frmAddEditProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.pnlProductId.ResumeLayout(false);
            this.pnlProductId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.ToolTip tltpSaveProduct;
        private System.Windows.Forms.ToolTip tltpCancelProduct;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Panel pnlProductId;
    }
}