using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public abstract class MembershipFunction
    {
        //struktur memebership function untuk linguistik variabel
        private String label;
        private List<double> points = new List<double>();
        private double spread;
        private double maxY = 1;

        private double centerofmass;
        protected List<double> range = new List<double>();

        #region Setters & Getters
        public String Name
        {
            get { return label; }
            set { label = value; }
        }

        public List<double> Range
        {
            get { return range; }
        }

        public double CenterOfMass
        {
            get { return centerofmass; }
        }

        public double Spread
        {
            get { return spread; }
        }

        public List<double> Params
        {
            get { return points; }
            set { points = value; }
        }

        public double MaxY
        {
            get { return maxY; }
            set { maxY = value; }
        }

        #endregion

        #region abstract Methods untuk nilai output
        public abstract double getOutput(double Xvalue);
        #endregion

        #region Perhitungan Nilai Pusat mass dan Lebarnya
        protected void CalculateCenterOfMass()
        {
            double stepN = 20;
            double start = this.Range[0];
            double end = this.Range[1];
            double step = (end - start) / (stepN - 1);
            double uppersum = 0;
            double lowersum = 0;

            for (double j = start; j < end; j = step + j)
            {
                double value = this.getOutput(j);
                if (value > 0)
                {
                    uppersum = value * j + uppersum;
                    lowersum = value + lowersum;
                }
            }
            centerofmass = (uppersum / lowersum);
        }

        protected void calculateSpread()
        {
            spread = range[1] - range[0] - 1;
        }

        #endregion
    }
}
