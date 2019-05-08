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
    public partial class FormProductDefinitions : Form
    {
        public FormProductDefinitions()
        {
            InitializeComponent();
        }
        InvoiceContext db = new InvoiceContext();

        int ProductID;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                product.ProductName = txtProductName.Text;

                product.ProductCode = txtProductCode.Text;

                product.UnitID = (int)cmbUnitName.SelectedValue;

                product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);

                db.Products.Add(product);

                db.SaveChanges();

                txtProductName.Text = "";
                txtProductCode.Text = "";
                txtUnitPrice.Text = "";

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
                dataGridView1.DataSource = db.Products.Select(x => new
                {
                    x.ProductID,
                    x.ProductName,
                    x.ProductCode,
                    x.UnitID,
                    x.UnitPrice
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
                var unitName = db.Units.Select(x => new { x.UnitID, x.UnitName }).ToList();

                cmbUnitName.DisplayMember = "UnitName";
                cmbUnitName.ValueMember = "UnitID";
                cmbUnitName.DataSource = unitName;

            }
            catch
            {


            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = db.Products.Where(x => x.ProductID == ProductID).FirstOrDefault();

                product.ProductName = txtProductName.Text;

                product.ProductCode = txtProductCode.Text;

                product.UnitID = (int)cmbUnitName.SelectedValue;

                product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);

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
                    Product product = db.Products.Where(x => x.ProductID == ProductID).FirstOrDefault();
                    db.Products.Remove(product);
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
                        int ProductID2 = Convert.ToInt32(drow.Cells[0].Value);
                        Product product = db.Products.Where(x => x.ProductID == ProductID2).FirstOrDefault();
                        db.Products.Remove(product);
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

        private void FormProductDefinitions_Load(object sender, EventArgs e)
        {
            Fill();
            ComboFill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtProductCode.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUnitPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
