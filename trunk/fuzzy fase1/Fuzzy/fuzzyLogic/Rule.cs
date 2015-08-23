using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class Rule
    {
        List<RuleItem> inrules;
        List<RuleItem> outrules;
        Connector conn;

        #region Constructor
        public Rule(List<RuleItem> ins, List<RuleItem> outs, Connector con)
        {
            inrules = ins;
            outrules = outs;
            conn = con;
        }

        public Rule()
        {
            inrules = new List<RuleItem>();
            outrules = new List<RuleItem>();
            conn = Connector.And;
        }
        #endregion

        #region Getters & Setters
        public List<RuleItem> InputRules
        {
            get { return inrules; }
        }

        public List<RuleItem> OutputRules
        {
            get { return outrules; }
        }

        public Connector Connection
        {
            get { return conn; }
            set { conn = value; }
        }
        #endregion

        #region Methods
        public void addInRuleItem(RuleItem item)
        {
            if (item != null)
            {
                inrules.Add(item);
            }
        }

        public void addOutRuleItem(RuleItem item)
        {
            if (item != null)
            {
                inrules.Add(item);
            }
        }

        public override string ToString()
        {
            String rule = "IF ";
            for (int j = 0; j < InputRules.Count; j++)
            {
                rule = rule + InputRules[j].Variable + " is " + InputRules[j].MembershipValue;
                if (j != InputRules.Count - 1)
                {
                    rule = rule + " And ";
                }
            }
            rule = rule + " Then ";
            for (int j = 0; j < OutputRules.Count; j++)
            {
                rule = rule + OutputRules[j].Variable + " is " + OutputRules[j].MembershipValue;
                if (j != OutputRules.Count - 1)
                {
                    rule = rule + " And ";
                }
            }
            return rule;
        }

        #endregion
    }
    public enum Connector
    {
        And = 0,
        Or = 1
    };
}
