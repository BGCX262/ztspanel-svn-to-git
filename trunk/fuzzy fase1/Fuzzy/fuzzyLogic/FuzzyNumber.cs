using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class FuzzyNumber
    {
        String membername; //nama membershipname
        double fuzzyout; //nilai keluaran fuzzy

        public FuzzyNumber(String MemberName, double Value)
        {
            membername = MemberName;
            fuzzyout = Value;
        }
        public String MembershipName
        {
            get { return membername; }
        }
        public double FuzzyValue
        {
            get { return fuzzyout; }
            set { fuzzyout = value; }
        }
        public override string ToString()
        {
            return MembershipName + "" + FuzzyValue.ToString();
        }
    }
}
