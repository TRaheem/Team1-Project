using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop4;

namespace WorkShop2
{
    // Create Add/Edit Package Form
    public partial class frmAddEditPackages : Form
    {
        public bool addPackage;              // it is set in the main form
        public Package currentPackage;       // current package set up

        public TravelExpertDBDataContext db = new TravelExpertDBDataContext();

        public frmAddEditPackages()
        {
            InitializeComponent();
        }

        // Add data to Add/Edit Package Form
        private void frmAddEditPackages_Load(object sender, EventArgs e)
        {
            tlTpCancelPackages.SetToolTip(btnCancelPackages, "Leave page and return to application");

            if (addPackage)
            {
                pnlPackageId.Visible = false;
                packageIdTextBox.Visible = false;
                
                pkgNameTextBox.Text = "";
                pkgAgencyCommissionTextBox.Text = "";
                pkgBasePriceTextBox.Text = "";
                pkgDescTextBox.Text = "";
                pkgStartDateDateTimePicker.Text = "";
                pkgEndDateDateTimePicker.Text = "";
                tlTpSavePackage.SetToolTip(btnSavePackages, "Saves New Package");
            }
            else
            {
                packageIdTextBox.Text = currentPackage.PackageId.ToString();
                pkgNameTextBox.Text = currentPackage.PkgName;
                pkgAgencyCommissionTextBox.Text = currentPackage.PkgAgencyCommission.ToString();
                pkgBasePriceTextBox.Text = currentPackage.PkgBasePrice.ToString();
                pkgDescTextBox.Text = currentPackage.PkgDesc;
                pkgStartDateDateTimePicker.Text = currentPackage.PkgStartDate.ToString();
                pkgEndDateDateTimePicker.Text = currentPackage.PkgEndDate.ToString();
                packageIdTextBox.Enabled = false;
                pnlPackageId.Visible = true;
                tlTpSavePackage.SetToolTip(btnSavePackages, "Saves Changes Made");
            }
        }

        // Save and validate data in Add/Edit Package Form
        private void btnSavePackages_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
                    {
                        Package pkg = new Package();

                        if (addPackage)
                        {
                            db.Packages.InsertOnSubmit(pkg);
                            pkg.PkgName = pkgNameTextBox.Text;
                            pkg.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);
                            pkg.PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text);
                            pkg.PkgDesc = pkgDescTextBox.Text;
                            pkg.PkgStartDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Text);
                            pkg.PkgEndDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Text);
                        }
                        else
                        {
                            // lambda expression is applied
                            pkg = db.Packages.Single(pk => pk.PackageId ==
                                     Convert.ToInt32(packageIdTextBox.Text));
                            pkg.PkgName = pkgNameTextBox.Text;
                            pkg.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);
                            pkg.PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text);
                            pkg.PkgDesc = pkgDescTextBox.Text;
                            pkg.PkgStartDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Value);
                            pkg.PkgEndDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Value);
                        }

                        // Validate agency commision
                        if (pkg.PkgAgencyCommission != null)
                        {
                            //Make sure that agency commission is less than base price
                            if (pkg.PkgAgencyCommission > pkg.PkgBasePrice)
                            {
                                // Changes are not submitted if data is obsolete
                                MessageBox.Show("Agency Commission must be less than Base Price", "Date Error");
                                return;
                            }
                        }

                        // Validate start and end date
                        if (pkg.PkgEndDate != null)
                        {
                            //validate that End date is after Start date
                            if (pkg.PkgEndDate <= pkg.PkgStartDate)
                            {
                                // do not submit changes if data is obsolete
                                MessageBox.Show("Package End Date must be later than Package Start Date", "Date Error");
                                return; 
                            }
                        }
                                             
                        db.SubmitChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
                //Catch concurrency exception
                catch (ChangeConflictException)
                {
                    MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                    DialogResult = DialogResult.Retry;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        // Use validator(s) to assure that correct data is entered
        private bool IsValidData()
        {
            return
                Validator.IsPresent(pkgNameTextBox)&&
                Validator.IsPresent(pkgDescTextBox)&&
                Validator.IsPresent(pkgAgencyCommissionTextBox) &&
                Validator.IsPresent(pkgBasePriceTextBox) &&
                Validator.IsDecimal(pkgAgencyCommissionTextBox) &&
                Validator.IsDecimal(pkgBasePriceTextBox) &&
                Validator.IsCorrectLength(pkgDescTextBox, 50);
        }

        // Add cancel button 
        private void btnCancelPackages_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
