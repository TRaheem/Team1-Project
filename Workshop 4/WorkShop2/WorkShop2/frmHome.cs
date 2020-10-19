using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using WorkShop4;

/* Team Triggers - Group members did alot of collaboration on this project 
 * The aim of this project is to prepare an application where company agents
 * are able to add and edit Packages, add Products to Package, 
 * add and edit Products, Suppliers and Product-Suppliers Table*/
 
namespace WorkShop2
{
    //Create main page form 
    public partial class frmHome : Form
    {
        // Create data context object
        public TravelExpertDBDataContext db = new TravelExpertDBDataContext();

        public frmHome()
        {
            InitializeComponent();
        }

        //Create list for each table
        List<Package> packages;
        List<Packages_Products_Supplier> packagesProductsSuppliers;
        List<Package_Product> packageProduct;
        List<Product> products;
        List<Products_Supplier> products_Suppliers;
        public bool isAdd;
        public Package pkg;
        private Package k;
        public Product product1;
        public Supplier supplier1;

        //What happens when form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // State of combobox 
            cmbTableList.SelectedIndex = 0;
            tabControl1.SelectedIndex = 0;

            packages = db.Packages.ToList();
            packagesProductsSuppliers = db.Packages_Products_Suppliers.ToList();

            //Products for each package selected
            foreach (var pkg in packages)
            {
                pkgNameListBox.Items.Add(pkg.PkgName);
            }

            // combo box of product list 
            var products = db.Products;
            var productList = products.Select(p => p.ProdName).Distinct().ToList();
            cmbProductList.DataSource = productList;
        }

        //Tab selection
        private void cmbTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTableList.SelectedIndex == 0)
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if (cmbTableList.SelectedIndex == 1)
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if (cmbTableList.SelectedIndex == 2)
            {
                tabControl1.SelectedTab = tabPage3;
            }
            else
                tabControl1.SelectedTab = tabPage4;
        }

        //What happens when package name is selected
        private void pkgNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackageListDataLoad();
            PackageProductsDataLoad();
        }

        // get products and suppliers for package
        public void PackageProductsDataLoad()
        { 
            var packag = from pps in db.Packages_Products_Suppliers
                         join ps in db.Products_Suppliers
                         on pps.ProductSupplierId equals ps.ProductSupplierId
                         join sup in db.Suppliers
                         on ps.SupplierId equals sup.SupplierId
                         join p in db.Products
                         on ps.ProductId equals p.ProductId
                         into dbGroup
                         select new
                         {
                             PackageID = pps.PackageId,
                             ProductName = ps.Product.ProdName,
                             SupplierName = sup.SupName,
                         };

            var listProdPack = from prod in packag
                               where prod.PackageID == Convert.ToInt32(txtPkgID.Text)
                               select new { prod.ProductName, prod.SupplierName };
            package_ProductDataGridView.DataSource = listProdPack.ToList();
        }

        //get all package details loaded when package name is selected
        public void PackageListDataLoad()
        {
            var pkg = db.Packages;

            foreach (var item in pkg)
                if (item.PkgName == pkgNameListBox.SelectedItem.ToString())
                {
                    var packageId = item.PackageId;
                    txtPkdName.Text = item.PkgName;
                    txtPkgID.Text = item.PackageId.ToString();
                    txtPkgDesc.Text = item.PkgDesc;
                    txtPkgBasePrice.Text = item.PkgBasePrice.ToString("C");
                    txtPkgCommission.Text = item.PkgAgencyCommission.ToString();
                    if (item.PkgStartDate.HasValue)
                    {
                        dtpPkgStartDate.Text = item.PkgStartDate.Value.ToShortDateString();
                    }
                    else
                    {
                        dtpPkgStartDate.Format = DateTimePickerFormat.Short;
                    }


                    if (item.PkgEndDate.HasValue)
                    {
                        dtpPkgEndDate.Text = item.PkgEndDate.Value.ToShortDateString();
                    }
                    else
                    {
                        dtpPkgEndDate.Format = DateTimePickerFormat.Short;
                    }
                }
        }

        // Get all suppliers for selected product
        private void cmbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSuppliers.Items.Clear();

            var query = (from ps in db.Products_Suppliers
                         join s in db.Suppliers
                          on ps.SupplierId equals s.SupplierId
                         join p in db.Products
                         on ps.ProductId equals p.ProductId
                         into dbGroup
                         select new
                         {
                             ProductName = ps.Product.ProdName,
                             SupplierName = s.SupName,
                         }).ToList();

            foreach (var supname in query)

            {
                if (supname.ProductName == cmbProductList.SelectedItem.ToString())
                {
                    lstSuppliers.Items.Add(supname.SupplierName);
                }
            }
        }

        //what happens when each tab is selected
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                //tab package details
                case 0:
                    pkgNameListBox.Items.Clear();
                    Package pkg = new Package();
                    packages = db.Packages.ToList();
                    packagesProductsSuppliers = db.Packages_Products_Suppliers.ToList();

                    //Products for each package selected
                    foreach (var kg in packages)
                    {
                        pkgNameListBox.Items.Add(kg.PkgName);
                    }

                    // combo box of product list 
                    Product prod = new Product();
                    var products = db.Products;
                    var productList = products.Select(d => d.ProdName).Distinct().ToList();
                    cmbProductList.DataSource = productList;
                   break;

                    //tab for updating packages
                case 1:
                    packageDataGridView.DataSource = db.Packages;
                   break;

                    //tab for updating product/suppliers
                case 2:
                    productDataGridView.DataSource = db.Products;
                    supplierDataGridView.DataSource = db.Suppliers;
                   break;

                    //tab for updating product_suppliers table
                case 3:                
                    Products_Supplier prosu = null;
                    prosu = new Products_Supplier();

                    var prodsup = from ps in db.Products_Suppliers
                                  join sup in db.Suppliers
                                  on ps.SupplierId equals sup.SupplierId
                                  join p in db.Products
                                  on ps.ProductId equals p.ProductId
                                  into dbGroup
                                  select new
                                  {
                                      ProductSupplierID = ps.ProductSupplierId,
                                      ProductId = ps.Product.ProdName,
                                      SupplierId = sup.SupName,
                                  };

                    products_SupplierDataGridView.DataSource = prodsup.ToList();
                    break;
            }
        }

        // Add products
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProducts addProductForm = new frmAddEditProducts();
            addProductForm.addProduct = true;

            // Display second form modal
            DialogResult result = addProductForm.ShowDialog();
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                // Update is successful
                if (result == DialogResult.OK)
                {
                    // Refresh grid
                    productDataGridView.DataSource = db.Products;
                    products = db.Products.ToList();
                    MessageBox.Show("New Product Added Successfully");

                }
            }
        }

        //Edit products
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProducts addProductForm = new frmAddEditProducts();
            addProductForm.addProduct = false;

            // get the key of the current product in the data grid view
            int rowNum = Convert.ToInt32(productDataGridView.CurrentCell.RowIndex); // index of the current row
            int ordernum = Convert.ToInt32(productDataGridView["dataGridViewTextBoxColumn12", rowNum].Value); // Column for productid

            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                addProductForm.currentProduct = (from p in db.Products
                                                 where p.ProductId == ordernum
                                                 select p).Single();
            }

            DialogResult result = addProductForm.ShowDialog(); // display second form modal
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                if (result == DialogResult.OK)// successful update
                {
                    productDataGridView.DataSource = db.Products; // refresh grid
                    MessageBox.Show("Product Name Edited Successfully");
                }
            }
        }

        //Add package
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddEditPackages addPackageForm = new frmAddEditPackages();
            addPackageForm.addPackage = true;

            // Display second form model
            DialogResult result = addPackageForm.ShowDialog();
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                // Update is successful
                if (result == DialogResult.OK)
                {
                    // Refresh grid
                    packageDataGridView.DataSource = db.Packages;                                      
                    MessageBox.Show("New Package Inserted Successfully");
                    //packages = db.Packages.ToList();
                }
            }
        }

        //Edit package
        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            frmAddEditPackages addPackageForm = new frmAddEditPackages();
            addPackageForm.addPackage = false;

            // get the key of the current package in the data grid view
            // Index of the current row
            int pkgrowNum = Convert.ToInt32(packageDataGridView.CurrentCell.RowIndex);
            // Column for package Id
            int pkgordernum = Convert.ToInt32(packageDataGridView["dataGridViewTextBoxColumn1", pkgrowNum].Value);

            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                addPackageForm.currentPackage = (from pk in db.Packages
                                                 where pk.PackageId == pkgordernum
                                                 select pk).Single();
            }

            // Display second form modal
            DialogResult result = addPackageForm.ShowDialog();
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                // Update is successful
                if (result == DialogResult.OK)
                {
                    // Refresh grid
                    packageDataGridView.DataSource = db.Packages;
                    //package_ProductsDataGridView.DataSource = db.Package_Products;
                    MessageBox.Show("Package Edited Successfully");
                }
            }
        }             
        
        //Add supplier
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddEditSuppliers addSupplierForm = new frmAddEditSuppliers();
            addSupplierForm.addSupplier = true;

            // Display second form model
            DialogResult result = addSupplierForm.ShowDialog();
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                // Update is successful
                if (result == DialogResult.OK)
                {
                    // Refresh grid
                    supplierDataGridView.DataSource = db.Suppliers;
                    MessageBox.Show("New Supplier Added Successfully");
                }
            }
        }

        //Edit supplier
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            frmAddEditSuppliers addSupplierForm = new frmAddEditSuppliers();
            addSupplierForm.addSupplier = false;

            // Get the key of the current supplier in the data grid view
            // Index of the current row
            int suprowNum = Convert.ToInt32(supplierDataGridView.CurrentCell.RowIndex);
            // Column for product Id 
            int supordernum = Convert.ToInt32(supplierDataGridView["dataGridViewTextBoxColumn14", suprowNum].Value);

            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                addSupplierForm.currentSupplier = (from p in db.Suppliers
                                                   where p.SupplierId == supordernum
                                                   select p).Single();
            }

            // Display second form model
            DialogResult result = addSupplierForm.ShowDialog();
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                // Update is successful
                if (result == DialogResult.OK)
                {
                    // Refresh grid
                    supplierDataGridView.DataSource = db.Suppliers;
                    MessageBox.Show("Supplier Name Edited Successfully");
                }
            }
        }

        //Add Supplier to product
        private void btnAddProductSupplier_Click(object sender, EventArgs e)
        {
                frmAddEditProductSuppliers addProductSupplierForm = new frmAddEditProductSuppliers();
                addProductSupplierForm.addProductSupplier = true;

                // Display second form model
                DialogResult result = addProductSupplierForm.ShowDialog();
                using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
                {
                    // Update is successful
                    if (result == DialogResult.OK)
                    {
                        // Refresh grid
                        Products_Supplier prosu = null;
                        prosu = new Products_Supplier();

                        var prodsup = from ps in db.Products_Suppliers
                                  join sup in db.Suppliers
                                  on ps.SupplierId equals sup.SupplierId
                                  join p in db.Products
                                  on ps.ProductId equals p.ProductId
                                  into dbGroup
                                  select new
                                  {
                                      ProductSupplierID = ps.ProductSupplierId,
                                      ProductId = ps.Product.ProdName,
                                      SupplierId = sup.SupName,
                                  };

                        products_SupplierDataGridView.DataSource = prodsup.ToList();

                        MessageBox.Show("New Supplier Added to Product Successfully");
                    }
                }           
        }

        //Edit supplier of product
        private void btnEditProductSupplier_Click(object sender, EventArgs e)
        {
            frmAddEditProductSuppliers addProductSupplierForm = new frmAddEditProductSuppliers();
            addProductSupplierForm.addProductSupplier = false;
            
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                // Index of the current row

                var prodsupid = (from m in db.Products_Suppliers
                                 join p in db.Products on m.ProductId equals p.ProductId

                                 where p.ProdName == products_SupplierDataGridView.SelectedRows.ToString()
                                 select p);
                
                var prods = (from m in db.Products_Suppliers
                                 join p in db.Suppliers on m.SupplierId equals p.SupplierId

                                 where p.SupName == products_SupplierDataGridView.SelectedRows.ToString()
                                 select p);

                int prodsuprowNum = Convert.ToInt32(products_SupplierDataGridView.CurrentCell.RowIndex);

                // Column for productsupplier Id 
                int prosupordernum = Convert.ToInt32(products_SupplierDataGridView["dataGridViewTextBoxColumn8", prodsuprowNum].Value);

                addProductSupplierForm.cur = (from p in db.Products_Suppliers
                                              where p.ProductId  == Convert.ToInt32(prodsupid) && p.SupplierId == Convert.ToInt32(prods)
                                              select p).Single();
            }

            // Display second form model
            DialogResult result = addProductSupplierForm.ShowDialog();
            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                // Update is successful
                if (result == DialogResult.OK)
                {
                    // Refresh grid
                    products_SupplierDataGridView.DataSource = db.Products_Suppliers;
                    MessageBox.Show("Supplier Name Edited in Product Successfully");
                }
            }
        }

        //Add Product to Package
        private void btnAddProductToPackage_Click(object sender, EventArgs e)
        {
            //int pack_id = Convert.ToInt32(cboPackageId.SelectedValue);
            int pkgrowNum = Convert.ToInt32(packageDataGridView.CurrentCell.RowIndex);
            // Column for package Id
            int pkgordernum = Convert.ToInt32(packageDataGridView["dataGridViewTextBoxColumn1", pkgrowNum].Value);

            using (TravelExpertDBDataContext db = new TravelExpertDBDataContext())
            {
                Package curPack = (from p in db.Packages
                                   where p.PackageId == pkgordernum
                                   select p).Single();

                frmAddProductToPackage secondform = new frmAddProductToPackage();
                secondform.currentPackage = curPack;

                DialogResult result = secondform.ShowDialog();
                if (result == DialogResult.OK)// successful Add
                {
                    packageDataGridView.DataSource = db.Packages;
                    MessageBox.Show("Product has been added to Package Successfully");
                }
            }
        }

        //Add product to package
        private void packageDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            listBoxPackageProducts.Items.Clear();

            int pkgrowNum = Convert.ToInt32(packageDataGridView.CurrentCell.RowIndex);
            // Column for package Id
            int pkgordernum = Convert.ToInt32(packageDataGridView["dataGridViewTextBoxColumn1", pkgrowNum].Value);

            var packprodsup = (from p in db.Packages_Products_Suppliers
                               where p.PackageId == pkgordernum
                               select p).ToList();

            foreach (var s in packprodsup)
            {
                var call = (from p in db.Products_Suppliers
                            where p.ProductSupplierId == s.ProductSupplierId
                            select p).Single();

                var product = (from p in db.Products
                               where p.ProductId == call.ProductId
                               select p.ProdName).Single();

                listBoxPackageProducts.Items.Add(product);
            }
        }

        //Add Close button for packages tab
        private void btnExit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        // close button for product and supplier tab
        private void btnExitProductSupplier_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        //close product/supplier tab
        private void btnCloseProductSupplier_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        //exit application
        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
