using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Matrix A, B, C;

        

        private void btnCreateMatrixA_Click(object sender, EventArgs e)
        {
            try
            {
                A = new Matrix(Convert.ToInt32(txtMatrixARows.Text), Convert.ToInt32(txtMatrixACols.Text));
                txtFullMatrixA.Text = A.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show("Invalid Rows/Cols entry for Matrix A. Please enter in valid integers.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtFullMatrixC.Clear();
            C = null;

            if (radioAdd.Checked == true) //Addition
            {
                if (A.dimsEqual(B))
                {
                    C = A + B;
                    txtFullMatrixC.Text = C.ToString();
                } else
                {
                    MessageBox.Show("ERROR: Matrix A and Matrix B are not equal. Unable to add Matricies.");
                }
            } 

            if (radioSubtract.Checked == true) //Subtraction
            {
                if (A.dimsEqual(B))
                {
                    C = A - B;
                    txtFullMatrixC.Text = C.ToString();
                }
                else
                {
                    MessageBox.Show("ERROR: Matrix A and Matrix B are not equal. Unable to subtract Matricies.");
                }
            }

            if (radioMultiply.Checked == true) //Multiplication
            {
                if ((A.Rows == B.Cols) && (A.Cols == B.Rows))
                {
                    C = A * B;
                    txtFullMatrixC.Text = C.ToString();
                }
                else
                {
                    MessageBox.Show("ERROR: Matrix A Rows do not equal Matrix B Cols OR Matrix A Cols do not equal Matrix B Rows. Unable to multiply Matricies.");
                }
            }

            if(radioAEqualsB.Checked == true) //A==B
            {
                if (A == B)
                {
                    txtFullMatrixC.Text = "A is equal to B";
                } else
                {
                    txtFullMatrixC.Text = "A is not equal to B";
                }
            }
        }

        private void txtMatrixBRows_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            A = new Matrix();
            B = new Matrix();
            C = new Matrix();
            txtMatrixACols.Clear();
            txtMatrixARows.Clear();
            txtMatrixBCols.Clear();
            txtMatrixBRows.Clear();
            txtFullMatrixA.Clear();
            txtFullMatrixB.Clear();
            txtFullMatrixC.Clear();
            txtMatrixARows.Focus();

        }

        private void btnMakeBIdentity_Click(object sender, EventArgs e)
        {
            int numRows = 0, numCols = 0;
            try
            {
                numRows = Convert.ToInt32(txtMatrixBRows.Text);
                numCols = Convert.ToInt32(txtMatrixBCols.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("ERROR: Be sure to enter in valid integers for Matrix B's rows and cols.");
            }
            if(numRows == numCols) {
                B = Matrix.makeID(numRows);
                txtFullMatrixB.Text = B.ToString();
            } else
            {
                MessageBox.Show("ERROR: Be sure rows and cols for Matrix B are the same.");
            }
        }

        private void btnBCopyOfA_Click(object sender, EventArgs e)
        {
            B = B.clone(A);
            txtFullMatrixB.Text = B.ToString();
        }

        private void btnCreateMatrixB_Click(object sender, EventArgs e)
        {
            try
            {
                B = new Matrix(Convert.ToInt32(txtMatrixBRows.Text), Convert.ToInt32(txtMatrixBCols.Text));
                txtFullMatrixB.Text = B.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Rows/Cols entry for Matrix B. Please enter in valid integers.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioMultiply.Checked = true;
            A = new Matrix();
            B = new Matrix();
            C = new Matrix();

            txtMatrixACols.Text = 3 + "";
            txtMatrixARows.Text = 3 + "";
            txtMatrixBCols.Text = 3 + "";
            txtMatrixBRows.Text = 3 + "";
        }
    }
}
