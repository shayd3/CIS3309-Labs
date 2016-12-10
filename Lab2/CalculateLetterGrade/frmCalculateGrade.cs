using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            string letterGrade = "";

            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            } else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            } else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            } else
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;

            txtNumberGrade.Focus();
        }

        private void frmCalculateGrade_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAreaPerim_Click(object sender, EventArgs e)
        {
            AreaAndPerimeter frm = new AreaAndPerimeter();
            frm.Show();
        }
    }
}
