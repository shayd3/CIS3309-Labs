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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.IndexOf('@') != -1) {
                String email = txtEmail.Text;
                email = email.Replace(" ", "");
                String[] parts = email.Split(new[] { '@' });
                String username = parts[0]; // "ryan"
                String domain = parts[1]; // "example.com"
                MessageBox.Show("User name: " + username + "\nDomain Name: " + domain);
            } else
            {
                MessageBox.Show(txtEmail.Text + " is not a valid email. Please enter a valid email (i.e. me@example.com)");
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            String state = txtState.Text.ToUpper();
            String city = txtCity.Text;
            String zip = txtZip.Text;

            MessageBox.Show(insert(state, city, zip));
        }

        public String insert(String state, String city, String zip)
        {
            String address = "City, State, Zip: "+ city +", " + state + " " + zip;
            return address;
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
