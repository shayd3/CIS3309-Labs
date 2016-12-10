using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyanRossLab4
{
    public partial class Form2 : Form
    {
        const int PRICE_PER_NIGHT = 140;

        public Form2()
        {
            InitializeComponent();
        }

        public bool IsValidData()
        {
         return
                 //chcecks for present, dateTime, within range for arrival and departure
                 IsPresent(txtArrivalDate, "Arrival Date") &&
                 IsDateTime(txtArrivalDate, "Arrival Date") &&
                 IsWithinRange(txtArrivalDate, "Arrival date", DateTime.Today, DateTime.Today.AddYears(5)) &&
                 IsPresent(txtDepartDate, "Depart Date") &&
                 IsDateTime(txtDepartDate, "Depart Date") &&
                 IsWithinRange(txtDepartDate, "Depart date", DateTime.Today, DateTime.Today.AddYears(5));
        }

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

        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime validDate = Convert.ToDateTime(textBox.Text);
            if(string.IsNullOrEmpty(textBox.Text) || !DateTime.TryParse(textBox.Text, out validDate))
            {
                MessageBox.Show(name + " Invalid Date", "Entry Error");
                textBox.Focus();
                return false;
            } else
            {
                return true;
            }

        }

        public bool IsWithinRange(TextBox textBox, string name,
            DateTime min, DateTime max)
        {
            DateTime arrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
            DateTime departDate = Convert.ToDateTime(txtDepartDate.Text);
            if ((arrivalDate < min) || (arrivalDate > max))
            {
                MessageBox.Show(arrivalDate.ToShortDateString() + " must be entered in mm/dd/yyyy format and be from today to 5 years from today's date");
                txtArrivalDate.Focus();
                return false;
            }
            if ((departDate < min) || (departDate > max))
            {
                MessageBox.Show(departDate.ToShortDateString() + " must be entered in mm/dd/yyyy format and be from today to 5 years from today's date");
                txtDepartDate.Focus();
                return false;
            }
            return true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsValidData())
                {
                    DateTime arrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
                    DateTime departDate = Convert.ToDateTime(txtDepartDate.Text);

                    // Difference in days, hours, and minutes.
                    TimeSpan ts = departDate - arrivalDate;

                    // Difference in days.
                    int differenceInDays = ts.Days;
                    int totalPrice = 0;

                    while (arrivalDate.ToShortDateString() != departDate.ToShortDateString())
                    {
                        if (arrivalDate.DayOfWeek.ToString() == Day.Friday.ToString() || arrivalDate.DayOfWeek.ToString() == Day.Saturday.ToString())
                        {
                            totalPrice = totalPrice + 150;
                        }
                        else
                        {
                            totalPrice = totalPrice + 120;
                        }
                        arrivalDate = arrivalDate.AddDays(1);
                    }

                    txtNumOfNights.Text = Convert.ToString(differenceInDays);

                    txtTotalPrice.Text = Convert.ToString("$" + totalPrice + ".00");


                    txtAvgPrice.Text = Convert.ToString("$" + PRICE_PER_NIGHT + ".00");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/n" + e.GetType().ToString() + ex.StackTrace, "Exception");

            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txtArrivalDate.Text = now.ToShortDateString();
            DateTime departDate = now.AddDays(3);
            txtDepartDate.Text = departDate.ToShortDateString();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
