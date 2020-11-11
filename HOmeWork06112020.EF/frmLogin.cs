using HomerWork_EF.Data.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HOmeWork06112020.EF
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) //TODO: çarpıya basınca açılmasın
        {
            using (var ctx = new NorthwindEntities())
            {
                //var result = ctx.Customers.Any(c => c.ContactName == txtContactName.Text && c.CompanyName == txtContactName.Text);
                var customers = ctx.Customers.Where(c => c.CompanyName == txtCompanyName.Text && c.ContactName == txtContactName.Text).ToList();
                Checking(customers);
            }
        }

        private void Checking(List<Customer> customers)
        {
            if (customers.Count > 0)
            {
                frmMain.Customer = customers[0];
                this.Close();
            }
            else
            {
                var result = MessageBox.Show("Company name or contact name is incorrect, please try again.", "Northwind", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    txtCompanyName.Clear();
                    txtContactName.Clear();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmMain.Customer == null)
            {
                Application.Exit();
            }
        }
    }
}