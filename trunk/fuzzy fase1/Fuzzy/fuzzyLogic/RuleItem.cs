using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class RuleItem
    {
        private String variable;
        private String membership;

        #region Constructor
        public RuleItem(String Variable, String Membership)
        {
            this.variable = Variable;
            this.membership = Membership;
        }
        #endregion

        #region Getter & Setters
        public String Variable
        {
            get { return variable; }
        }

        public String MembershipValue
        {
            get { return membership; }
        }
        #endregion 
    }
}
