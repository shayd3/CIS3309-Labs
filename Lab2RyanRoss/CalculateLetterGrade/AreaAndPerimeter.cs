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
    public partial class AreaAndPerimeter : Form
    {
        public AreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal length = Convert.ToDecimal(textLength.Text);
            decimal width = Convert.ToDecimal(textWidth.Text);

            string area = Convert.ToString(length * width);
            string perimeter =Convert.ToString((2 * length) + (2 * width));
            textArea.Text = area;
            textPerimeter.Text = perimeter;

            textLength.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScoreCalc_Click(object sender, EventArgs e)
        {
            ScoreCalculator frm = new ScoreCalculator();
            frm.Show();
        }
    }
}
