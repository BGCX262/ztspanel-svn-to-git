using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class Config
    {
        private ImpMethod implication;
        private ConnMethod andlogic;
        private DefuzzifcationType defuzType;

        #region Constructor
        public Config(ImpMethod Imp, ConnMethod And)
        {
            implication = Imp;
            andlogic = And;
        }
        #endregion

        #region Getter & setter
        public ImpMethod Implication
        {
            get { return implication; }
            set { implication = value; }
        }

        public ConnMethod Logic
        {
            get { return andlogic; }
            set { andlogic = value; }
        }

        public DefuzzifcationType DefuzzificationType
        {
            get { return defuzType; }
            set { defuzType = value; }
        }

        #endregion

    }

    public enum DefuzzifcationType
    {
        Centroid = 0,
        ModifiedHeight =1
    }

   public enum ImpMethod
    {
        Min = 0,
        Prod = 1
    };

    public enum ConnMethod
    {
        Min = 0,
        Prod = 1
    };
}
