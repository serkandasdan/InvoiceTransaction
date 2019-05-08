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
    public partial class FormUnitDefinitions : Form
    {
        public FormUnitDefinitions()
        {
            InitializeComponent();
        }
        InvoiceContext db = new InvoiceContext();
        int UnitID;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Unit unit = new Unit();
                unit.UnitName = txtUnitName.Text;
                db.Units.Add(unit);
                db.SaveChanges();
                txtUnitName.Text = "";
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
                dataGridView1.DataSource = db.Units.Select(x => new { x.UnitID, x.UnitName }).ToList();
            }
            catch
            {

                
            }

        }
        private void FormUnitDefinitions_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Unit unit = db.Units.Where(x => x.UnitID == UnitID).FirstOrDefault();
                unit.UnitName = txtUnitName.Text;
                db.SaveChanges();
                txtUnitName.Text = "";

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
                Unit unit = db.Units.Where(x => x.UnitID == UnitID).FirstOrDefault();
                db.Units.Remove(unit);
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
                    int UnitID2 = Convert.ToInt32(drow.Cells[0].Value);
                    Unit unit = db.Units.Where(x => x.UnitID == UnitID2).FirstOrDefault();
                    db.Units.Remove(unit);
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
            txtUnitName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            UnitID = (int)dataGridView1.CurrentRow.Cells[0].Value;

        }
    }
}
