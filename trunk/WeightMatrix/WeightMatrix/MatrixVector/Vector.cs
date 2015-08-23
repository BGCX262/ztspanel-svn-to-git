using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeightMatrix
{
    public class Vector
    {

        //Variabel untuk menampung data vektor
        private double[] data;
        private int tuples;
        private VectorType type;


        //Enumerasi Type Vektor
        public enum VectorType
        {
            ColumnVector,
            RowVector
        }



        # region Constructor

        //Constructor : Nilai awal Vektor
        //Type Vektor Default adalah Vektor kolom
        //integer jumlah tuples

        public Vector(int tuples)
        {
            this.tuples = Math.Max(1, tuples);
            this.type = Vector.VectorType.ColumnVector;
            this.data = new double[this.tuples];
        }


        //Array Double sebagai inisialisasi data vektor

        public Vector(double[] data, int tuples)
        {
            this.tuples = Math.Max(1, tuples);
            this.type = Vector.VectorType.ColumnVector;
            this.data = data;
        }

        //Jumlah tuple menyesuaikan panjang array data

        public Vector(double[] data)
        {
            this.tuples = data.Length;
            this.type = Vector.VectorType.ColumnVector;
            this.data = data;
        }

        // Semua elemen vektor diisi dengan nilai defaultnya 0.0
        public Vector(int tuples, VectorType type)
        {
            this.tuples = Math.Max(1, tuples);
            this.type = type;
            this.data = new double[this.tuples];
        }


        // Jumlah tuple menyesuaikan panjang array data
        public Vector(double[] data, int tuples, VectorType type)
        {
            this.tuples = Math.Max(1, tuples);
            this.type = type;
            this.data = data;
        }

        //Nilai elemen vektor diisi dengan nilai array data
        //Jumlah tuple menyesuaikan panjang array data

        public Vector(double[] data, VectorType type)
        {
            this.tuples = data.Length;
            this.type = type;
            this.data = data;
        }


        // Mengisi semua elemen vektor dengan nilai tertentu
        public void InitializeAllValue(double value)
        {
            for (int i = 0; i < tuples; i++)
                data[i] = value;
        }

        #endregion

        #region Properties

        //Jumlah Tuples
        public int Tuples
        {
            get { return this.tuples; }
        }

        //Type Vektor
        public VectorType Type
        {
            get { return this.type; }
        }

        // Mendapatkan atau mengeset nilai elemen vektor
        public double this[int tuple]
        {

            get { return this.data[tuple]; }
            set { this.data[tuple] = value; }
        }

        // Mendapatkan array data vektor
        public double[] GetData()
        {
            return this.data;
        }

        // Mendapatkan vector data kuadrat vektor
        public Vector GetDataSquare()
        {
            Vector result = new Vector(this.tuples);
            for (int i = 0; i < this.tuples; i++)
            {
                result[i] = this.data[i] * this.data[i]; ;
            }
            return result;
        }

        // Mendapatkan jumlah data pada vektor
        public double GetSumData()
        {
            double result = 0;
            for (int i = 0; i < this.tuples; i++)
            {
                result += this.data[i];
            }
            return result;
        }


        // Mendapatkan copy dari vektor
        public Vector Copy()
        {
            Vector result = new Vector(this.tuples, this.type);

            for (int i = 0; i < this.tuples; i++)
                result[i] = this.data[i];

            return result;
        }


        // Mendapatkan vektor transpose
        public Vector GetTranspose()
        {
            VectorType newType;

            if (this.type == VectorType.ColumnVector)
                newType = VectorType.RowVector;
            else
                newType = VectorType.ColumnVector;

            Vector result = new Vector(this.tuples, newType);

            for (int i = 0; i < this.tuples; i++)
                result[i] = this.data[i];

            return result;
        }

        // Mendapatkan panjang mutlak suatu vektor
        public double Length
        {
            get
            {
                double result = 0.0;
                for (int i = 0; i < tuples; i++)
                    result += Math.Pow((data[i]), 2);

                result = Math.Sqrt(result);

                return result;
            }
        }

        #endregion

        #region Static Member

        // Mengecek apakah dua vektor berukuran sama
        public static bool IsSameSize(Vector a, Vector b)
        {
            return (a.Tuples == b.Tuples);
        }

        // Mengecek apakah dua vektor bertipe sama
        public static bool IsSameType(Vector a, Vector b)
        {
            return (a.Type == b.Type);
        }

        // Mengecek apakah dua vektor berukuran dan bertipe sama
        public static bool IsSameSizeType(Vector a, Vector b)
        {
            return IsSameSize(a, b) && IsSameType(a, b);
        }

        // Mengecek apakah dua vektor dapat dilakukan perkalian double.
        // Perkalian double adalah perkalian vektor baris dengan vektor kolom
        // dimana menghasilkan sebuah bilangan bertipe double.
        public static bool CanDoubleMultiply(Vector a, Vector b)
        {
            return IsSameSize(a, b) && (a.Type == VectorType.RowVector)
                && (b.Type == VectorType.ColumnVector);
        }

        // Mengecek apakah dua vektor dapat dilakukan perkalian matriks.
        // Perkalian matriks adalah perkalian vektor kolom dengan vektor baris
        // dimana menghasilkan sebuah matriks persegi.
        public static bool CanMatrixMultiply(Vector a, Vector b)
        {
            return IsSameSize(a, b) && (a.Type == VectorType.ColumnVector)
                && (b.Type == VectorType.RowVector);
        }


        // Mengecek apakah sebuah matriks dapat dikalikan dengan sebuah vektor
        public static bool CanMultiply(Matrix a, Vector b)
        {
            return (a.Cols == b.Tuples) && (b.Type == VectorType.ColumnVector);
        }

        // Mengecek apakah sebuah vektor dapat dikalikan dengan sebuah matriks
        public static bool CanMultiply(Vector a, Matrix b)
        {
            return (a.Tuples == b.Rows) && (a.Type == VectorType.RowVector);
        }

        // Operator overloading. Operasi penjumlahan vektor
        public static Vector operator +(Vector a, Vector b)
        {
            Vector result = new Vector(a.Tuples, a.Type);

            if (IsSameSizeType(a, b))
            {
                for (int i = 0; i < a.Tuples; i++)
                    result[i] = a[i] + b[i];
            }
            else
            {
                throw new NotSameSizeVectorException();
            }

            return result;
        }


        // Operator overloading. Operasi pengurangan vektor
        public static Vector operator -(Vector a, Vector b)
        {
            Vector result = new Vector(a.Tuples, a.Type);

            if (IsSameSizeType(a, b))
            {
                for (int i = 0; i < a.Tuples; i++)
                    result[i] = a[i] - b[i];
            }
            else
            {
                throw new NotSameSizeVectorException();
            }

            return result;
        }

        // Operator overloading. Operasi perkalian skalar
        public static Vector operator *(double constant, Vector a)
        {
            Vector result = new Vector(a.Tuples, a.Type);

            for (int i = 0; i < a.Tuples; i++)
                result[i] = constant * a[i];

            return result;
        }

        // Operator overloading. Operasi perkalian matriks dengan vektor
        public static Vector operator *(Matrix a, Vector b)
        {
            Vector result = new Vector(a.Rows, VectorType.ColumnVector);

            if (CanMultiply(a, b))
            {
                for (int i = 0; i < a.Rows; i++)
                {
                    result[i] = 0.0;
                    for (int j = 0; j < a.Cols; j++)
                    {
                        result[i] += a[i, j] * b[j];
                    }
                }
            }
            else
            {
                throw new WrongVectorSizeOrTypeException("Can't be multiplied");
            }

            return result;
        }


        // Operator overloading. Operasi perkalian vektor dengan matriks
        public static Vector operator *(Vector a, Matrix b)
        {
            Vector result = new Vector(b.Cols, VectorType.RowVector);

            if (CanMultiply(a, b))
            {
                for (int i = 0; i < b.Cols; i++)
                {
                    result[i] = 0.0;
                    for (int j = 0; j < b.Rows; j++)
                    {
                        result[i] += a[j] * b[j, i];
                    }
                }
            }
            else
            {
                throw new WrongVectorSizeOrTypeException("Can't be multiplied");
            }

            return result;
        }


        // Melakukan perkalian double terhadap dua vektor
        public static double DoubleMultiply(Vector a, Vector b)
        {
            double result = 0.0;

            if (CanDoubleMultiply(a, b))
            {
                for (int i = 0; i < a.Tuples; i++)
                    result += a[i] * b[i];
            }
            else
            {
                throw new WrongVectorSizeOrTypeException("Vector can't be double Multiplied");
            }

            return result;
        }

        // Melakukan perkalian matriks terhadap dua vektor

        public static Matrix MatrixMultiply(Vector a, Vector b)
        {
            Matrix result = new Matrix(a.Tuples, b.Tuples);

            if (CanMatrixMultiply(a, b))
            {
                for (int i = 0; i < a.Tuples; i++)
                    for (int j = 0; j < b.Tuples; j++)
                        result[i, j] = a[i] * b[j];
            }
            else
            {
                throw new WrongVectorSizeOrTypeException("Vector can't be matrix Multiplied");
            }

            return result;
        }

        // Operator overloading. Membandingkan kesamaan dua vektor
        public static bool operator ==(Vector a, Vector b)
        {
            bool result = true;

            if (a.Type == b.Type)
            {
                if (a.Tuples == b.Tuples)
                {
                    for (int i = 0; i < a.Tuples; i++)
                    {
                        if (a[i] != b[i])
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
            }
            else
            {
                result = false;
            }

            return result;
        }
        // Operator overloading. Membandingkan ketidaksamaan dua vektor
        public static bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }


        // Mengecek apakah dua buah vektor perpendicular.
        // Dua buah vektor perpendicular jika hasil perkalian doublenya 0
        public static bool IsPerpendicular(Vector a, Vector b)
        {
            bool result;

            if (a.Type == VectorType.ColumnVector && b.Type == VectorType.ColumnVector)
            {
                Vector aT = a.GetTranspose();
                result = Vector.DoubleMultiply(aT, b) == 0.0;
            }
            else
            {
                throw new WrongVectorTypeException("Only Column Vector valid");
            }

            return result;
        }

        // Mendapatkan sudut (dalam radian) antara dua vektor
        public static double Angle(Vector a, Vector b)
        {
            double result;

            if (a.Type == VectorType.ColumnVector && b.Type == VectorType.ColumnVector)
            {
                Vector aT = a.GetTranspose();
                result = Vector.DoubleMultiply(aT, b);
                result /= a.Length * b.Length;
                result = Math.Acos(result);
            }
            else
            {
                throw new WrongVectorTypeException("Only Column Vector valid");
            }

            return result;
        }

        // Mendapatkan vektor proyeksi antara Vektor X dan Vektor Y
        public static Vector ProjectionXonY(Vector X, Vector Y)
        {
            Vector result;

            if (X.Type == VectorType.ColumnVector && Y.Type == VectorType.ColumnVector)
            {
                Vector XT = X.GetTranspose();
                double proj = Vector.DoubleMultiply(XT, Y) / (Math.Pow(Y.Length, 2));

                result = proj * Y;
            }
            else
            {
                throw new WrongVectorTypeException("Only Column Vector valid");
            }

            return result;

        }

        #endregion


        #region Override Member
        // Override Method. Mengecek apakah objek obj equal dengan nilai vektor.
        public override bool Equals(object obj)
        {
            bool result;

            if (obj is Vector)
            {
                Vector b = (Vector)obj;
                result = (this == b);
            }
            else
            {
                result = false;
            }

            return result;
        }

        // Override Method. Mendapatkan hash code vektor.
        public override int GetHashCode()
        {
            return data.GetHashCode() * Type.GetHashCode();

            //return base.GetHashCode();
        }

        #endregion

        // Mendapatkan matrix dari vektor berdasarkan lag yang diinput. Setiap lag
        // akan menjadi colum pada Matrix. 
        public Matrix GetMatrix(int Lag)
        {
            Matrix X = new Matrix(this.tuples - Lag, Lag + 1);

            for (int j = 0; j < this.tuples - Lag; j++)
            {
                X[j, 0] = 1;
                for (int i = 1; i <= Lag; i++)
                {
                    X[j, i] = this[Lag + j - i];
                }
            }
            return X;
        }

        public Matrix GetAcfMatrix()
        {
            int n = this.tuples;
            Matrix X = new Matrix(n, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) X[i, j] = 1;
                    else X[i, j] = this[Math.Abs(j - i) - 1];
                }
            }
            return X;
        }

    }
}
