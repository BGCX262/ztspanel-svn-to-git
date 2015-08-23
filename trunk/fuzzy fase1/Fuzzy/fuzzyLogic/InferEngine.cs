using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class InferEngine
    {
        List<Rule> rules;
        List<FuzzySet> sets;
        Config configuration;
        List<int> firedRules;

        #region Constructor
        public InferEngine(Config Conf, List<Rule> Rules, List<FuzzySet> Sets)
        {
            rules = Rules;
            sets = Sets;
            configuration = Conf;
            firedRules = new List<int>();
        }
        #endregion

        #region Getters & Setters
        public List<int> FiredRules
        {
            get { return firedRules; }
        }
        #endregion

        #region Helper Methods

        private FuzzySet searchByLingVariable(String Variable)
        {
            return sets.Find(delegate(FuzzySet f) { return f.Variable == Variable; });
        }

        private double getMin(List<double> values)
        {
            double min = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            return min;
        }

        private double getProd(List<double> values)
        {
            double max = 1;
            for (int i = 0; i < values.Count; i++)
            {
                max = values[i] * max;
            }
            return max;
        }

        private double Implication(double a, double b)
        {
            if (a > b) { return a; }
            return b;
        }

        private double Logic(List<double> pts)
        {
            if (configuration.Logic == ConnMethod.Min)
            {
                return getMin(pts);
            }
            else if (configuration.Logic == ConnMethod.Prod)
            {
                return getProd(pts);
            }
            return 0;
        }

        private double getRuleValue(Rule rule)
        {
            List<double> ruleValues = new List<double>();

            List<RuleItem> ins = rule.InputRules;

            for (int i = 0; i < ins.Count; i++)
            {
                FuzzySet set = searchByLingVariable(ins[i].Variable);
                if (set != null)
                {
                    FuzzyNumber num = set.searchByMembershipValue (ins[i].MembershipValue);
                    if (num != null)
                    {
                        ruleValues.Add(num.FuzzyValue);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            return Logic(ruleValues);
        }

        #endregion



        public List<FuzzySet> evaluateRules()
        {
            List<FuzzySet> OutSets = new List<FuzzySet>();

            for (int i = 0; i < rules.Count; i++)
            {
                List<RuleItem> outrules = rules[i].OutputRules;
                double firingStrength = getRuleValue(rules[i]);
                if (firingStrength > 0)
                {
                    firedRules.Add(i + 1);
                    for (int j = 0; j < outrules.Count; j++)
                    {
                        String Var = outrules[j].Variable;
                        if (OutSets.Exists(delegate(FuzzySet f) { return f.Variable == Var; }))
                        {
                            int index = OutSets.FindIndex(delegate(FuzzySet f) { return f.Variable == Var; });
                            String Mem = outrules[j].MembershipValue;
                            if (OutSets[index].Set.Exists(delegate(FuzzyNumber n) { return n.MembershipName == Mem; }))
                            {
                                int index2 = OutSets[index].Set.FindIndex(delegate(FuzzyNumber n) { return n.MembershipName == Mem; });
                                OutSets[index].Set[index2].FuzzyValue = Implication(OutSets[index].Set[index2].FuzzyValue, firingStrength);
                            }
                            else
                            {
                                FuzzyNumber num = new FuzzyNumber(Mem, firingStrength);
                                OutSets[index].Set.Add(num);
                            }
                        }
                        else
                        {
                            FuzzySet newset = new FuzzySet(Var);
                            newset.Set.Add(new FuzzyNumber(outrules[j].MembershipValue, firingStrength));
                            OutSets.Add(newset);
                        }
                    }
                }
            }
            return OutSets;
        }
    }
}
