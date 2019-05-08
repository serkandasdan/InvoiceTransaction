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
    public partial class FormCountyDefinitions : Form
    {
        public FormCountyDefinitions()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();

        int CountyID;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                County county = new County();

                county.Description = txtCountyName.Text;

                county.CityID = (int)cmbCityName.SelectedValue;

                db.Counties.Add(county);

                db.SaveChanges();

                txtCountyName.Text = "";

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
                dataGridView1.DataSource = db.Counties.Select(x => new
                {
                    x.CountyID,
                    x.Description,
                    x.CityID
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
                var cityName = db.Cities.Select(x => new { x.CityID, x.Description }).ToList();

                cmbCityName.DisplayMember = "Description";
                cmbCityName.ValueMember = "CityID";
                cmbCityName.DataSource = cityName;

            }
            catch
            {


            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                County county = db.Counties.Where(x => x.CountyID == CountyID).FirstOrDefault();

                county.Description = txtCountyName.Text;

                county.CityID = (int)cmbCityName.SelectedValue;

                db.SaveChanges();

                txtCountyName.Text = "";

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
                    County county = db.Counties.Where(x => x.CountyID == CountyID).FirstOrDefault();
                    db.Counties.Remove(county);
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

                        int CountyID2 = Convert.ToInt32(drow.Cells[0].Value);
                        County county = db.Counties.Where(x => x.CountyID == CountyID2).FirstOrDefault();
                        db.Counties.Remove(county);
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


        private void FormCountyDefinitions_Load(object sender, EventArgs e)
        {
            Fill();
            ComboFill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCountyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CountyID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
