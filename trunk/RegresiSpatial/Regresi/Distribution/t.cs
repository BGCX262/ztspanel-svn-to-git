using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regresi.Distribution
{
    // Class untuk mendapatkan nilai probability dari distribusi t
    public class t
    {
        // DF = nilai degree of Freedom(derajat Bebas)
        // x = nilai batas sumbu X dari tabel distribusi t
        // pValue = nilai peluang(probability) dari distribusi t pada batas sumbu X
        private double df;

        // Constructor ketika objek diinisialisasi
        public t()
        {

        }

        //Mendapatkan Nili probability t untuk uji satu sisi
        public double HalfPValue(double X, double DF)
        {
            this.df = DF;
            if (X < 0) X = -X;
            //double Z1 = 0;
            //double Z2 = 0; 
            //Normal normal = new Normal(0, 1);
            //ChiSquare cs = new ChiSquare(df);
            //Z1 = normal.FullValue(X);
            //Z2 = cs.PValue(X);
            //double ret = ((Z1 / Math.Sqrt(Z2 / df)));
            //return ret;
            return (0.5 - integration(0, X));
        }


        // Untuk uji dua sisi
        public double FullPValue(double X, double DF)
        {
            this.df = DF;
            if (X < 0) X = -X;
            //double Z1 = 0;
            //double Z2 = 0;
            //Normal normal = new Normal(0, 1);
            //ChiSquare cs = new ChiSquare(df);
            //Z1 = normal.FullValue(X);
            //Z2 = cs.PValue(X);

            //return (Z1 / Math.Sqrt(Z2 / df));
            return 2 * (0.5 - integration(0, X));
        }

        // Menghitung Nilai Gamma r
        private double recGamma(double r)
        {
            if (r == 1) return 1;
            else if (r == 0) return 1;
            else if (r == 0.5) return Math.Sqrt(Math.PI);
            else if (r < 0) return recGamma(r + 1) / r;
            else return (r - 1) * recGamma(r - 1);
        }

        // Menghitung Nilai persamaan t pada nilai x
        private double tEquation(double x)
        {
            double result, GpG;

            if (df % 2 == 0)
            {
                GpG = Math.Sqrt(Math.PI) / 2;
                for (int i = 3; i < df; i += 2)
                {
                    GpG *= (i / (double)(i - 1));
                }
            }
            else
            {
                GpG = 2 / Math.Sqrt(Math.PI);
                for (int i = 4; i < df; i += 2)
                {
                    GpG *= ((double)(i) / (i - 1));
                }
            }

            result = (GpG / Math.Sqrt((df * Math.PI))) * Math.Pow((1 + (x * x / df)), -(df + 1) / 2);
            return result;
        }

        // Fungsi untuk menghitung nilai integral dari batas bawah sampai batas atas
        // dari Persamaan t.
        // Menggunakan metode Simpson.
        private double integration(double lowerBound, double upperBound)
        {
            double XN_1, int1, sum1, x2j_1, x2j, h, result;
            int interval = 10000;
            h = (upperBound - lowerBound) / interval;
            XN_1 = lowerBound + (interval - 1) * h;
            int1 = tEquation(lowerBound) + 4 * tEquation(XN_1) + tEquation(upperBound);
            sum1 = 0;
            for (int j = 1; j <= (interval / 2 - 1); j++)
            {
                x2j_1 = lowerBound + (2 * j - 1) * h;
                x2j = lowerBound + (2 * j) * h;
                sum1 = sum1 + 2 * tEquation(x2j_1) + tEquation(x2j);
            }
            result = ((h / 3 * (int1 + 2 * sum1)));
            //if (result >= 0.5) result = 0.5;
            return result;
        }

        // Mendapatkan Nilai X
        public double X
        {
            get { return X; }
        }

        //Mendapatkan Nilai DF
        public double DF
        {
            get { return df; }
        }
    }
}
