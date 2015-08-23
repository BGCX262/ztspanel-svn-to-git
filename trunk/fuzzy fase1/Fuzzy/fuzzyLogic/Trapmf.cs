using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class Trapmf : MembershipFunction
    {
        public Trapmf(String Name, double a, double b, double c, double d)
            : base()
        {
            this.Name = Name;
            Params.Add(a); Params.Add(b);
            Params.Add(c); Params.Add(d);

            range.Add(Params[0]);
            range.Add(Params[Params.Count - 1]);

            this.CalculateCenterOfMass();
            this.calculateSpread();
        }
        public override double getOutput(double Xvalue)
        {
            if ((Xvalue >= Params[0]) && (Xvalue <= Params[1]))
            {
                return (Xvalue - Params[0]) / (Params[1] - Params[0]);
            }
            else if ((Xvalue >= Params[1]) && (Xvalue <= Params[2]))
            {
                return MaxY;
            }
            else if ((Xvalue >= Params[2]) && (Xvalue <= Params[3]))
            {
                return (Params[3] - Xvalue) / (Params[3] - Params[2]);
            }
            return 0;
        }
    }
}
