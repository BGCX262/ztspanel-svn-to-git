 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regresi 
{
    public class LeastSquareEstimator
    {
        private Matrix x, w, xstar, wStandard, xObs, xObsTx, xObsTxInverse;
        private Vector y, xObsTy, estimator,ycap, e, eSquare, tProb,tTest;
        private double ssto, ssr, sse;
        private double msr, mse, fValue,fProb;
        private double r, rSquare, eVariance;
        private Matrix covEstimator;
        private int p;


        #region Constructor

        //Menghitung estimator spatial regresi dengan OLS
       public LeastSquareEstimator(Matrix X, Matrix W, Vector Y)
       {

           //this.x = X;
           this.w = W;
           this.y = Y;
           int n = X.Rows;
           // this.p = X.Cols;

           Matrix vector1 = new Matrix(n, 1);
           vector1.InitializeAllValue(1);

           x = new Matrix(X.Rows, vector1.Cols + X.Cols);
           x = x.GroupingCols(vector1, X);
           //this.p = x.Cols;

           wStandard = new Matrix(w.Rows, w.Cols);
           Matrix wTemp = new Matrix(w.Rows, w.Cols);
           wStandard = wTemp.Standardized(w);


           xstar = wStandard * X;


           //Penggabungan matriks x dan x* sebagai matrik x observasi
           xObs = new Matrix(x.Rows, x.Cols + xstar.Cols);
           xObs = xObs.GroupingCols(x, xstar);
           this.p = xObs.Cols;

           xObsTx = xObs.GetTranspose() * xObs;

           xObsTy = xObs.GetTranspose() * y;


           xObsTxInverse = xObsTx.GetInverse();

           estimator = xObsTxInverse * xObsTy;

           ycap = xObs * estimator;
           e = y - ycap;
           eSquare = e.GetDataSquare();

           eVariance = Vector.DoubleMultiply(e.GetTranspose(), e) / (n - p);
           double seReg = Math.Sqrt(eVariance);
           covEstimator = eVariance * xObsTxInverse;

           Matrix J = new Matrix(n, n);
           J.InitializeAllValue(1.0);

           double yty = Vector.DoubleMultiply(Y.GetTranspose(), Y);
           Vector jy = J * y;
           ssto = yty - Vector.DoubleMultiply(Y.GetTranspose(), jy) / n;
           //sse = yty - Vector.DoubleMultiply(estimator.GetTranspose(), xty);
           sse = Vector.DoubleMultiply(e.GetTranspose(), e);
           ssr = ssto - sse;

           msr = ssr / (p - 1);
           mse = sse / (n - p);
           rSquare = ssr / ssto;
           r = Math.Sqrt(rSquare);

      
       // Mendapatkan Nilai F pada uji Simultan
       fValue = msr / mse;

       // Mendapatkan Nilai PValue pada uji F Simultan
       Distribution.F fDist = new Distribution.F();
       fProb = fDist.PValue(fValue, p - 1, n - p);

       // Mendapatkan Nilai t untuk uji Parsial
       tTest = new Vector(estimator.Tuples);
       tTest = ParsialTest(estimator, covEstimator);

       //Mendapatkan Nilai pValue pada uji t Parsial
       tProb = new Vector(tTest.Tuples);
       tProb = PValueParsialTest(tTest, p);

   }
   #endregion

   #region TestParameter

   //Menghitung Nilai uji parameter secara Parsial
   private Vector ParsialTest(Vector a, Matrix b)
   {
       Vector result = new Vector(a.Tuples);
       for (int i = 0; i < result.Tuples; i++)
       {
           for (int j = 0; j < b.Cols; j++)
               if (i == j)
                   result[i] = a[i] / Math.Sqrt(b[i, j]);
       }
       return result;
   }

   private Vector PValueParsialTest(Vector a, double k)
   {
       Vector result = new Vector(a.Tuples);
       Distribution.t pValue = new Distribution.t();
       for (int i = 0; i < result.Tuples; i++)
       {
           //for (int j = 0; j < result.Cols; j++)
           result[i] = pValue.FullPValue(a[i], k);
       }
       return result;
   }
   #endregion

   #region Properties

   // Mendapatkan Nilai Matriks X
   public Matrix X
   {
       get { return x; }
   }

       // Mendapatkan Nilai Matriks W
       /* public Matrix W
        {
            get { return w; }
        }

        // Mendapatkan Nilai Vector Y
        public Vector Y
        {
            get { return y; }
        }
*/
        // Mendapatkan Nilai Vektor Y Predicted
        public Vector YCap
        {
            get { return ycap; }
        }
        
        // Mendapatkan Nilai estimasi parameter
        public Vector Estimator
        {
            get { return estimator; }
        }

        // Mendapatkan Nilai Vector Error
       public Vector E
        {
            get { return e; }
        }

        //  Mendapatkan Nilai Vector e kuadrat
        public Vector ESquare
        {
            get { return eSquare; }
        }

        // Mendapatkan Nilai SSTO
        public double SSTO
        {
            get { return ssto; }
        }

        // ndapatkan Nilai SSR
        public double SSR
        {
            get { return ssr; }
        }

        //Mendapatkan Nilai SSE
        public double SSE
        {
            get { return sse; }
        }

        // Mendapatkan Nilai MSR
        public double MSR
        {
            get { return msr; }
        }

        // Mendapatkan Nilai MSE
        public double MSE
        {
            get { return mse; }
        }

        // Mendaptkan koefisien korelasi 
        public double R
        {
            get { return r; }
        }

        // mendapatkan koefisien determinasi
        public double RSquare
        {
            get { return rSquare; }
        }

        // Mendaptakan Matriks variance-covariance
       public Matrix SbSquare
        {
            get { return covEstimator; }
        }

        public double FValue
        {
            get { return fValue; }
        }

        public double Evariance
        {
            get { return eVariance; }
        }

        public double FProb
        {
            get { return fProb; }
        }

        public Vector Ttest
        {
            get { return tTest; }
        }

        public Vector Tprob 
        {
            get { return tProb ; }
        }
          
        public Matrix Xstar
        {
            get { return xstar; }
        }


        public Matrix Xobs
        {
            get { return xObs; }
        }


        public Matrix XobsTx
        {
            get { return xObsTx; }
        }

        public Vector XobsTy
        {
            get { return xObsTy; }
        }
        public Matrix XObsTxInverse
        {
            get { return  xObsTxInverse; }
        }
       
      #endregion

    }
}
