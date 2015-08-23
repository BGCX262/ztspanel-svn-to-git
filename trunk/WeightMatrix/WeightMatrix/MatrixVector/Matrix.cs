using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeightMatrix
{
    public class Matrix
    {

        // Variabel yang digunakan untuk menampung data matriks
        private double[,] data;
        private int cols, rows;

        #region Constructor

        // Jumlah baris dan kolom harus ditentukan terlebih dahulu
        public Matrix(int rows, int cols)
        {
            if (cols > 0 && rows > 0)
            {
                this.cols = Math.Max(1, cols); //nilai minimal 1
                this.rows = Math.Max(1, rows);
                this.data = new double[this.rows, this.cols];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Matrix.Cols || Matrix.Rows", "Only positive number valid");
            }
        }


        // Nilai elemen matriks diisi dengan nilai array yang dimasukkan.
        // Ukuran array (jumlah baris dan kolom) harus sama dengan ukuran matriks
        public Matrix(double[,] data, int rows, int cols)
        {
            if (cols > 0 && rows > 0)
            {
                this.cols = Math.Max(1, cols); //nilai minimal 1
                this.rows = Math.Max(1, rows);
                this.data = new double[this.rows, this.cols];
                this.data = (double[,])data.Clone();
            }
            else
            {
                throw new ArgumentOutOfRangeException("Matrix.Cols || Matrix.Rows", "Only positive number valid");
            }
        }


        // Mengeset semua elemen array dengan nilai tertentu
        // Digunakan untuk membuat matriks dengan semua nilai elemen sama
        public void InitializeAllValue(double value)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    data[i, j] = value;
        }

        #endregion

        #region Properties Member

        // Mendapatkan jumlah baris dari matriks
        public int Rows
        {
            get { return this.rows; }
        }

        // Mendapatkan jumlah kolom dari matriks
        public int Cols
        {
            get { return this.cols; }
        }

        // Mendapatkan atau mengeset nilai suatu elemen matriks
        public double this[int row, int col]
        {
            get { return this.data[row, col]; }
            set { this.data[row, col] = value; }
        }

        // Mendapatkan array satu dimensi yang berisi nilai elemen
        // matriks pada baris tertentu.
        public double[] GetRowData(int row)
        {
            double[] result = new double[this.cols];
            for (int i = 0; i < this.cols; i++)
            {
                result[i] = this.data[row, i];
            }
            return result;
        }

        // Mendapatkan array satu dimensi yang berisi nilai elemen kuadrat
        // matriks pada baris tertentu.
        public double[] GetRowDataSquare(int row)
        {
            double[] result = new double[this.cols];
            for (int i = 0; i < this.cols; i++)
            {
                result[i] = this.data[row, i] * this.data[row, i];
            }
            return result;
        }

        // Mendapatkan array satu dimensi yang berisi nilai elemen
        // matriks pada kolom tertentu.
        public double[] GetColData(int col)
        {
            double[] result = new double[this.rows];
            for (int i = 0; i < this.rows; i++)
            {
                result[i] = this.data[i, col];
            }
            return result;
        }

        // Mendapatkan array satu dimensi yang berisi nilai elemen kuadrat
        // matriks pada kolom tertentu.
        public double[] GetColDataSquare(int col)
        {
            double[] result = new double[this.rows];
            for (int i = 0; i < this.rows; i++)
            {
                result[i] = this.data[i, col] * this.data[i, col]; ;
            }
            return result;
        }

        // Mendapatkan array satu dimensi yang berisi jumlah data dari         
        // matriks pada seluruh kolom.
        public double[] GetSumColData()
        {
            double[] result = new double[this.cols];
            for (int i = 0; i < this.cols; i++)
            {
                result[i] = 0;
                for (int j = 0; j <= this.rows; j++)
                {
                    result[i] += this.data[i, j];
                }
            }
            return result;
        }

        // Mendapatkan array dua dimensi yang berisi nilai elemen matrix
        public double[,] GetData()
        {
            return this.data;
        }

        // Mendapatkan copy dari matriks
        public Matrix Copy()
        {
            Matrix result = new Matrix(rows, cols);

            for (int i = 0; i < result.rows; i++)
                for (int j = 0; j < result.cols; j++)
                    result[i, j] = data[i, j];

            return result;
        }

        // Mendapatkan matriks transpose
        public Matrix GetTranspose()
        {
            Matrix result = new Matrix(cols, rows);

            for (int i = 0; i < result.rows; i++)
                for (int j = 0; j < result.cols; j++)
                    result[i, j] = data[j, i];

            return result;
        }

        #endregion

        #region Boolean Member

        // Apakah matriks persegi?
        public bool IsSquare()
        {
            bool result = false;
            if (this.cols == this.rows) result = true;
            return result;
        }

        // Apakah matriks diagonal?
        public bool IsDiagonal()
        {
            bool result = true;
            if (IsSquare())
            {
                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < this.rows; j++)
                    {
                        if (i != j && this.data[i, j] != 0.0D)
                        {
                            result = false;
                            break;
                        }
                    }
                    if (result == false) break;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }


        // Apakah matriks identitas?
        public bool IsIdentity()
        {
            bool result = true;
            if (IsDiagonal())
            {
                for (int i = 0; i < this.rows; i++)
                {
                    if (this.data[i, i] != 1.0D)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        // Apakah matriks singular? (determinan = 0)
        public bool IsSingular()
        {
            bool isSingular, detChange;
            Matrix L, U;
            Queue<int> sourceInterchange, destinationInterchange;

            this.getLUDecomposition(out L, out U, out detChange, out isSingular,
                out sourceInterchange, out destinationInterchange);

            return isSingular;
        }

        #endregion

        #region Gaussian Elimination

        // Melakukan pertukaran baris pada suatu matriks
        public void RowInterchange(int source, int destination)
        {
            double tmp;
            for (int i = 0; i < cols; i++)
            {
                tmp = data[source, i];
                data[source, i] = data[destination, i];
                data[destination, i] = tmp;
            }
        }

        // Melakukan pertukaran kolom pada suatu matriks
        public void ColInterchange(int source, int destination)
        {
            double tmp;
            for (int i = 0; i < rows; i++)
            {
                tmp = data[i, source];
                data[i, source] = data[i, destination];
                data[i, destination] = tmp;
            }
        }

        // Dekomposisi LU
        // Memecah matriks menjadi dua lower triangular dan upper triangular
        // L * U =A

        private void getLUDecomposition(out Matrix L, out Matrix U,
           out bool detChange, out bool isSingular,
           out Queue<int> sourceInterchange, out Queue<int> destinationInterchange)
        {
            Matrix LU = new Matrix(data, rows, cols);
            L = new Matrix(rows, cols);
            U = new Matrix(rows, cols);
            sourceInterchange = new Queue<int>();
            destinationInterchange = new Queue<int>();

            detChange = false;
            isSingular = false;

            int imax = 0;
            double amax;

            for (int i = 0; i < LU.Cols; i++)
            {
                imax = -1;
                amax = 0;

                // cari pivot maksimal
                for (int j = i; j < LU.Rows; j++)
                {
                    if (Math.Abs(LU[j, i]) > amax)
                    {
                        amax = Math.Abs(LU[j, i]);
                        imax = j;
                    }
                }

                if (amax == 0)
                {
                    // singular
                    isSingular = true;
                    //break;

                    // jika singular, proses dekomposisi berhenti,
                    // error akan dilempar oleh proses yang memanggil
                }
                else
                {
                    if (imax != i)
                    {
                        // row interchange
                        LU.RowInterchange(imax, i);
                        detChange = !detChange;

                        // rekam row interchange
                        sourceInterchange.Enqueue(imax);
                        destinationInterchange.Enqueue(i);
                    }

                    for (int j = i + 1; j < LU.Rows; j++)
                        LU[j, i] = LU[j, i] / LU[i, i];

                    for (int j = i + 1; j < LU.Rows; j++)
                        for (int k = i + 1; k < LU.Cols; k++)
                            LU[j, k] -= LU[j, i] * LU[i, k];
                }
            }

            // mengisi nilai matriks lower triangular
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < i; j++)
                    L[i, j] = LU[i, j];
            for (int i = 0; i < rows; i++)
                L[i, i] = 1.0;

            // mengisi nilai matriks upper triangular
            for (int i = 0; i < rows; i++)
                for (int j = i; j < cols; j++)
                    U[i, j] = LU[i, j];

        }

        // Mendapatkan nilai determinan untuk matriks persegi
        public double GetDeterminant()
        {
            if (this.IsSquare())
            {
                bool isSingular, detChange;
                Matrix L, U;
                double det = 1.0;
                Queue<int> sourceInterchange, destinationInterchange;

                this.getLUDecomposition(out L, out U, out detChange, out isSingular,
                    out sourceInterchange, out destinationInterchange);

                for (int i = 0; i < U.Rows; i++)
                {
                    det *= U[i, i];
                }

                if (detChange) det = -det;

                return det;
            }
            else
            {
                throw new NonSquareMatrixException();
            }
        }


        /// <summary>
        /// Memecahkan persamaan A * X = B
        /// dimana A adalah matriks ini (this)
        /// B adalah matriks input
        /// X adalah matriks yang dicari.
        /// Dilakukan dengan mendekomposisi A menjadi LU terlebih dahulu
        /// </summary>
        /// <param name="B">Matrix. Matriks input</param>
        /// <returns>Matrix. Matriks hasil</returns>
        public Matrix Solve(Matrix B)
        {
            if (!this.IsSquare())
                throw new NonSquareMatrixException();

            if (B.Rows != rows)
                throw new WrongMatrixSizeException();

            bool isSingular, detChange;
            Matrix L, U;
            Queue<int> sourceInterchange, destinationInterchange;

            this.getLUDecomposition(out L, out U, out detChange, out isSingular,
                out sourceInterchange, out destinationInterchange);

            while (sourceInterchange.Count > 0)
            {
                B.RowInterchange(sourceInterchange.Dequeue(), destinationInterchange.Dequeue());
            }

            if (isSingular)
                throw new SingularMatrixException();

            Matrix X = new Matrix(rows, B.Cols);
            Matrix Y = new Matrix(rows, B.Cols);


            // Memecahkan persamaan L*Y = B
            for (int i = 0; i < B.Cols; i++)
            {
                Y[0, i] = B[0, i] / L[0, 0];
                for (int j = 1; j < B.Rows; j++)
                {
                    Y[j, i] = B[j, i];
                    if (L[j, j] == 0)
                        break;
                    for (int k = 0; k < j; k++)
                    {
                        Y[j, i] -= Y[k, i] * L[j, k];
                    }
                    Y[j, i] /= L[j, j];
                }
            }

            // Memecahkan persamaan U*X = Y
            for (int i = B.Cols - 1; i >= 0; i--)
            {
                X[B.Rows - 1, i] = Y[B.Rows - 1, i] / U[B.Rows - 1, B.Rows - 1];
                for (int j = B.Rows - 2; j >= 0; j--)
                {
                    X[j, i] = Y[j, i];
                    if (U[j, j] == 0)
                        break;
                    for (int k = B.Rows - 1; k > j; k--)
                    {
                        X[j, i] -= X[k, i] * U[j, k];
                    }
                    X[j, i] /= U[j, j];
                }
            }

            return X;
        }

        /// <summary>
        /// Memecahkan persamaan A * X = B
        /// dimana A adalah matriks ini (this)
        /// B adalah vektor input
        /// X adalah vektor yang dicari.
        /// Dilakukan dengan mendekomposisi A menjadi LU terlebih dahulu
        /// </summary>
        /// <param name="B">Vector. Vektor input</param>
        /// <returns>Vector. Vektor hasil</returns>
        public Vector Solve(Vector B)
        {
            Matrix inp = new Matrix(B.Tuples, 1);
            Matrix outp = new Matrix(B.Tuples, 1);
            Vector result = new Vector(B.Tuples, Vector.VectorType.ColumnVector);

            if (B.Type == Vector.VectorType.RowVector)
                throw new WrongVectorTypeException("Only ColumnVector valid");

            for (int i = 0; i < B.Tuples; i++)
                inp[i, 0] = B[i];

            outp = this.Solve(inp);

            for (int i = 0; i < outp.Rows; i++)
                result[i] = outp[i, 0];

            return result;
        }


        // Mendapatkan invers dari matriks persegi
        // Hanya untuk matriks non singular.
        // Dilakukan dengan memecahkan persamaan A * A' = I

        public Matrix GetInverse()
        {
            if (this.IsSquare())
            {
                return this.Solve(Matrix.CreateIdentity(rows));
            }
            else
            {
                throw new NonSquareMatrixException();
            }
        }

        #endregion

        #region Static Member

        // Membuat matriks identitas dengan jumlah baris/kolom tertentu
        public static Matrix CreateIdentity(int n)
        {
            Matrix Identity = new Matrix(n, n);

            for (int i = 0; i < n; i++)
                Identity[i, i] = 1.0D;

            return Identity;
        }

        // Mengecek apakah dua matriks mempunyai ukuran sama
        public static bool IsSameSize(Matrix a, Matrix b)
        {
            bool result = false;
            if (a.Cols == b.Cols && a.Rows == b.Rows)
                result = true;
            return result;
        }

        //Mengecek apakah dua matriks memiliki baris yang sama
        public static bool IsSameRow(Matrix a, Matrix b)
        {
            bool result = false;
            if (a.Rows == b.Rows)
                result = true;
            return result;
        }

        // Mengecek apakah dua matriks dapat dilakukan operasi perkalian
        public static bool CanMultiply(Matrix a, Matrix b)
        {
            bool result = false;
            if (a.Cols == b.Rows)
                result = true;
            return result;
        }


        // Operator overloading. Operasi penjumlahan matriks
        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            if (Matrix.IsSameSize(a, b))
            {
                for (int i = 0; i < a.Rows; i++)
                    for (int j = 0; j < a.Cols; j++)
                        result[i, j] = a[i, j] + b[i, j];
            }
            else
            {
                throw new NotSameSizeMatrixException();
            }

            return result;
        }

        // Operator overloading. Operasi pengurangan matriks
        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            if (Matrix.IsSameSize(a, b))
            {
                for (int i = 0; i < a.Rows; i++)
                    for (int j = 0; j < a.Cols; j++)
                        result[i, j] = a[i, j] - b[i, j];
            }
            else
            {
                throw new NotSameSizeMatrixException();
            }

            return result;
        }

        // Operator overloading. Operasi perkalian matriks dengan konstanta
        public static Matrix operator *(double constant, Matrix a)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Cols; j++)
                    result[i, j] = constant * a[i, j];

            return result;
        }

        // Operator overloading. Operasi perkalian matriks
        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, b.Cols);

            if (Matrix.CanMultiply(a, b))
            {
                for (int i = 0; i < a.Rows; i++)
                    for (int j = 0; j < b.Cols; j++)
                        for (int k = 0; k < b.Rows; k++)
                            result[i, j] += a[i, k] * b[k, j];
            }
            else
            {
                throw new WrongMatrixSizeException("Matrixs can't multiplied");
            }

            return result;
        }

        // Operator overloading. Operasi kebalikan matriks
        public static Matrix operator -(Matrix a)
        {
            return (-1 * a);
        }


        // Operator overloading. Operasi logika apakah matriks a 
        // sama dengan matriks b
        public static bool operator ==(Matrix a, Matrix b)
        {
            bool result = true;
            if (Matrix.IsSameSize(a, b))
            {
                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Cols; j++)
                    {
                        if (a[i, j] != b[i, j])
                        {
                            result = false;
                            break;
                        }
                    }
                    if (result == false) break;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        // Operator overloading. Operasi logika apakah matriks a 
        // tidak sama dengan matriks b
        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        #endregion

        #region Override Member
        // Override method. Apakah objek obj equal dengan nilai matriks?
        public override bool Equals(object obj)
        {
            bool result;

            if (obj is Matrix)
            {
                Matrix b = (Matrix)obj;
                result = (this == b);
            }
            else
            {
                result = false;
            }

            return result;

            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return data.GetHashCode();

            //return base.GetHashCode();
        }

        #endregion


        #region Standardized

        public Matrix Standardized(Matrix W)
        {
            Matrix result = new Matrix(W.Rows, W.Cols);

            for (int i = 0; i < W.Rows; i++)
            {
                double totalRow = 0;
                for (int j = 0; j < W.Cols; j++)
                {
                    totalRow = totalRow + W[i, j];
                }
                for (int k = 0; k < W.Cols; k++)
                {
                    if (W[i, k] == 1)
                        result[i, k] = 1 / totalRow;
                    else
                        result[i, k] = 0;
                }

            }
            return result;
        }
        #endregion


        #region Grouping

        // Menggabungkan dua matriks yang jumlah barisnya sama menjadi satu matriks
        public Matrix GroupingCols(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.Rows, a.Cols + b.Cols);
            Matrix Atemp = new Matrix(a.Rows, a.Cols + b.Cols);
            Matrix Btemp = new Matrix(a.Rows, a.Cols + b.Cols);

            if (Matrix.IsSameRow(a, b))
            {
                for (int i = 0; i < Atemp.Rows; i++)
                {
                    for (int j = 0; j < Atemp.Cols; j++)
                    {
                        if (j < a.Cols)
                            Atemp[i, j] = a[i, j];
                        else
                            Atemp[i, j] = 0.0;
                    }
                }

                for (int i = 0; i < Btemp.Rows; i++)
                {
                    for (int j = 0; j < Btemp.Cols; j++)
                    {
                        if (j > a.Cols - 1)
                            Btemp[i, j] = b[i, j - a.Cols];
                        else
                            Btemp[i, j] = 0.0;
                    }
                }

                result = Atemp + Btemp;
            }
            else
            {
                throw new NotSameSizeMatrixException("Matrixs don't have same rows");
            }

            return result;
        }
        #endregion
    }
}
