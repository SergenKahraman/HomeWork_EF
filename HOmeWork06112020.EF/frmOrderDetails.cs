using HomerWork_EF.Data.Context;
using HOmeWork06112020.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOmeWork06112020.EF
{
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails(int selectedOrderID)
        {
            InitializeComponent();
            SelectedOrderID = selectedOrderID;
        }
        private int SelectedOrderID { get; set; }
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                dgvOrderDetails.DataSource = context.Order_Details.Where(od => od.OrderID == SelectedOrderID).Select(od => new OrderDetailsDto
                {
                    OrderCode = od.OrderID,
                    ProductName = od.Product.ProductName,
                    Price = od.UnitPrice,
                    Discount = od.Discount,
                    Quantity = od.Quantity,
                }).ToList();
            }
        }
    }
}
