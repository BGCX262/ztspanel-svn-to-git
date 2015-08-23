using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regresi.Distribution
{
    // Class untuk mendapatkan nilai peluang distribusi F
    public class F
    {
        //df adalah degrees of freedom
        private double df1, df2;

        //Constructor ketika Object diinisialisasi
        public F()
        {

        }

        // Mendapatkan Nilai peluang PValue
        // X adalah batas sumbu X dari grafik distribusi F
        public double PValue(double X, double DF1, double DF2)
        {
            this.df1 = DF1;
            this.df2 = DF2;
            if (df1 == 1 && df2 == 1)
            {
                return (0.00223606 + integration(0.00001, X)); //CDF 0.00001 = 0.00223606 
            }
            else if (df1 == 1)
            {
                return (1 - this.PValue(1 / X, df2, df1));
            }
            else
            {
                return (1 - integration(double.Epsilon, X));
            }

        }

        // Fungsi untuk menghitung Nilai Gamma r
        private double recGamma(double r)
        {
            if (r == 1) return 1;
            else if (r == 0) return 1;
            else if (r == 0.5) return Math.Sqrt(Math.PI);
            else if (r < 0) return recGamma(r + 1) / r;
            else return (r - 1) * recGamma(r - 1);
        }

        // Metode untuk menghitung nilai persamaan Chi Square pada nilai x
        private double FEquation(double x)
        {
            double result, rG1, rG2, rG12;

            rG1 = recGamma(df1 / 2);
            rG2 = recGamma(df2 / 2);
            rG12 = recGamma((df1 + df2) / 2);
            result = (rG12 / (rG1 * rG2)) * Math.Pow((df1 / df2), df1 / 2) * Math.Pow(x, (df1 / 2) - 1) * Math.Pow((1 + (df1 / df2) * x), -(df1 + df2) / 2);
            //if (df == 1 && x == 0)
            //{
            //    result = ((1 / (Math.Pow(2, df / 2) * rG)) * 0 * Math.Pow(Math.E, -x / 2));
            //}
            //else
            //{
            //    result = ((1 / (Math.Pow(2, df / 2) * rG)) * (Math.Pow(x, (df / 2) - 1) * Math.Pow(Math.E, -x / 2)));
            //}
            return result;
        }


        // Fungsi untuk menghitung nilai integral dari batas bawah sampai batas atas
        // dari Persamaan F.
        // Menggunakan metode Simpson.
        private double integration(double lowerBound, double upperBound)
        {
            double XN_1, int1, sum1, x2j_1, x2j, h, result;
            int interval = 10000;
            h = (upperBound - lowerBound) / interval;
            XN_1 = lowerBound + (interval - 1) * h;
            int1 = FEquation(lowerBound) + 4 * FEquation(XN_1) + FEquation(upperBound);
            sum1 = 0;
            for (int j = 1; j <= (interval / 2 - 1); j++)
            {
                x2j_1 = lowerBound + (2 * j - 1) * h;
                x2j = lowerBound + (2 * j) * h;
                sum1 = sum1 + 2 * FEquation(x2j_1) + FEquation(x2j);

                double aaa = FEquation(x2j);
            }
            result = ((h / 3 * (int1 + 2 * sum1)));
            if (result >= 1) result = 1;
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
            get { return df1; }
        }
    }
}
