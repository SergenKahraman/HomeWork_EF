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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                dgvOrders.DataSource = context.Orders.Where(o => o.CustomerID == frmMain.Customer.CustomerID).Select(o => new CustomerOrderDto
                {
                    OrderCode = o.OrderID,
                    EmployeeName = o.Employee.FirstName + " " + o.Employee.LastName,
                    OrderDate = o.OrderDate,
                    RequiredDate = o.RequiredDate,
                    Detail = o.Order_Details.Select(od => new OrderDetailsDto
                    {
                        Discount = od.Discount,
                        Price = od.UnitPrice,
                        Quantity = od.Quantity
                    })
                }).AsEnumerable()
                  .Select(od => new CustomerOrderMappingDto
                  {
                      OrderCode = od.OrderCode,
                      OrderDate = od.OrderDate,
                      EmployeeName = od.EmployeeName,
                      RequiredDate = od.RequiredDate,
                      TotalPrice = od.Detail.Sum(odm => odm.Summary)
                  })
                  .ToList();

            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var SelectedOrderID = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                var frmOrderDetailsHelper = new frmOrderDetails(SelectedOrderID);
                frmOrderDetailsHelper.ShowDialog();
            }
        }
    }
}
