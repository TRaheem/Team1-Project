using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop4;

namespace WorkShop2
{
    // Create Add/Edit Product Form
    public partial class frmAddEditProducts : Form
    {
        public bool addProduct;              // it is set in the main form
        public Product currentProduct;       // current product set up

        public frmAddEditProducts()
        {
            InitializeComponent();
        }
        
        // Add data to Add/Edit Product Form
        private void frmAddEditProducts_Load(object sender, EventArgs e)
        {
            tltpCancelProduct.SetToolTip(btnCancelProduct, "Leave page and return to application");

            if (addProduct)
            {
                pnlProductId.Visible = false;
                prodNameTextBox.Text = "";
                tltpSaveProduct.SetToolTip(btnSaveProduct, "Saves new product");
            }
            else
            {
                prodNameTextBox.Text = currentProduct.ProdName;
                productIdTextBox.Text = currentProduct.ProductId.ToString();
                productIdTextBox.Enabled = false;
                tltpSaveProduct.SetToolTip(btnSaveProduct, "Saves changes made");
            }            
        }

        // Save and validate data in Edit Product Form
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
                {
                    Product prod = new Product();

                    if (addProduct)
                    {
                        db.Products.InsertOnSubmit(prod);
                        prod.ProdName = prodNameTextBox.Text;
                    }
                    else
                    {
                        // lambda expression is applied
                        prod = db.Products.Single(o => o.ProductId ==
                                            Convert.ToInt32(productIdTextBox.Text));
                        prod.ProdName = prodNameTextBox.Text;
                    }


                    //Validate product name 
                    // only need to validate if end date provided
                    if (prod.ProdName == "")
                    {
                        // Changes are not submitted if data is obsolete
                        MessageBox.Show("Product Name is required");
                        return; 
                    }

                    db.SubmitChanges();
                    DialogResult = DialogResult.OK;
                }
            }
            // Catch concurrency exception
            catch (ChangeConflictException)
            {
                MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                DialogResult = DialogResult.Retry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //Add cancel button
        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
