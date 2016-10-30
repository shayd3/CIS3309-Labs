using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2
{
    class Matrix
    {
        double[,] matrix = null;
        readonly int cols;
        readonly int rows;

        public Matrix() { }

        public Matrix(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;

            matrix = new double[rows, cols];

            populateRand();
        }

        /*
         * Indexer
         */
        public double this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }


        /*
         * READONLY Rows/cols
         */
        public int Rows
        {
            get
            {
                return rows;
            }
        }
        
        public int Cols
        {
            get
            {
                return cols;
            }
        }


        /*
         * Operation Methods
         */ 
        private Matrix Add(Matrix B)
        {
            Matrix matrixC = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixC[i, j] = this[i, j] + B[i, j];
                }
            }

            return matrixC;
        }

        private Matrix Subtract(Matrix B)
        {
            Matrix matrixC = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    matrixC[i, j] = this[i, j] - B[i, j];
                }
            }
            return matrixC;
        }

        private Matrix Multiply(Matrix B)
        {
            Matrix matrixC = new Matrix(this.rows, B.cols);

            for (int i = 0; i < matrixC.rows; i++)
            {
                for (int j = 0; j < matrixC.cols; j++)
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < this.cols; k++)
                    {
                        matrixC[i, j] = matrixC[i, j] + this[i, k] * B[k, j];
                    }
                }
            }

            return matrixC;

        }


        /*
         * Equals methods
         */
        public bool colsEqual(Matrix B)
        {
            if(this.cols == B.cols)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool rowsEqual(Matrix B)
        {
            if(this.rows == B.rows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool dimsEqual(Matrix B)
        {
            return (rowsEqual(B) && colsEqual(B));
        }


        /*
         * Override Methods
         */

        public override bool Equals(object obj)
        {
            Matrix mat = (Matrix)obj;

            for(int i = 0; i< Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    if (mat[i, j] != matrix[i, j])
                        return false;
                }
            }

            return true; 
        }

        public static bool operator ==(Matrix matrixA, Matrix matrixB)
        {

            for (int i = 0; i < matrixA.Rows; i++)
            {
                for (int j = 0; j < matrixA.Cols; j++)
                {
                    if (matrixA[i, j] != matrixB[i, j])
                        return false;
                }
            }
            return true;


        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }

        public override int GetHashCode()
        {
            return sum().GetHashCode();
        }

        public double sum()
        {
            double total = 0.0;
            for(int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                    total += matrix[i, j];
            }
            return total;
        }

        //---------------------


        /*
         * Operator Override
         */
        public static Matrix operator +(Matrix matrixA, Matrix matrixB)
        {
            return matrixA.Add(matrixB);
        }

        public static Matrix operator -(Matrix matrixA, Matrix matrixB)
        {

            return matrixA.Subtract(matrixB);
        }
        public static Matrix operator *(Matrix matrixA, Matrix matrixB)
        {

            return matrixA.Multiply(matrixB);
        }
        //---------------------


        public static Matrix makeID(int equalDim)
        {
            Matrix matrix = new Matrix(equalDim, equalDim);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for(int j = 0; j < matrix.Cols; j++)
                {
                    if (j == i)
                    {
                        matrix[i, i] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        public Matrix clone(Matrix copy)
        {
            Matrix matrix = new Matrix(copy.Rows, copy.Cols);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for(int j = 0; j < matrix.Cols; j++)
                {
                    matrix[i, j] = copy[i, j];
                }
            }
            return matrix;
        }

        public void copy(Matrix B)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    this[i, j] = B[i, j];
                }
            }
        }

        public void populateRand()
        {
            Random rand = new Random();

            for(int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrix[i, j] = rand.NextDouble() * 10;
                }
            }
        }

        public void populateOrd()
        {
            double value = 1.0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrix[i, j] = value;
                    value += 1.0;
                }
            }
        }

        public override string ToString()
        {
            string matrixString = "";
            
            for(int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrixString += String.Format("{0:0.0}", matrix[i, j]) + "\t";
                }
                matrixString += Environment.NewLine;
            }

            return matrixString;
        }
    }
}
