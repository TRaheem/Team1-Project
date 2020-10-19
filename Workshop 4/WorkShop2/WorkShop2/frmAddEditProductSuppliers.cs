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
    //Create add/edit product supplier table
    public partial class frmAddEditProductSuppliers : Form
    {
        public bool addProductSupplier;              // it is set in the main form
        public Products_Supplier cur;                // current supplier set up
        public TravelExpertDBDataContext db = new TravelExpertDBDataContext();

        public frmAddEditProductSuppliers()
        {
            InitializeComponent();
        }

        //when form loads
        private void frmAddEditProductSuppliers_Load(object sender, EventArgs e)
        {
            tlTpCancelProductSuppliers.SetToolTip(btnCancelSupplier, "Leave page and return to application");

            //add all products to list
            var products = db.Products;
            var productList = products.Select(p => p.ProdName).Distinct().ToList();
            prodsupplierNameComboBox.DataSource = productList;

            //add all suppliers to list
            var suppliers = db.Suppliers;
            var supplierList = suppliers.Select(p => p.SupName).Distinct().ToList();
            supprodNameComboBox.DataSource = supplierList;

            productIdTextBox.Text = "";
            supplierIdTextBox.Text = "";

            if (addProductSupplier)         //add product supplier
            {
                panel1.Visible = false;
                panel2.Visible = false;
                prodsupplierNameComboBox.Text = "";
                supprodNameComboBox.Text = "";
               tlTpSaveProductSuppliers.SetToolTip(btnSaveProductSupplier, "Saves New Supplier to Product");
            }
            else                             //edit product supplier
            {
                panel2.Visible = false;
                prodsupplierNameComboBox.Text = cur.Product.ProdName;
                supprodNameComboBox.Text = cur.Supplier.SupName;
                
               tlTpSaveProductSuppliers.SetToolTip(btnSaveProductSupplier, "Saves changes made");
            }
        }

        //save product supplier
        private void btnSaveProductSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                    using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
                    {
                    
                        Products_Supplier pkg = new Products_Supplier();

                        if (addProductSupplier)
                        {
                            
                            pkg.ProductId = Convert.ToInt32(productIdTextBox.Text);
                            pkg.SupplierId = Convert.ToInt32(supplierIdTextBox.Text);
                        db.Products_Suppliers.InsertOnSubmit(pkg);

                    }
                        else
                        {
                            // lambda expression is applied
                            pkg = db.Products_Suppliers.Single(pk => pk.ProductSupplierId ==
                                     Convert.ToInt32(textBox2.Text));
                            pkg.ProductId = Convert.ToInt32(productIdTextBox.Text);
                            pkg.SupplierId = Convert.ToInt32(supplierIdTextBox.Text);
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

        // select product name
        private void prodsupplierNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prodsupid = (from m in db.Products_Suppliers
                             join p in db.Products on m.ProductId equals p.ProductId
                             
                             where p.ProdName == prodsupplierNameComboBox.SelectedItem.ToString()
                             select p).ToList();
            foreach (var z in prodsupid)
            {
                productIdTextBox.Text = z.ProductId.ToString();

            }
        }

        //select supplier name
        private void supprodNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prodsupid = (from m in db.Products_Suppliers
                             join p in db.Suppliers on m.SupplierId equals p.SupplierId

                             where p.SupName == supprodNameComboBox.SelectedItem.ToString()
                             select p).ToList();
            foreach (var z in prodsupid)
            {
                supplierIdTextBox.Text = z.SupplierId.ToString();

            }
        }

        //close form
        private void btnCancelSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

