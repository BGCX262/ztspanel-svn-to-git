using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class FuzzySet
    {
        private List<FuzzyNumber> nums;
        private String lingvar;

        #region konstruktor fuzzyset
        public FuzzySet(List<FuzzyNumber> Num, String LingusticVariable)
        {
            nums = Num;
            lingvar = LingusticVariable;
        }

        public FuzzySet(String LingusticVariable)
        {
            lingvar = LingusticVariable;
            nums = new List<FuzzyNumber>();
        }

        #endregion

        #region Setters & Getters konstruktor fuzzy set
        public List<FuzzyNumber> Set
        {
            get { return nums; }
            set { nums = value; }
        }

        public String Variable
        {
            get { return lingvar; }
            set { lingvar = value; }
        }
        #endregion

        #region Methods
        public FuzzyNumber searchByMembershipValue(String Value)
        {
            return nums.Find(delegate(FuzzyNumber e) { return e.MembershipName == Value; });
        }
        #endregion
    }
}
