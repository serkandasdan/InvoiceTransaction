using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_Invoice.Entity;

namespace CodeFirst_Invoice
{
    public partial class FormCustomerDefinitions : Form
    {
        public FormCustomerDefinitions()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();

        int CustomerID;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();

                customer.CompanyName = txtCustomerName.Text;

                customer.CityID = (int)(cmbCustomerCity.SelectedValue);

                customer.CountyID = (int)(cmbCustomerCounty.SelectedValue);

                customer.Address = txtAddress.Text;
                db.Customers.Add(customer);

                db.SaveChanges();

                txtAddress.Text = "";
                txtCustomerName.Text = "";


                Fill();
            }
            catch
            {

             
            }
          

        }

        public void Fill()
        {

            try
            {
                dataGridView1.DataSource = db.Customers.Select(x => new
                {
                    x.CustomerID,
                    x.CompanyName,
                    x.CityID,
                    x.CountyID,
                    x.Address
                }).ToList();
            }
            catch 
            {
                
            }
         
        }
    
        public void ComboFill()
        {
            try
            {
                var city = db.Cities.Select(x => new { x.CityID, x.Description }).ToList();

                cmbCustomerCity.DisplayMember = "Description";
                cmbCustomerCity.ValueMember = "CityID";
                cmbCustomerCity.DataSource = city;

                var county = db.Counties.Select(x => new { x.CityID, x.CountyID, x.Description })
                    .Where(x => x.CityID == (int)(cmbCustomerCity.SelectedValue)).ToList();
                cmbCustomerCounty.DisplayMember = "Description";
                cmbCustomerCounty.ValueMember = "CountyID";
                cmbCustomerCounty.DataSource = county;
            }
            catch
            {

               
            }
          

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = db.Customers.Where(x => x.CustomerID == CustomerID).FirstOrDefault();

                customer.CompanyName = txtCustomerName.Text;
                customer.CityID = (int)cmbCustomerCity.SelectedValue;
                customer.CountyID = (int)cmbCustomerCounty.SelectedValue;
                customer.Address = txtCustomerName.Text;
                db.SaveChanges();
                Fill();
            }
            catch
            {

            }
    

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Customer customer = db.Customers.Where(x => x.CustomerID == CustomerID).FirstOrDefault();
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Lütfen Tekli Seçim Yapınız.");
                }
                Fill();
            }
            catch 
            {

               
            }        
            
        }

        private void btnMultipleDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {

                    foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                    {
                        int CustomerID2 = Convert.ToInt32(drow.Cells[0].Value);
                        Customer customer = db.Customers.Where(x => x.CustomerID == CustomerID2).FirstOrDefault();
                        db.Customers.Remove(customer);
                        db.SaveChanges();

                    }

                }

                else
                {
                    MessageBox.Show("Lütfen Çoklu Seçim Yapınız.");
                }
                Fill();

            }
            catch
            {
       
            }
    
        }

        private void FormCustomerDefinitions_Load(object sender, EventArgs e)
        {
            Fill();
            ComboFill();

          
        }

        private void cmbCustomerCity_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbCustomerCounty.ValueMember = "CountyID";
            cmbCustomerCounty.DisplayMember = "Description";
            cmbCustomerCounty.DataSource = db.Counties.Where(x => x.CityID == (int)cmbCustomerCity.SelectedValue).ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            CustomerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }
    }
}
