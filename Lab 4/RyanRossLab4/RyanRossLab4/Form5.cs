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
    public partial class Form5 : Form
    {
        decimal addOnPrice = .75m;
        decimal coursePrice = 6.95m;
        public Form5()
        {
            InitializeComponent();
        }

        public void clearTotals()
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        public void clearAddOns()
        {
            check1.Checked = false;
            check2.Checked = false;
            check3.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if(radioHamburger.Checked == true)
            {
                clearAddOns();
                clearTotals();
                addOnPrice = 0.75m;
                coursePrice = 6.95m;

                groupBox2.Text = "Add-on items ($.75/each)";
                check1.Text = "Lettuce, tomato, and onions";
                check2.Text = "Ketchup, mustard, and mayo";
                check3.Text = "French fries";
            }
        }

        private void radioPizza_CheckedChanged(object sender, EventArgs e)
        {
            if(radioPizza.Checked == true)
            {
                clearAddOns();
                clearTotals();
                addOnPrice = 0.50m;
                coursePrice = 5.95m;

                groupBox2.Text = "Add-on items ($.50/each)";
                check1.Text = "Pepperoni";
                check2.Text = "Sausage";
                check3.Text = "Olives";
            }
        }

        private void radioSalad_CheckedChanged(object sender, EventArgs e)
        {
            if(radioSalad.Checked == true)
            {
                clearAddOns();
                clearTotals();
                addOnPrice = 0.25m;
                coursePrice = 4.95m;

                groupBox2.Text = "Add-on items ($.25/each)";

                check1.Text = "Croutons";
                check2.Text = "Bacon bits";
                check3.Text = "Bread sticks";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            decimal totalAddOn = 0.00m;

            if(check1.Checked == true)
            {
                totalAddOn = totalAddOn + addOnPrice;
            }
            if (check2.Checked == true)
            {
                totalAddOn = totalAddOn + addOnPrice;
            }
            if (check3.Checked == true)
            {
                totalAddOn = totalAddOn + addOnPrice;
            }

            decimal subTotal = coursePrice + totalAddOn;
            string sub = String.Format("{0:C}", subTotal);
            txtSubtotal.Text = sub;

            decimal tax = subTotal * .00775m;
            tax = tax * 10;
            string taxString = String.Format("{0:C}", tax);
            txtTax.Text = taxString;

            decimal orderPrice = subTotal + tax;
            string orderPriceString = String.Format("{0:C}", orderPrice);
            txtTotal.Text = orderPriceString;
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals();
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals();
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            frmInvoiceTotal frm = new frmInvoiceTotal();
            frm.Show();
        }
    }
}
