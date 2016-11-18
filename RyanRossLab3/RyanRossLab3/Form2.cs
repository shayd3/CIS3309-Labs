using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanRossLab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int change = Convert.ToInt32(txtChangeDue.Text);
            txtQuarters.Text = "0";
            txtDimes.Text = "0";
            txtNickels.Text = "0";
            txtPennies.Text = "0";

            if (change >= 25)
                {
                    txtQuarters.Text = ((int)change / 25).ToString();
                    change = (int)change % 25;
                }
            if (change >= 10) {
                    txtDimes.Text = ((int)change / 10).ToString();
                    change = (int)change % 10;
                }
            if (change >= 5){
                    txtNickels.Text = ((int)change / 5).ToString();
                    change = (int)change % 5;
            }
            if (change >= 1){
                    txtPennies.Text = ((int)change / 1).ToString();
                    change = (int)change % 1;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
