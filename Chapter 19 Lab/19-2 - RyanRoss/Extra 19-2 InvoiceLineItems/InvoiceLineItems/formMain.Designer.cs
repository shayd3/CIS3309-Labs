namespace InvoiceLineItems
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label productTotalLabel;
            System.Windows.Forms.Label salesTaxLabel;
            System.Windows.Forms.Label shippingLabel;
            System.Windows.Forms.Label invoiceTotalLabel;
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMABooksDataSet = new InvoiceLineItems.MMABooksDataSet();
            this.productTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.shippingTextBox = new System.Windows.Forms.TextBox();
            this.invoiceTotalTextBox = new System.Windows.Forms.TextBox();
            this.fillByInvoiceIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.invoiceIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.invoiceIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByInvoiceIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.invoiceLineItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new InvoiceLineItems.MMABooksDataSetTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new InvoiceLineItems.MMABooksDataSetTableAdapters.TableAdapterManager();
            this.invoiceLineItemsTableAdapter = new InvoiceLineItems.MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter();
            invoiceDateLabel = new System.Windows.Forms.Label();
            productTotalLabel = new System.Windows.Forms.Label();
            salesTaxLabel = new System.Windows.Forms.Label();
            shippingLabel = new System.Windows.Forms.Label();
            invoiceTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).BeginInit();
            this.fillByInvoiceIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(31, 38);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            invoiceDateLabel.TabIndex = 2;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // productTotalLabel
            // 
            productTotalLabel.AutoSize = true;
            productTotalLabel.Location = new System.Drawing.Point(31, 63);
            productTotalLabel.Name = "productTotalLabel";
            productTotalLabel.Size = new System.Drawing.Size(74, 13);
            productTotalLabel.TabIndex = 4;
            productTotalLabel.Text = "Product Total:";
            // 
            // salesTaxLabel
            // 
            salesTaxLabel.AutoSize = true;
            salesTaxLabel.Location = new System.Drawing.Point(31, 89);
            salesTaxLabel.Name = "salesTaxLabel";
            salesTaxLabel.Size = new System.Drawing.Size(57, 13);
            salesTaxLabel.TabIndex = 6;
            salesTaxLabel.Text = "Sales Tax:";
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.Location = new System.Drawing.Point(31, 115);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new System.Drawing.Size(51, 13);
            shippingLabel.TabIndex = 8;
            shippingLabel.Text = "Shipping:";
            // 
            // invoiceTotalLabel
            // 
            invoiceTotalLabel.AutoSize = true;
            invoiceTotalLabel.Location = new System.Drawing.Point(31, 141);
            invoiceTotalLabel.Name = "invoiceTotalLabel";
            invoiceTotalLabel.Size = new System.Drawing.Size(72, 13);
            invoiceTotalLabel.TabIndex = 10;
            invoiceTotalLabel.Text = "Invoice Total:";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.invoiceDateDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(111, 34);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateDateTimePicker.TabIndex = 3;
            this.invoiceDateDateTimePicker.Value = new System.DateTime(2016, 11, 11, 18, 51, 37, 0);
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // mMABooksDataSet
            // 
            this.mMABooksDataSet.DataSetName = "MMABooksDataSet";
            this.mMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTotalTextBox
            // 
            this.productTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "ProductTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.productTotalTextBox.Location = new System.Drawing.Point(111, 60);
            this.productTotalTextBox.Name = "productTotalTextBox";
            this.productTotalTextBox.ReadOnly = true;
            this.productTotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.productTotalTextBox.TabIndex = 5;
            this.productTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "SalesTax", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.salesTaxTextBox.Location = new System.Drawing.Point(111, 86);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(200, 20);
            this.salesTaxTextBox.TabIndex = 7;
            this.salesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // shippingTextBox
            // 
            this.shippingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Shipping", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.shippingTextBox.Location = new System.Drawing.Point(111, 112);
            this.shippingTextBox.Name = "shippingTextBox";
            this.shippingTextBox.ReadOnly = true;
            this.shippingTextBox.Size = new System.Drawing.Size(200, 20);
            this.shippingTextBox.TabIndex = 9;
            this.shippingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // invoiceTotalTextBox
            // 
            this.invoiceTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.invoiceTotalTextBox.Location = new System.Drawing.Point(111, 138);
            this.invoiceTotalTextBox.Name = "invoiceTotalTextBox";
            this.invoiceTotalTextBox.ReadOnly = true;
            this.invoiceTotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoiceTotalTextBox.TabIndex = 11;
            this.invoiceTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fillByInvoiceIDToolStrip
            // 
            this.fillByInvoiceIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceIDToolStripLabel,
            this.invoiceIDToolStripTextBox,
            this.fillByInvoiceIDToolStripButton});
            this.fillByInvoiceIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByInvoiceIDToolStrip.Name = "fillByInvoiceIDToolStrip";
            this.fillByInvoiceIDToolStrip.Size = new System.Drawing.Size(547, 25);
            this.fillByInvoiceIDToolStrip.TabIndex = 12;
            this.fillByInvoiceIDToolStrip.Text = "fillByInvoiceIDToolStrip";
            // 
            // invoiceIDToolStripLabel
            // 
            this.invoiceIDToolStripLabel.Name = "invoiceIDToolStripLabel";
            this.invoiceIDToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.invoiceIDToolStripLabel.Text = "InvoiceID:";
            // 
            // invoiceIDToolStripTextBox
            // 
            this.invoiceIDToolStripTextBox.Name = "invoiceIDToolStripTextBox";
            this.invoiceIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.invoiceIDToolStripTextBox.Click += new System.EventHandler(this.invoiceIDToolStripTextBox_Click);
            // 
            // fillByInvoiceIDToolStripButton
            // 
            this.fillByInvoiceIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByInvoiceIDToolStripButton.Name = "fillByInvoiceIDToolStripButton";
            this.fillByInvoiceIDToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.fillByInvoiceIDToolStripButton.Text = "Get Invoice";
            this.fillByInvoiceIDToolStripButton.Click += new System.EventHandler(this.fillByInvoiceIDToolStripButton_Click);
            // 
            // invoiceLineItemsDataGridView
            // 
            this.invoiceLineItemsDataGridView.AllowUserToAddRows = false;
            this.invoiceLineItemsDataGridView.AllowUserToDeleteRows = false;
            this.invoiceLineItemsDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.invoiceLineItemsDataGridView.DataSource = this.invoiceLineItemsBindingSource;
            this.invoiceLineItemsDataGridView.Location = new System.Drawing.Point(34, 183);
            this.invoiceLineItemsDataGridView.Name = "invoiceLineItemsDataGridView";
            this.invoiceLineItemsDataGridView.ReadOnly = true;
            this.invoiceLineItemsDataGridView.Size = new System.Drawing.Size(473, 214);
            this.invoiceLineItemsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "ItemTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "InvoiceLineItems";
            this.invoiceLineItemsBindingSource.DataSource = this.mMABooksDataSet;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceLineItemsTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = InvoiceLineItems.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoiceLineItemsTableAdapter
            // 
            this.invoiceLineItemsTableAdapter.ClearBeforeFill = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 437);
            this.Controls.Add(this.invoiceLineItemsDataGridView);
            this.Controls.Add(this.fillByInvoiceIDToolStrip);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(productTotalLabel);
            this.Controls.Add(this.productTotalTextBox);
            this.Controls.Add(salesTaxLabel);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(shippingLabel);
            this.Controls.Add(this.shippingTextBox);
            this.Controls.Add(invoiceTotalLabel);
            this.Controls.Add(this.invoiceTotalTextBox);
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMABooksDataSet)).EndInit();
            this.fillByInvoiceIDToolStrip.ResumeLayout(false);
            this.fillByInvoiceIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMABooksDataSet mMABooksDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private MMABooksDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private MMABooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.TextBox productTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox shippingTextBox;
        private System.Windows.Forms.TextBox invoiceTotalTextBox;
        private System.Windows.Forms.ToolStrip fillByInvoiceIDToolStrip;
        private System.Windows.Forms.ToolStripLabel invoiceIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox invoiceIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByInvoiceIDToolStripButton;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter invoiceLineItemsTableAdapter;
        private System.Windows.Forms.DataGridView invoiceLineItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

