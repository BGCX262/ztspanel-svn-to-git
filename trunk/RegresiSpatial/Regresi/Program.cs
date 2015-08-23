using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regresi
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Out.Write("Jumlah Variabel Bebas : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Out.Write("Jumlah Observasi : ");
            int n  = Convert.ToInt32(Console.ReadLine());
            Console.Out.WriteLine("\n");
            Console.Out.WriteLine("Masukkan Nilai Observasi Variabel Bebas X");
            //Console.Out.WriteLine("\n");
            Console.Out.WriteLine("------------------------------------------");

            Matrix X = new Matrix(n,p);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Out.Write("X[" + i +","+ j+"]:");
                    X[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }
           
            Console.Out.WriteLine("------------------------------------------");

            Console.Out.WriteLine("\n");
            Console.Out.WriteLine("Masukkan Nilai Observasi Variabel Terikat Y");
            //Console.Out.WriteLine("\n");
            Console.Out.WriteLine("------------------------------------------");
            Vector Y = new Vector(n,Vector.VectorType.ColumnVector);
             for (int i = 0; i < n; i++)
             {
                 Console.Write("Y[" + i + "]: ");
                 Y[i] = Convert.ToDouble(Console.ReadLine());

             }
             Console.Out.WriteLine("------------------------------------------");
            
             Console.Out.WriteLine("\n");
             Console.Out.WriteLine("Masukkan Nilai Pembobot W");
            // Console.Out.WriteLine("\n");
             Console.Out.WriteLine("------------------------------------------");

             Matrix W = new Matrix(n, n);
             int rows = n;
             int cols = n;
             for (int i = 0; i < rows; i++)
             {
                 for (int j = 0; j < cols; j++)
                 {
                     Console.Out.Write("W[" + i + "," + j + "]: ");
                     W[i, j] = Convert.ToDouble(Console.ReadLine());
                 }
                // Console.Out.WriteLine();
             }
             Console.Out.WriteLine("------------------------------------------");

             Console.Out.WriteLine("\n");

            // Estimasi Nilai parameter
           LeastSquareEstimator estim = new LeastSquareEstimator(X, W, Y);
          
           Console.Out.WriteLine("Nilai X Bintang adalah :");
           Console.Out.WriteLine("------------------------------------------");

          // int xBintangCol = estim.Xstar.Cols;
          // int xBintangRows = estim.Xstar.Rows;
           Matrix xBintang = new Matrix(n,p);
           xBintang = estim.Xstar;
           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < p; j++)
               {
                   Console.Out.WriteLine("Xstar [" + i + "," + j + "]: {0}", xBintang[i,j]);
                   //xBintang[i, j] = Convert.ToDouble(Console.ReadLine());
               }
               // Console.Out.WriteLine();
           }
           Console.Out.WriteLine("------------------------------------------");
           Console.Out.WriteLine("\n");

           Console.Out.WriteLine("Nilai X Observasi  adalah :");
           Console.Out.WriteLine("------------------------------------------");

           int xObsCols = estim.Xobs.Cols;
           int xObsROws = estim.Xobs.Rows;
           Matrix xObservasi = new Matrix(xObsROws, xObsCols);
           xObservasi = estim.Xobs; 
           for (int i = 0; i < xObsROws; i++)
           {
               for (int j = 0; j < xObsCols; j++)
               {
                   Console.Out.WriteLine("X Observasi [" + i + "," + j + "]: {0}", xObservasi[i, j]);
               }
           }
         Console.Out.WriteLine("------------------------------------------");
        // Console.ReadLine();


          // Console.Out.WriteLine("------------------------------------------");
           Console.Out.WriteLine("\n");

           Console.Out.WriteLine("Nilai X Tranpose X  adalah :");
           Console.Out.WriteLine("------------------------------------------");

           int xObsTxCols = estim.XobsTx .Cols;
           int xObsTxROws = estim.XobsTx.Rows;
           Matrix xObsTx = new Matrix(xObsTxROws, xObsTxCols);
           xObsTx = estim.XobsTx;
           for (int i = 0; i < xObsTxROws; i++)
           {
               for (int j = 0; j < xObsTxCols; j++)
               {
                   Console.Out.WriteLine("XTranposeX [" + i + "," + j + "]: {0:#,0.####}", xObsTx[i, j]);
               }
           }
           Console.Out.WriteLine("------------------------------------------");
         //  Console.ReadLine();

          // Console.Out.WriteLine("------------------------------------------");
           Console.Out.WriteLine("\n");

           Console.Out.WriteLine("Nilai X Tranpose Y  adalah :");
           Console.Out.WriteLine("------------------------------------------");

           int xObsTyTuple = estim.XobsTy.Tuples;
           Vector xObsTy = new Vector(xObsTyTuple);
           xObsTy = estim.XobsTy;
           for (int i = 0; i < xObsTxROws; i++)
           {
               Console.Out.WriteLine("XTranposeY [" + i + "]: {0:#,0.####}", xObsTy[i]);
           }
           Console.Out.WriteLine("------------------------------------------");
           Console.Out.WriteLine("\n");
            //  Console.ReadLine();



           Console.Out.WriteLine("Nilai Inverse X Tranpose X  adalah :");
           Console.Out.WriteLine("------------------------------------------");

           int inversXtxRows = estim.XObsTxInverse.Rows;
           int inversXtxCols = estim.XObsTxInverse.Cols;
           Matrix inversXobsTx = new Matrix(inversXtxRows, inversXtxCols);
           inversXobsTx = estim.XObsTxInverse;
           for (int i = 0; i < inversXtxRows; i++)
           {
               for (int j = 0; j < inversXtxCols; j++)
               {
                   Console.Out.WriteLine("Inverse X Tranpose X [" + i + "," + j + "]: {0:#,0.####}", inversXobsTx[i, j]);
               }
           }
           Console.Out.WriteLine("------------------------------------------");
           Console.Out.WriteLine("\n");
            // Console.ReadLine();


           int parameterCount = estim.Estimator.Tuples;
           Vector param = new Vector(parameterCount,Vector.VectorType.ColumnVector);
           param = estim.Estimator;
           double r = estim.R;
           double r2 = estim.RSquare;

          Console.Out.WriteLine(" Estimasi nilai parameter adalah sebagai berikut:");
          Console.Out.WriteLine("\n");
          Console.Out.WriteLine("------------------------------------------");
           Console.Out.WriteLine("parameter \tNilai parameter");
           Console.Out.WriteLine("------------------------------------------");
           for (int i = 0; i < parameterCount; i++)
           {
               Console.WriteLine("parameter [{0}] \t {1:#,0.####} ", i, param[i]);
           }
           Console.Out.WriteLine("------------------------------------------\n");
           Console.Out.WriteLine("Koefisien Korelasi = {0}", r);
           Console.Out.WriteLine("Koefisien Determinasi = {0}\n\n", r2);
           double eVar;
           eVar = estim.Evariance;
           Console.Out.WriteLine("Variance dari error = {0}", eVar);
           Console.Out.WriteLine("\n");
          // Console.ReadLine();

           Console.Out.WriteLine("Nilai Matrix Variance - Covariance adalah sebagai berikut:");
           Console.Out.WriteLine("------------------------------------------");
           Matrix varCov = new Matrix(inversXtxRows, inversXtxCols);
           varCov = estim.SbSquare;
           
           for (int i = 0; i < inversXtxRows; i++)
           {
               for (int j = 0; j < inversXtxCols; j++)
               {
                   Console.Out.WriteLine("Variance [" + i + "," + j + "]: {0:#,0.####}", varCov[i, j]);
               }
           }
           Console.Out.WriteLine("------------------------------------------");
           Console.Out.WriteLine("\n");


         Console.Out.WriteLine("==============PENGUJIAN PARAMETER===============\n");
           Console.Out.WriteLine("--Uji Parsial--(uji t)---");
           
           Vector ycap = new Vector(n);
           Vector error = new Vector(n);
           //  Vector param = new Vector(parameterCount);
           ycap = estim.YCap;
           error = estim.E;
           Vector t, peluangT;
           t = estim.Ttest;
           peluangT = estim.Tprob;
           Console.Out.WriteLine("----------------------------------------------------------");
           Console.Out.WriteLine("estimasi parameter \t Nilai T \t pValue");
           Console.Out.WriteLine("----------------------------------------------------------");
           for (int i = 0; i < parameterCount; i++)
           {
               Console.WriteLine("\t{0:#,0.###} \t\t {1:#,0.###} \t\t {2:#,0.###} ", param[i], t[i], peluangT[i]);
               //1Y[i] = Convert.ToDouble(Console.ReadLine());

           }
           Console.Out.WriteLine("----------------------------------------------------------\n\n");

           Console.Out.WriteLine("--Uji Simultan--(uji F)---");
           double fValue,peluangF, SSR, SSE, SST, MSR, MSE;
           int k; 
           fValue = estim.FValue;
           peluangF = estim.FProb;
           SSR = estim.SSR;
           SSE = estim.SSE;
           SST = estim.SSTO;
           MSR = estim.MSR;
           MSE = estim.MSE;
           k = estim.Xobs.Cols;
           
           Console.Out.WriteLine("-------------------------------------------------------------------------");
           Console.Out.WriteLine("Source of Var \t Sum Square \t dof \t Mean Square \t F");
           Console.Out.WriteLine("-------------------------------------------------------------------------");
           Console.Out.WriteLine("Regression \t {0:#,0.####} \t {1} \t {2:#,0.####} \t {3:#,0.####}", SSR, k - 1, MSR, fValue);
           Console.Out.WriteLine("Residual   \t {0:#,0.####} \t {1} \t {2:#,0.####}", SSE, n - k, MSE);
           Console.Out.WriteLine("-------------------------------------------------------------------------");
           Console.Out.WriteLine("Total \t   \t {0:#,0.####} \t\t {1}", SST, n - 1);
           Console.Out.WriteLine("-------------------------------------------------------------------------");
           Console.Out.WriteLine("\n\n");
           Console.Out.WriteLine("Nilai PValue pada uji F ini adalah = {0:#,0.####}", peluangF);
           Console.Out.WriteLine("\n\n");



           Console.Out.WriteLine (" Perbandingan Y dan Ycap adalah sebagai berikut:");
           Console.Out.WriteLine("-------------------------------------------------------------------------");
           Console.Out.WriteLine("\t Y \t\t Ycap \t\t error");
           Console.Out.WriteLine("-------------------------------------------------------------------------");
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine("\t {0} \t\t {1:#,0.####} \t {2:#,0.####}", Y[i], ycap[i], error[i]);
               //1Y[i] = Convert.ToDouble(Console.ReadLine());

           }
           Console.Out.WriteLine("-------------------------------------------------------------------------");
           Console.ReadLine();
          }
    }
}
