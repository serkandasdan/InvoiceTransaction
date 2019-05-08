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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerDefinitions frm = new FormCustomerDefinitions();
            frm.Show();
        }

        private void unitDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnitDefinitions frm = new FormUnitDefinitions();
            frm.Show();

        }

        private void productDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductDefinitions frm = new FormProductDefinitions();
            frm.Show();

        }

        private void cityDefinitonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCityDefinitions frm = new FormCityDefinitions();
            frm.Show();
        }

        private void countyDefinitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCountyDefinitions frm = new FormCountyDefinitions();
            frm.Show();

        }

        private void newInvoiceTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewInvoiceTransaction frm = new FormNewInvoiceTransaction();
            frm.Show();
        }
    }
}
