using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Descriptive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.Write("Jumlah Observasi : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Out.WriteLine("\n");
            Console.Out.WriteLine("Masukkan Nilai Observasi Data");
            //Console.Out.WriteLine("\n");
            Console.Out.WriteLine("------------------------------------------");

            double[] data = new double[n];
            for (int i = 0; i < n; i++)
            {
               
                    Console.Out.Write("Data[" + i +"]:");
                    data[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Out.WriteLine("------------------------------------------");
            Console.Out.WriteLine("\n");
            Console.Out.WriteLine("Nilai Descriptive dari data tersebut adalah sebagai berikut.\n\n");
            Descriptive descriptive = new Descriptive(data);
            double totalData, mean, meanGeo, meanHar, min, max, range, 
                variance, stdDev, skewness, kurtosis, q1, q2, q3, iqr, eTotal, eTotal2;
            descriptive.Analyze();
            totalData = descriptive.Result.Sum;
            mean = descriptive.Result.Mean;
            meanGeo = descriptive.Result.GeometricMean;
            meanHar = descriptive.Result.HarmonicMean;
            min = descriptive.Result.Min;
            max = descriptive.Result.Max;
            range = descriptive.Result.Range;
            variance = descriptive.Result.Variance;
            stdDev = descriptive.Result.StdDev;
            skewness = descriptive.Result.Skewness;
            kurtosis = descriptive.Result.Kurtosis;
            q1 = descriptive.Result.FirstQuartile;
            q2 = descriptive.Result.Median;
            q3 = descriptive.Result.ThirdQuartile;
            iqr = descriptive.Result.IQR;
            eTotal = descriptive.Result.SumOfError;
            eTotal2 = descriptive.Result.SumOfErrorSquare;

            Console.Out.WriteLine("Jumlah Observasi = \t {0}", n);
            Console.Out.WriteLine("Jumlah Total data = \t {0}", totalData);
            Console.Out.WriteLine("Rata-rata Aritmatik = \t {0}",mean);
            Console.Out.WriteLine("Rata- rata Geometrik = \t {0}",meanGeo);
            Console.Out.WriteLine("Rata-rata Harmonik = \t {0}",meanHar);
            Console.Out.WriteLine("Nilai Minimum = \t {0}",min);
            Console.Out.WriteLine("Nilai Maximum = \t {0}",max);
            Console.Out.WriteLine("Range Nilai = \t\t {0}",range);
            Console.Out.WriteLine("Nilai Variance = \t {0}",variance);
            Console.Out.WriteLine("Nilai Standard Deviasi = {0}",stdDev);
            Console.Out.WriteLine("Nilai Skewness = \t {0}",skewness);
            Console.Out.WriteLine("Nilai Kurtosis = \t {0}",kurtosis);
            Console.Out.WriteLine("Nilai Quartile 1 = \t {0}",q1);
            Console.Out.WriteLine("Nilai Quartile 2 = \t {0}",q2);
            Console.Out.WriteLine("Nilai Quartile 3 = \t {0}",q3);
            Console.Out.WriteLine("Range Inter Quartile = \t {0}",iqr);
            Console.Out.WriteLine("Nilai Total Error = \t {0}",eTotal);
            Console.Out.WriteLine("Nilai Total Error Kuadarat = \t {0}",eTotal2);
            Console.ReadLine();
            

        }
    }
}
