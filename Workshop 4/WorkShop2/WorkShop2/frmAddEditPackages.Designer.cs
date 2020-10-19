namespace WorkShop2
{
    partial class frmAddEditPackages
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
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgNameLabel1;
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.btnSavePackages = new System.Windows.Forms.Button();
            this.btnCancelPackages = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlPackageId = new System.Windows.Forms.Panel();
            this.tlTpSavePackage = new System.Windows.Forms.ToolTip(this.components);
            this.tlTpCancelPackages = new System.Windows.Forms.ToolTip(this.components);
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.pnlPackageId.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            packageIdLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            packageIdLabel.Location = new System.Drawing.Point(3, 45);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(127, 25);
            packageIdLabel.TabIndex = 1;
            packageIdLabel.Text = "Package Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(43, 218);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(306, 25);
            pkgAgencyCommissionLabel.TabIndex = 3;
            pkgAgencyCommissionLabel.Text = "Package Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            pkgBasePriceLabel.Location = new System.Drawing.Point(42, 272);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(213, 25);
            pkgBasePriceLabel.TabIndex = 5;
            pkgBasePriceLabel.Text = "Package Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            pkgDescLabel.Location = new System.Drawing.Point(43, 164);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(217, 25);
            pkgDescLabel.TabIndex = 7;
            pkgDescLabel.Text = "Package Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            pkgEndDateLabel.Location = new System.Drawing.Point(42, 372);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(198, 25);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "Package End Date:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            pkgStartDateLabel.Location = new System.Drawing.Point(43, 324);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(206, 25);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Package Start Date:";
            // 
            // pkgNameLabel1
            // 
            pkgNameLabel1.AutoSize = true;
            pkgNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            pkgNameLabel1.Location = new System.Drawing.Point(42, 118);
            pkgNameLabel1.Name = "pkgNameLabel1";
            pkgNameLabel1.Size = new System.Drawing.Size(165, 25);
            pkgNameLabel1.TabIndex = 14;
            pkgNameLabel1.Text = "Package Name:";
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.packageIdTextBox.Location = new System.Drawing.Point(423, 58);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.Size = new System.Drawing.Size(344, 26);
            this.packageIdTextBox.TabIndex = 2;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(WorkShop2.Package);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(425, 217);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(344, 26);
            this.pkgAgencyCommissionTextBox.TabIndex = 4;
            this.pkgAgencyCommissionTextBox.Tag = "Agency Commission";
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(423, 273);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(344, 26);
            this.pkgBasePriceTextBox.TabIndex = 6;
            this.pkgBasePriceTextBox.Tag = "Base Price";
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(425, 165);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(344, 26);
            this.pkgDescTextBox.TabIndex = 8;
            this.pkgDescTextBox.Tag = "Description";
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(425, 372);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(344, 26);
            this.pkgEndDateDateTimePicker.TabIndex = 10;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(425, 323);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(344, 26);
            this.pkgStartDateDateTimePicker.TabIndex = 14;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(423, 114);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(344, 26);
            this.pkgNameTextBox.TabIndex = 0;
            this.pkgNameTextBox.Tag = "Package Name";
            // 
            // btnSavePackages
            // 
            this.btnSavePackages.BackColor = System.Drawing.Color.SeaShell;
            this.btnSavePackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePackages.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSavePackages.Location = new System.Drawing.Point(48, 459);
            this.btnSavePackages.Name = "btnSavePackages";
            this.btnSavePackages.Size = new System.Drawing.Size(146, 63);
            this.btnSavePackages.TabIndex = 16;
            this.btnSavePackages.Text = "&Save";
            this.btnSavePackages.UseVisualStyleBackColor = false;
            this.btnSavePackages.Click += new System.EventHandler(this.btnSavePackages_Click);
            // 
            // btnCancelPackages
            // 
            this.btnCancelPackages.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancelPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPackages.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelPackages.Location = new System.Drawing.Point(628, 459);
            this.btnCancelPackages.Name = "btnCancelPackages";
            this.btnCancelPackages.Size = new System.Drawing.Size(141, 63);
            this.btnCancelPackages.TabIndex = 17;
            this.btnCancelPackages.Text = "&Cancel";
            this.btnCancelPackages.UseVisualStyleBackColor = false;
            this.btnCancelPackages.Click += new System.EventHandler(this.btnCancelPackages_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WorkShop2.Product);
            // 
            // pnlPackageId
            // 
            this.pnlPackageId.Controls.Add(packageIdLabel);
            this.pnlPackageId.Location = new System.Drawing.Point(39, 25);
            this.pnlPackageId.Name = "pnlPackageId";
            this.pnlPackageId.Size = new System.Drawing.Size(779, 83);
            this.pnlPackageId.TabIndex = 19;
            // 
            // tlTpSavePackage
            // 
            this.tlTpSavePackage.AutomaticDelay = 200;
            this.tlTpSavePackage.IsBalloon = true;
            this.tlTpSavePackage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tlTpCancelPackages
            // 
            this.tlTpCancelPackages.AutomaticDelay = 200;
            this.tlTpCancelPackages.IsBalloon = true;
            this.tlTpCancelPackages.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmAddEditPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1058, 594);
            this.Controls.Add(this.packageIdTextBox);
            this.Controls.Add(this.pnlPackageId);
            this.Controls.Add(this.btnCancelPackages);
            this.Controls.Add(this.btnSavePackages);
            this.Controls.Add(pkgNameLabel1);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "frmAddEditPackages";
            this.Text = "ADD/EDIT PACKAGES";
            this.Load += new System.EventHandler(this.frmAddEditPackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.pnlPackageId.ResumeLayout(false);
            this.pnlPackageId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.Button btnSavePackages;
        private System.Windows.Forms.Button btnCancelPackages;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Panel pnlPackageId;
        private System.Windows.Forms.ToolTip tlTpSavePackage;
        private System.Windows.Forms.ToolTip tlTpCancelPackages;
    }
}