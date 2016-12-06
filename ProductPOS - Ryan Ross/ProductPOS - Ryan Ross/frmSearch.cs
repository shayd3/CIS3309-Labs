using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPOS___Ryan_Ross
{
    public partial class frmSearch : Form
    {
        Product[] pArr = null;

        public frmSearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Text = "Search";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "" && btnSearch.Text == "Search"){
                lstSearch.Items.Clear();
                pArr = ProductDB.SelectLikeDesc(txtSearch.Text);
                if(pArr != null)
                {
                    foreach (Product product in pArr)
                    {
                        if(product != null){
                            lstSearch.Items.Add(product.ToString());
                            btnSearch.Text = "Copy ID to POS";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Records Found");
                }
            } else if (btnSearch.Text == "Copy ID to POS")
            {
                if(lstSearch.SelectedIndex >= 0)
                {
                    Tag = this.pArr[lstSearch.SelectedIndex];
                    this.Close();
                } else
                {
                    MessageBox.Show("No item selected. Please select an item in the list box.");
                }
            } else
            {
                return;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.pArr = null;
            this.Tag = this.pArr;
            this.Close();
        }
    }
}
