using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixOps
{

    //Questions to ask: 1. How do I get whole numbers to have a decimal place so: 1 is 1.0, 0 is 0.0 etc.
    public partial class matrixOps : Form
    {
        int matrixARows = 3;
        int matrixACols = 3;
        int matrixBRows = 3;
        int matrixBCols = 3;
        double[,] matrixB;
        double[,] matrixA;
        double[,] matrixC;
        string op = "*";


        public matrixOps()
        {
            InitializeComponent();
        }

        private void btnCreateMatrixA_Click(object sender, EventArgs e)
        {
            try
            {
                matrixARows = Convert.ToInt32(txtMatrixARows.Text);
                matrixACols = Convert.ToInt32(txtMatrixACols.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the textboxes for Matrix A's rows and columns. Be sure you are inputing a valid integer.");
            }

            matrixA = createMatrix(matrixARows, matrixACols);
            matrixToString(matrixA, txtFullMatrixA);

        }

        private void btnCreateMatrixB_Click(object sender, EventArgs e)
        {
            try
            {
                matrixBRows = Convert.ToInt32(txtMatrixBRows.Text);
                matrixBCols = Convert.ToInt32(txtMatrixBCols.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the textboxes for Matrix B's rows and columns. Be sure you are inputing a valid integer.");
            }

            matrixB = createMatrix(matrixBRows, matrixBCols);
            matrixToString(matrixB, txtFullMatrixB);


        }

        /*
         * Converts inputted matrix to string and displays to Textbox
         */
        private void matrixToString(double[,] matrix, TextBox textBox)
        {
            string matrixString = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixString += matrix[i, j].ToString();
                    matrixString += "\t";
                }
                matrixString += Environment.NewLine;
            }
            textBox.Text = matrixString;
        }

        private double[,] IdentityMatrix(int n)
        {
            double[,] result = createMatrix(n, n);
            for (int i = 0; i < n; ++i)
            {
                result[i, i] = 1.00;
                for (int j = 0; j < n; ++j)
                {
                    if (j != i)
                    {
                        result[i, j] = 0.00;
                    }
                }
            }
            return result;
        }


        /*
         * Rounds inputted double numbers to given precision
         */
        private static double round(double value, int precision)
        {
            int scale = (int)Math.Pow(10, precision);
            return (double)Math.Round(value * scale) / scale;
        }


        /*
         * Creates a matrix that populates with random double numbers
         */
        private double[,] createMatrix(int rows, int cols)
        {
            Random random = new Random();

            double[,] randMatrix = new double[rows, cols];

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    double value = random.NextDouble()*10;
                    randMatrix[i, j] = round(value, 1);
                }
            }
            return randMatrix;
        }

        private void matrixOps_Load(object sender, EventArgs e)
        {
            txtMatrixACols.Text = "3";
            txtMatrixARows.Text = "3";
            txtMatrixBCols.Text = "3";
            txtMatrixBRows.Text = "3";
            radioMultiply.Checked = true;
            txtMatrixARows.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeBIdentity_Click(object sender, EventArgs e)
        {
            double[,] identityMatrixB = new double[matrixBRows, matrixBCols];
            if (matrixBRows == matrixBCols)
            {
                identityMatrixB = IdentityMatrix(matrixBRows);
                matrixB = identityMatrixB;
            }
            else
            {
                MessageBox.Show("Rows and Columns must be the same length in order to create an identity matrix.");
            }


            matrixToString(matrixB, txtFullMatrixB);
        }

        private void radioMultiply_CheckedChanged(object sender, EventArgs e)
        {
            op = "*";
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            op = "+";
        }

        private void radioSubtract_CheckedChanged(object sender, EventArgs e)
        {
            op = "-";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if ((matrixA.GetLength(0) != 0) && (matrixA.GetLength(1) != 0) && (matrixB.GetLength(0) != 0) &&(matrixB.GetLength(1) != 0))
            {
                if (op == "*") // If multiply is checked
                {
                    if((matrixARows == matrixBCols) &&(matrixACols == matrixBRows))
                    {
                        matrixC = new double[matrixARows, matrixBCols];
                        for (int i = 0; i < matrixC.GetLength(0); ++i)
                        {
                            for(int j = 0; j< matrixC.GetLength(1); ++j)
                            {
                                matrixC[i, j] = 0;
                                for (int k = 0; k < matrixA.GetLength(1); ++k)
                                {
                                    matrixC[i, j] = matrixC[i, j] + matrixA[i, k] * matrixB[k, j];
                                }

                            }
                        }
                        matrixToString(matrixC, txtFullMatrixC);
                    } else
                    {
                        MessageBox.Show("Rows of Matrix A must match Cols of B, and Cols of A must match Rows of B.");
                    }

                }
                else
                if (op == "+")// If Add is checked
                {
                    if((matrixACols == matrixBCols) && (matrixARows == matrixBRows)){
                        matrixC = new double[matrixARows, matrixACols];
                        for (int i = 0; i < matrixC.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixC.GetLength(1); j++)
                            {
                                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                            }
                        }
                        matrixToString(matrixC, txtFullMatrixC);
                    } else
                    {
                        MessageBox.Show("Both matrix A and B must be the same dimensions to add them together.");
                    }
                }
                else
                if (op == "-")// if Subtract is checked
                {
                    if ((matrixACols == matrixBCols) && (matrixARows == matrixBRows))
                    {
                        matrixC = new double[matrixARows, matrixACols];
                        for (int i = 0; i < matrixC.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrixC.GetLength(1); j++)
                            {
                                matrixC[i, j] = matrixA[i, j] - matrixB[i, j];
                            }
                        }
                        matrixToString(matrixC, txtFullMatrixC);
                    }
                    else
                    {
                        MessageBox.Show("Both matrix A and B must be the same dimensions to subtract from each other.");
                    }
                }
            } else
            {
                MessageBox.Show("Be sure you have created both Matrix A and Matrix B!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            matrixARows = 0;
            matrixACols = 0;
            matrixBRows = 0;
            matrixBCols = 0;
            matrixB = new double[0, 0];
            matrixA = new double[0, 0];
            matrixC = new double[0, 0];
            txtFullMatrixA.Clear();
            txtFullMatrixB.Clear();
            txtFullMatrixC.Clear();
            txtMatrixACols.Clear();
            txtMatrixARows.Clear();
            txtMatrixBCols.Clear();
            txtMatrixBRows.Clear();
            txtMatrixARows.Focus();
            radioMultiply.Checked = true;
        }
    }
}
