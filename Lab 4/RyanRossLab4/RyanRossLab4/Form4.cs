using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanRossLab4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {
            {"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
            {"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
            {"Feet to meters", "Feet", "Meters", "0.3048"},
            {"Meters to feet", "Meters", "Feet", "3.2808"},
            {"Inches to centimeters", "Inches", "Centimeters", "2.54"},
            {"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
        };

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsPresent(txtFromValue, lblBeforeConversion.Text) && IsDecimal(txtFromValue, txtFromValue.Text))
            {
                int index = boxConversion.SelectedIndex; // i value (selects row) j = 3;
                int j = 3;
                decimal fromValue = Convert.ToDecimal(txtFromValue.Text);
                decimal conversionValue = Convert.ToDecimal(conversionTable[index, j]);

                decimal calculatedValue = conversionValue * fromValue;
                lblToValue.Text = calculatedValue.ToString();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblCalculatedLength_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i < 6; i++)
            {
                boxConversion.Items.Add(conversionTable[i,j]);
            }
            
        }

        private void boxConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblToValue.Text = "";

            switch (boxConversion.SelectedIndex) {
                case 0:
                    lblBeforeConversion.Text = conversionTable[0, 1] + ":";
                    lblAfterConversion.Text = conversionTable[0, 2] + ":";
                    txtFromValue.Focus();
                    break;
                case 1:
                    lblBeforeConversion.Text = conversionTable[1, 1] + ":";
                    lblAfterConversion.Text = conversionTable[1, 2] + ":";
                    txtFromValue.Focus();
                    break;
                case 2:
                    lblBeforeConversion.Text = conversionTable[2,1] + ":";
                    lblAfterConversion.Text = conversionTable[2, 2] + ":";
                    txtFromValue.Focus();
                    break;
                case 3:
                    lblBeforeConversion.Text = conversionTable[3,1] + ":";
                    lblAfterConversion.Text = conversionTable[3, 2] + ":";
                    txtFromValue.Focus();
                    break;
                case 4:
                    lblBeforeConversion.Text = conversionTable[4,1] + ":";
                    lblAfterConversion.Text = conversionTable[4, 2] + ":";
                    txtFromValue.Focus();
                    break;
                case 5:
                    lblBeforeConversion.Text = conversionTable[5,1] + ":";
                    lblAfterConversion.Text = conversionTable[5, 2] + ":";
                    txtFromValue.Focus();
                    break;
            }
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }
    }
}
