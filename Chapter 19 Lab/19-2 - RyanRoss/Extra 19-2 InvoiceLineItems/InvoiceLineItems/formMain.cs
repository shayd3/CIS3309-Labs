using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvoiceLineItems
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void fillByInvoiceIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoicesTableAdapter.FillByInvoiceID(this.mMABooksDataSet.Invoices, ((int)(System.Convert.ChangeType(invoiceIDToolStripTextBox.Text, typeof(int)))));
                this.invoiceLineItemsTableAdapter.FillByInvoiceID(this.mMABooksDataSet.InvoiceLineItems, ((int)(System.Convert.ChangeType(invoiceIDToolStripTextBox.Text, typeof(int)))));
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void invoiceIDToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
