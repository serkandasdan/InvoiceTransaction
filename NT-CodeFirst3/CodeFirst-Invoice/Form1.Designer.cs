namespace CodeFirst_Invoice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supportTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityDefinitonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countyDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewQueriesEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportTablesToolStripMenuItem,
            this.ınvoiceTransactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supportTablesToolStripMenuItem
            // 
            this.supportTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDefinitionsToolStripMenuItem,
            this.unitDefinitionsToolStripMenuItem,
            this.productDefinitionsToolStripMenuItem,
            this.cityDefinitonsToolStripMenuItem,
            this.countyDefinitionsToolStripMenuItem});
            this.supportTablesToolStripMenuItem.Name = "supportTablesToolStripMenuItem";
            this.supportTablesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.supportTablesToolStripMenuItem.Text = "Support Tables";
            // 
            // customerDefinitionsToolStripMenuItem
            // 
            this.customerDefinitionsToolStripMenuItem.Name = "customerDefinitionsToolStripMenuItem";
            this.customerDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.customerDefinitionsToolStripMenuItem.Text = "Customer Definitions";
            this.customerDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.customerDefinitionsToolStripMenuItem_Click);
            // 
            // unitDefinitionsToolStripMenuItem
            // 
            this.unitDefinitionsToolStripMenuItem.Name = "unitDefinitionsToolStripMenuItem";
            this.unitDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.unitDefinitionsToolStripMenuItem.Text = "Unit Definitions";
            this.unitDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.unitDefinitionsToolStripMenuItem_Click);
            // 
            // productDefinitionsToolStripMenuItem
            // 
            this.productDefinitionsToolStripMenuItem.Name = "productDefinitionsToolStripMenuItem";
            this.productDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.productDefinitionsToolStripMenuItem.Text = "Product Definitions";
            this.productDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.productDefinitionsToolStripMenuItem_Click);
            // 
            // cityDefinitonsToolStripMenuItem
            // 
            this.cityDefinitonsToolStripMenuItem.Name = "cityDefinitonsToolStripMenuItem";
            this.cityDefinitonsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cityDefinitonsToolStripMenuItem.Text = "City Definitons";
            this.cityDefinitonsToolStripMenuItem.Click += new System.EventHandler(this.cityDefinitonsToolStripMenuItem_Click);
            // 
            // countyDefinitionsToolStripMenuItem
            // 
            this.countyDefinitionsToolStripMenuItem.Name = "countyDefinitionsToolStripMenuItem";
            this.countyDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countyDefinitionsToolStripMenuItem.Text = "County Definitions";
            this.countyDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.countyDefinitionsToolStripMenuItem_Click);
            // 
            // ınvoiceTransactionToolStripMenuItem
            // 
            this.ınvoiceTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewQueriesEditToolStripMenuItem,
            this.newInvoiceTransactionToolStripMenuItem});
            this.ınvoiceTransactionToolStripMenuItem.Name = "ınvoiceTransactionToolStripMenuItem";
            this.ınvoiceTransactionToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.ınvoiceTransactionToolStripMenuItem.Text = "Invoice Transaction";
            // 
            // newInvoiceTransactionToolStripMenuItem
            // 
            this.newInvoiceTransactionToolStripMenuItem.Name = "newInvoiceTransactionToolStripMenuItem";
            this.newInvoiceTransactionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newInvoiceTransactionToolStripMenuItem.Text = "Create New Invoice";
            this.newInvoiceTransactionToolStripMenuItem.Click += new System.EventHandler(this.newInvoiceTransactionToolStripMenuItem_Click);
            // 
            // viewQueriesEditToolStripMenuItem
            // 
            this.viewQueriesEditToolStripMenuItem.Name = "viewQueriesEditToolStripMenuItem";
            this.viewQueriesEditToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewQueriesEditToolStripMenuItem.Text = "View / Queries / Edit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 438);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supportTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityDefinitonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countyDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewQueriesEditToolStripMenuItem;
    }
}

