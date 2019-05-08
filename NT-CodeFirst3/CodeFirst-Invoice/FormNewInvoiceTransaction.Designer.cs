namespace CodeFirst_Invoice
{
    partial class FormNewInvoiceTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustumerCity = new System.Windows.Forms.Label();
            this.lblCustumerCounty = new System.Windows.Forms.Label();
            this.lblCustumer = new System.Windows.Forms.Label();
            this.lblDeliveryNumber = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.cmbCustomerCity = new System.Windows.Forms.ComboBox();
            this.cmbCustomerCounty = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtDeliveryNumber = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductUnit = new System.Windows.Forms.TextBox();
            this.txtProductVAT = new System.Windows.Forms.TextBox();
            this.nudProductAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInvoiceSave = new System.Windows.Forms.Button();
            this.btnCleanList = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lblCustumerCity
            // 
            this.lblCustumerCity.AutoSize = true;
            this.lblCustumerCity.Location = new System.Drawing.Point(35, 80);
            this.lblCustumerCity.Name = "lblCustumerCity";
            this.lblCustumerCity.Size = new System.Drawing.Size(71, 13);
            this.lblCustumerCity.TabIndex = 2;
            this.lblCustumerCity.Text = "Customer City";
            // 
            // lblCustumerCounty
            // 
            this.lblCustumerCounty.AutoSize = true;
            this.lblCustumerCounty.Location = new System.Drawing.Point(35, 123);
            this.lblCustumerCounty.Name = "lblCustumerCounty";
            this.lblCustumerCounty.Size = new System.Drawing.Size(87, 13);
            this.lblCustumerCounty.TabIndex = 3;
            this.lblCustumerCounty.Text = "Customer County";
            // 
            // lblCustumer
            // 
            this.lblCustumer.AutoSize = true;
            this.lblCustumer.Location = new System.Drawing.Point(35, 167);
            this.lblCustumer.Name = "lblCustumer";
            this.lblCustumer.Size = new System.Drawing.Size(51, 13);
            this.lblCustumer.TabIndex = 4;
            this.lblCustumer.Text = "Customer";
            // 
            // lblDeliveryNumber
            // 
            this.lblDeliveryNumber.AutoSize = true;
            this.lblDeliveryNumber.Location = new System.Drawing.Point(35, 207);
            this.lblDeliveryNumber.Name = "lblDeliveryNumber";
            this.lblDeliveryNumber.Size = new System.Drawing.Size(85, 13);
            this.lblDeliveryNumber.TabIndex = 5;
            this.lblDeliveryNumber.Text = "Delivery Number";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(35, 251);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(74, 13);
            this.lblPaymentDate.TabIndex = 6;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // cmbCustomerCity
            // 
            this.cmbCustomerCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerCity.FormattingEnabled = true;
            this.cmbCustomerCity.Location = new System.Drawing.Point(162, 77);
            this.cmbCustomerCity.Name = "cmbCustomerCity";
            this.cmbCustomerCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomerCity.TabIndex = 7;
            this.cmbCustomerCity.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerCity_SelectedIndexChanged);
            // 
            // cmbCustomerCounty
            // 
            this.cmbCustomerCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerCounty.FormattingEnabled = true;
            this.cmbCustomerCounty.Location = new System.Drawing.Point(162, 120);
            this.cmbCustomerCounty.Name = "cmbCustomerCounty";
            this.cmbCustomerCounty.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomerCounty.TabIndex = 8;
            this.cmbCustomerCounty.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerCounty_SelectedIndexChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(162, 164);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomer.TabIndex = 9;
            // 
            // txtDeliveryNumber
            // 
            this.txtDeliveryNumber.Location = new System.Drawing.Point(162, 204);
            this.txtDeliveryNumber.Name = "txtDeliveryNumber";
            this.txtDeliveryNumber.Size = new System.Drawing.Size(121, 20);
            this.txtDeliveryNumber.TabIndex = 10;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(162, 245);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(121, 20);
            this.dtpPaymentDate.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpPaymentDate);
            this.groupBox1.Controls.Add(this.txtDeliveryNumber);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.cmbCustomerCounty);
            this.groupBox1.Controls.Add(this.cmbCustomerCity);
            this.groupBox1.Controls.Add(this.lblPaymentDate);
            this.groupBox1.Controls.Add(this.lblDeliveryNumber);
            this.groupBox1.Controls.Add(this.lblCustumer);
            this.groupBox1.Controls.Add(this.lblCustumerCounty);
            this.groupBox1.Controls.Add(this.lblCustumerCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 294);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer and Delivery";
            // 
            // cmbProductName
            // 
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(163, 26);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(158, 21);
            this.cmbProductName.TabIndex = 13;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(163, 69);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(158, 20);
            this.txtProductPrice.TabIndex = 14;
            // 
            // txtProductUnit
            // 
            this.txtProductUnit.Location = new System.Drawing.Point(163, 113);
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.Size = new System.Drawing.Size(158, 20);
            this.txtProductUnit.TabIndex = 15;
            // 
            // txtProductVAT
            // 
            this.txtProductVAT.Location = new System.Drawing.Point(163, 157);
            this.txtProductVAT.Name = "txtProductVAT";
            this.txtProductVAT.Size = new System.Drawing.Size(158, 20);
            this.txtProductVAT.TabIndex = 16;
            // 
            // nudProductAmount
            // 
            this.nudProductAmount.Location = new System.Drawing.Point(163, 201);
            this.nudProductAmount.Name = "nudProductAmount";
            this.nudProductAmount.Size = new System.Drawing.Size(157, 20);
            this.nudProductAmount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Product Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Product VAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProductDelete);
            this.groupBox2.Controls.Add(this.btnProductUpdate);
            this.groupBox2.Controls.Add(this.btnProductAdd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudProductAmount);
            this.groupBox2.Controls.Add(this.txtProductVAT);
            this.groupBox2.Controls.Add(this.txtProductUnit);
            this.groupBox2.Controls.Add(this.txtProductPrice);
            this.groupBox2.Controls.Add(this.cmbProductName);
            this.groupBox2.Location = new System.Drawing.Point(372, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 289);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Transactions";
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(234, 242);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(87, 23);
            this.btnProductDelete.TabIndex = 25;
            this.btnProductDelete.Text = "Product Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(131, 242);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnProductUpdate.TabIndex = 24;
            this.btnProductUpdate.Text = "Product Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(40, 242);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 23;
            this.btnProductAdd.Text = "Product Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 271);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.Location = new System.Drawing.Point(745, 74);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(66, 54);
            this.btnInvoiceSave.TabIndex = 25;
            this.btnInvoiceSave.Text = "Invoice Save";
            this.btnInvoiceSave.UseVisualStyleBackColor = true;
            this.btnInvoiceSave.Click += new System.EventHandler(this.btnInvoiceSave_Click);
            // 
            // btnCleanList
            // 
            this.btnCleanList.Location = new System.Drawing.Point(745, 168);
            this.btnCleanList.Name = "btnCleanList";
            this.btnCleanList.Size = new System.Drawing.Size(66, 54);
            this.btnCleanList.TabIndex = 26;
            this.btnCleanList.Text = "Clean List";
            this.btnCleanList.UseVisualStyleBackColor = true;
            this.btnCleanList.Click += new System.EventHandler(this.btnCleanList_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Invoice Total =";
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.AutoSize = true;
            this.lblInvoiceTotal.Location = new System.Drawing.Point(783, 627);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(0, 13);
            this.lblInvoiceTotal.TabIndex = 27;
            // 
            // FormNewInvoiceTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 648);
            this.Controls.Add(this.lblInvoiceTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCleanList);
            this.Controls.Add(this.btnInvoiceSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNewInvoiceTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " New Invoice Transaction";
            this.Load += new System.EventHandler(this.FormNewInvoiceTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustumerCity;
        private System.Windows.Forms.Label lblCustumerCounty;
        private System.Windows.Forms.Label lblCustumer;
        private System.Windows.Forms.Label lblDeliveryNumber;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.ComboBox cmbCustomerCity;
        private System.Windows.Forms.ComboBox cmbCustomerCounty;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txtDeliveryNumber;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductUnit;
        private System.Windows.Forms.TextBox txtProductVAT;
        private System.Windows.Forms.NumericUpDown nudProductAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInvoiceSave;
        private System.Windows.Forms.Button btnCleanList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInvoiceTotal;
    }
}