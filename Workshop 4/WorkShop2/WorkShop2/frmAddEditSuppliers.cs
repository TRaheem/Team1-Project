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

namespace WorkShop2
{
    // Create Add/Edit Supplier Form
    public partial class frmAddEditSuppliers : Form
    {
        public bool addSupplier;              // it is set in the main form
        public Supplier currentSupplier;      // current supplier set up

        public frmAddEditSuppliers()
        {
            InitializeComponent();
        }
        
        // Add data to Supplier Form
        private void frmAddEditSuppliers_Load(object sender, EventArgs e)
        {
            tltpCancelSupplier.SetToolTip(btnCancelSupplier, "Leave page and return to application");

            if (addSupplier)
            {
                pnlSuppliersid.Visible = true;
                supNameTextBox.Text = "";
                supplierIdTextBox.Text = "";
                tltpSaveSupplier.SetToolTip(btnSaveSupplier, "Saves New Supplier");
            }
            else
            {
                supNameTextBox.Text = currentSupplier.SupName;
                supplierIdTextBox.Text = currentSupplier.SupplierId.ToString();
                supplierIdTextBox.Enabled = false;
                tltpSaveSupplier.SetToolTip(btnSaveSupplier, "Saves changes made");
            }
        }
        
        // Save and validate data in Edit Supplier Form
        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
                {
                    Supplier sup = new Supplier();

                    if (addSupplier)
                    {
                        db.Suppliers.InsertOnSubmit(sup);
                        sup.SupName = supNameTextBox.Text;
                        sup.SupplierId = Convert.ToInt32(supplierIdTextBox.Text);                     
                    }
                    else
                    {
                        // lambda expression is applied
                        sup = db.Suppliers.Single(o => o.SupplierId ==
                                            Convert.ToInt32(supplierIdTextBox.Text));
                        sup.SupName = supNameTextBox.Text;
                    }


                    //Validate supplier name 
                    if (sup.SupName == "")
                    {
                        // Do not submit changes if data is obsolete
                        MessageBox.Show("Supplier Name is required");
                        return; 
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

        //Close form
        private void btnCancelSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
