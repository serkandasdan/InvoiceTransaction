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
    public partial class FormCityDefinitions : Form
    {
        public FormCityDefinitions()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();
        int CityID;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                City city = new City();
                city.Description = txtCityName.Text;
                db.Cities.Add(city);
                db.SaveChanges();
                txtCityName.Text = "";
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
                dataGridView1.DataSource = db.Cities.Select(x => new { x.CityID, x.Description }).ToList();
            }
            catch
            {


            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                City city = db.Cities.Where(x => x.CityID == CityID).FirstOrDefault();
                city.Description = txtCityName.Text;
                db.SaveChanges();
                txtCityName.Text = "";
                Fill();
            }
            catch
            {

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                City city = db.Cities.Where(x => x.CityID == CityID).FirstOrDefault();
                db.Cities.Remove(city);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen Tekli Seçim Yapınız.");
            }
            Fill();

        }

        private void btnMultipleDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {

                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int CityID2 = Convert.ToInt32(drow.Cells[0].Value);
                    City city = db.Cities.Where(x => x.CityID == CityID2).FirstOrDefault();
                    db.Cities.Remove(city);
                    db.SaveChanges();
                }

            }

            else
            {
                MessageBox.Show("Lütfen Çoklu Seçim Yapınız.");
            }
            Fill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCityName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CityID = (int)dataGridView1.CurrentRow.Cells[0].Value;

        }
        private void FormCityDefinitions_Load(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
