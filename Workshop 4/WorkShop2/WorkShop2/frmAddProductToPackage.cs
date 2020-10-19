using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WorkShop2
{
    //Create add product to package form
    public partial class frmAddProductToPackage : Form
    {
        public Package currentPackage;       // current package set 
        TravelExpertDBDataContext db = new TravelExpertDBDataContext();

        public frmAddProductToPackage()
        {
            InitializeComponent();
        }

        //When form loads
        private void frmAddProductToPackage_Load(object sender, EventArgs e)
        {
            txtPackageID.Text = currentPackage.PackageId.ToString();
            pnlProdSupIdForAddProduct.Visible = false;

            // populate the list of available products in the list
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                var products = (from prod in db.Products
                                      select prod.ProdName).ToList();
                prodNameListBox.DataSource = products;
            }
        }

        // what happens to supplier name list when the product name list is selected
        private void prodNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            supNameListBox.Items.Clear();
            var supprod = prodNameListBox.Items[prodNameListBox.SelectedIndex].ToString();

            var selectedValue = (from ps in db.Products_Suppliers
                                 join p in db.Products on ps.ProductId equals p.ProductId
                                 join s in db.Suppliers on ps.SupplierId equals s.SupplierId
                                 where p.ProdName == supprod
                                 select s).ToList();

            foreach (var s in selectedValue)
            {
                supNameListBox.Items.Add(s.SupName);
            }
        }

        // Generation of Product Supplier id
        private void supNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                var prodsupid = (from m in db.Products_Suppliers
                         join p in db.Suppliers on m.SupplierId equals p.SupplierId
                         join x in db.Products on m.ProductId equals x.ProductId
                         where p.SupName == supNameListBox.SelectedItem.ToString() &&
                         x.ProdName == prodNameListBox.SelectedItem.ToString()
                         select m).ToList();
            foreach (var z in prodsupid)
            {
                txtProductSupplierId.Text = z.ProductSupplierId.ToString();

            }
        }

        // Save product to package
        private void btnSaveProductToPackage_Click(object sender, EventArgs e)
        {
            try
            {
                Packages_Products_Supplier pps = null;

                pps = new Packages_Products_Supplier
                {
                    PackageId = currentPackage.PackageId,
                    ProductSupplierId = Convert.ToInt32(txtProductSupplierId.Text)
                };
                
                db.Packages_Products_Suppliers.InsertOnSubmit(pps);
                db.SubmitChanges();                        

                DialogResult = DialogResult.OK;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
