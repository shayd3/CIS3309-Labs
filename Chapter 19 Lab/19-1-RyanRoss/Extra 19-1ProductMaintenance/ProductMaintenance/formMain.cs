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

namespace ProductMaintenance
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }



        private void fillByProductCodeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillByProductCode(this.mMABooksDataSet.Products, productCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButtonGetAllProduct_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void productCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
