using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class Trimf : MembershipFunction
    {
        public Trimf(String Name, double a, double b, double c)
            : base()
        {
            this.Name = Name;
            Params.Add(a); Params.Add(b); Params.Add(c);
            range.Add(Params[0]);
            range.Add(Params[Params.Count - 1]);

            this.CalculateCenterOfMass();
            this.calculateSpread();
        }

        public override double getOutput(double Xvalue)
        {
            if (Xvalue >= Params[0] && Xvalue <= Params[1])
            {
                return (Xvalue - Params[0]) / (Params[1] - Params[0]);
            }
            else if (Xvalue >= Params[1] && Xvalue <= Params[2])
            {
                return (Params[2] - Xvalue) / (Params[2] - Params[1]);
            }
            return 0;
        }
    }
}
