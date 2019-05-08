using CodeFirst_Invoice.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_Invoice
{
    public partial class FormNewInvoiceTransaction : Form
    {
        public FormNewInvoiceTransaction()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();

        int selectedProductID;

        List<InvoiceDetails> ınvoiceDetails = new List<InvoiceDetails>();
        private void FormNewInvoiceTransaction_Load(object sender, EventArgs e)
        {
            ComboFill();
        }

        public void ComboFill()
        {
            try
            {
                var city = db.Cities.Select(x => new { x.CityID, x.Description }).ToList();

                cmbCustomerCity.DisplayMember = "Description";
                cmbCustomerCity.ValueMember = "CityID";
                cmbCustomerCity.DataSource = city;

                int selectetdCityID = (int)(cmbCustomerCity.SelectedValue);
                var county = db.Counties.Select(x => new { x.CityID, x.CountyID, x.Description })
                    .Where(x => x.CityID == selectetdCityID).ToList();
                cmbCustomerCounty.DisplayMember = "Description";
                cmbCustomerCounty.ValueMember = "CountyID";
                cmbCustomerCounty.DataSource = county;

                var customer = db.Customers.Select(x => new { x.CustomerID, x.CompanyName }).ToList();
                cmbCustomer.DisplayMember = "CompanyName";
                cmbCustomer.ValueMember = "CustomerID";
                cmbCustomer.DataSource = customer;

                var product = db.Products.Select(x => new { x.ProductID, x.ProductName }).ToList();
                cmbProductName.DisplayMember = "ProductName";
                cmbProductName.ValueMember = "ProductID";
                cmbProductName.DataSource = product;

                    
            }
            catch
            {

            }

        }

        private void cmbCustomerCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomerCounty.ValueMember = "CountyID";
            cmbCustomerCounty.DisplayMember = "Description";  
            cmbCustomerCounty.DataSource = db.Counties.Where(x => x.CityID == (int)cmbCustomerCity.SelectedValue).ToList();
        }

        private void cmbCustomerCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.DataSource = db.Customers.Where(x => x.CountyID == (int)cmbCustomerCounty.SelectedValue).ToList();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {

            foreach (var item in ınvoiceDetails)
            {
                item.ProductID = (int)cmbProductName.SelectedValue;
                item.UnitPrice = Convert.ToDecimal(txtProductPrice.Text);
                item.product.unit.UnitName = txtProductUnit.Text;
                item.VATAmount = Convert.ToDecimal(txtProductVAT.Text);
                item.AmountWithVAT = nudProductAmount.Value;

           

                dataGridView1.DataSource = item;
            }
          
            
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnInvoiceSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCleanList_Click(object sender, EventArgs e)
        {

        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProductID = Convert.ToInt32(cmbProductName.SelectedValue);
            txtFill();
        }
        public void txtFill()
        {
            var product = db.Products.Find(selectedProductID);
            txtProductPrice.Text = product.UnitPrice.ToString();
            txtProductUnit.Text = db.Units.Find(product.UnitID).UnitName;
        }
    }
}
