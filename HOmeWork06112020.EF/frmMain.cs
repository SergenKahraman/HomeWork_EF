using HomerWork_EF.Data.Context;
using HOmeWork06112020.EF.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HOmeWork06112020.EF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static Customer Customer { get; set; }
        public Category SelectedCategory { get; set; }
        private Product SelectedProduct { get; set; }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SignIn();

            LoadCategories();
        }

        private void SignIn()
        {
            var frmLoginHelper = new frmLogin();
            frmLoginHelper.ShowDialog();

            lblContact.Text = Customer?.ContactName + " ...";
            lblCompany.Text = $@"/{Customer?.CompanyName}";
        }

        //event Handler
        private void ToolStripMenuButton_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripItem;
            ChangeColor(button);

            SelectedCategory = (sender as ToolStripItem).Tag as Category;
            LoadProducts(SelectedCategory);
        }

        private void ChangeColor(ToolStripItem button)
        {
            foreach (var b in mstCategories.Items)
            {
                var stripButton = b as ToolStripItem;
                stripButton.ForeColor = Color.FromKnownColor(KnownColor.Black);
            }
            button.ForeColor = Color.FromKnownColor(KnownColor.IndianRed);
        }

        // Load Machine
        private void LoadCategories()
        {
            using (var ctx = new NorthwindEntities())
            {
                var categorySource = ctx.Categories.ToList();
                foreach (var c in categorySource)
                {
                    mstCategories.Items.Add(c.CategoryName, null, ToolStripMenuButton_Click).Tag = c;
                }
            }
        }

        private void LoadProducts(Category category)
        {
            using (var ctx = new NorthwindEntities())
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = ctx.Products.Where(i => i.CategoryID == category.CategoryID).Select(p => new ProductDto
                {
                    Name = p.ProductName,
                    Category = p.Category.CategoryName,
                    Company = p.Supplier.CompanyName,
                    Price = p.UnitPrice,
                    Stock = p.UnitsInStock
                }).ToList();

                ImageConverter converter = new ImageConverter();
                picCategory.Image = (Image)converter.ConvertFrom(category.Picture);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvProducts.SelectedRows[0];
            SelectedProduct = MapToProductDto(selectedRow);

            txtPrice.Text = SelectedProduct.UnitPrice.ToString();
            txtProductName.Text = SelectedProduct.ProductName;
            nudQuantity.Maximum = (decimal)SelectedProduct.UnitsInStock;
        }

        private Product MapToProductDto(DataGridViewRow selectedRow)
        {
            var results = new Product();
            var SelectedProductName = selectedRow.Cells[0].Value.ToString();
            using (var ctx = new NorthwindEntities())
            {
                results = ctx.Products.First(p => p.ProductName == SelectedProductName);
            }
            return results;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (SelectedProduct != null)
            {
                var SelectedQuantity = (short)nudQuantity.Value;
                using (var ctx = new NorthwindEntities())
                {
                    var result = ctx.Orders.Add(new Order
                    {
                        CustomerID = Customer.CustomerID,
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now.AddDays(20),
                        EmployeeID = 2
                    });
                    result.Order_Details.Add(new Order_Detail
                    {
                        Product = SelectedProduct,
                        Quantity = SelectedQuantity,
                        UnitPrice = SelectedProduct.UnitPrice.Value
                    });

                    SelectedProduct.UnitsInStock -= SelectedQuantity;
                    ctx.Entry(SelectedProduct).State = EntityState.Modified; // Update modu

                    ctx.SaveChanges();
                }

                RefreshAll();
            }
        }

        private void RefreshAll()
        {
            LoadProducts(SelectedCategory);
            txtPrice.Clear();
            txtProductName.Clear();
            nudQuantity.Value = nudQuantity.Minimum;
            SelectedProduct = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Programı Kapatmak İstediğinize Emin misiniz?", "NorthwindCart", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void msbOrders_Click(object sender, EventArgs e)
        {
            var frmOrdersHelper = new frmOrders();
            frmOrdersHelper.ShowDialog();
        }

        private void msbSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }
    }
}
