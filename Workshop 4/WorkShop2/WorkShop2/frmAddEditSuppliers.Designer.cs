namespace WorkShop2
{
    partial class frmAddEditSuppliers
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
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label supplierIdLabel;
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.pnlSuppliersid = new System.Windows.Forms.Panel();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.btnCancelSupplier = new System.Windows.Forms.Button();
            this.tltpSaveSupplier = new System.Windows.Forms.ToolTip(this.components);
            this.tltpCancelSupplier = new System.Windows.Forms.ToolTip(this.components);
            supNameLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.pnlSuppliersid.SuspendLayout();
            this.SuspendLayout();
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            supNameLabel.Location = new System.Drawing.Point(160, 191);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(161, 25);
            supNameLabel.TabIndex = 1;
            supNameLabel.Text = "Supplier Name:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIdLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            supplierIdLabel.Location = new System.Drawing.Point(3, 34);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(123, 25);
            supplierIdLabel.TabIndex = 3;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupName", true));
            this.supNameTextBox.Location = new System.Drawing.Point(390, 185);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.Size = new System.Drawing.Size(223, 26);
            this.supNameTextBox.TabIndex = 2;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(WorkShop2.Supplier);
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierId", true));
            this.supplierIdTextBox.Location = new System.Drawing.Point(232, 32);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.Size = new System.Drawing.Size(223, 26);
            this.supplierIdTextBox.TabIndex = 0;
            // 
            // pnlSuppliersid
            // 
            this.pnlSuppliersid.Controls.Add(this.supplierIdTextBox);
            this.pnlSuppliersid.Controls.Add(supplierIdLabel);
            this.pnlSuppliersid.Location = new System.Drawing.Point(158, 52);
            this.pnlSuppliersid.Name = "pnlSuppliersid";
            this.pnlSuppliersid.Size = new System.Drawing.Size(471, 88);
            this.pnlSuppliersid.TabIndex = 5;
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.BackColor = System.Drawing.Color.SeaShell;
            this.btnSaveSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSupplier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSaveSupplier.Location = new System.Drawing.Point(158, 286);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(150, 63);
            this.btnSaveSupplier.TabIndex = 6;
            this.btnSaveSupplier.Text = "&Save";
            this.btnSaveSupplier.UseVisualStyleBackColor = false;
            this.btnSaveSupplier.Click += new System.EventHandler(this.btnSaveSupplier_Click);
            // 
            // btnCancelSupplier
            // 
            this.btnCancelSupplier.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSupplier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelSupplier.Location = new System.Drawing.Point(476, 286);
            this.btnCancelSupplier.Name = "btnCancelSupplier";
            this.btnCancelSupplier.Size = new System.Drawing.Size(140, 63);
            this.btnCancelSupplier.TabIndex = 7;
            this.btnCancelSupplier.Text = "&Cancel";
            this.btnCancelSupplier.UseVisualStyleBackColor = false;
            this.btnCancelSupplier.Click += new System.EventHandler(this.btnCancelSupplier_Click);
            // 
            // tltpSaveSupplier
            // 
            this.tltpSaveSupplier.AutomaticDelay = 200;
            this.tltpSaveSupplier.IsBalloon = true;
            this.tltpSaveSupplier.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tltpCancelSupplier
            // 
            this.tltpCancelSupplier.AutomaticDelay = 200;
            this.tltpCancelSupplier.IsBalloon = true;
            this.tltpCancelSupplier.Tag = "Info";
            this.tltpCancelSupplier.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmAddEditSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnCancelSupplier);
            this.Controls.Add(this.btnSaveSupplier);
            this.Controls.Add(this.pnlSuppliersid);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameTextBox);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "frmAddEditSuppliers";
            this.Text = "ADD/EDIT SUPPLIER";
            this.Load += new System.EventHandler(this.frmAddEditSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.pnlSuppliersid.ResumeLayout(false);
            this.pnlSuppliersid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.Panel pnlSuppliersid;
        private System.Windows.Forms.Button btnSaveSupplier;
        private System.Windows.Forms.Button btnCancelSupplier;
        private System.Windows.Forms.ToolTip tltpSaveSupplier;
        private System.Windows.Forms.ToolTip tltpCancelSupplier;
    }
}