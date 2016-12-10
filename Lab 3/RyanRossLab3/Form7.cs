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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                string operator1 = txtOperator.Text;
                decimal result = calculate(operand1, operator1, operand2);
                txtResult.Text = Math.Round(result, 4).ToString();
                txtOperand1.Focus();
            } catch (FormatException)
            {
                MessageBox.Show("FormatException error has occured. Please check your fields");
            } catch (OverflowException)
            {
                MessageBox.Show("Overflow Exception error has occured. Enter in smaller values");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("DivideByZeroException error has occured. Please enter in a number other than 0 for Operand2");
            }
        }
        private decimal calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
            {
                result = operand1 + operand2;
            }
            else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }
            else if (operator1 == "*")
            {
                result = operand1 * operand2;
            }
            else if (operator1 == "/")
            {
                result = operand1 / operand2;
            }

            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();

        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();

        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();

        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
        }
    }
}
