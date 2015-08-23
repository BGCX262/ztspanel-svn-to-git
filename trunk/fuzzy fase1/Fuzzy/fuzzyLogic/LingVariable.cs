using System;
using System.Collections.Generic;
using System.Text;

namespace Fuzzy.fuzzyLogic
{
    public class LingVariable
    {
        private String label;
        private List<double> range;
        private List<MembershipFunction> fs;
        private VarType type;

        #region konstruktor
        public LingVariable(String Name, VarType Type)
        {
            label = Name;
            range = new List<double>(2);
            fs = new List<MembershipFunction>();
            type = Type;
        }
        #endregion

        #region setter & Getter konstruktor
        public String Name
        {
            get { return label; }
            set { label = value; }
        }
        public List<double> Range
        {
            get { return range; }
            set { range = value; }
        }

        public VarType Type
        {
            get { return type; }
        }

        public List<MembershipFunction> MFs
        {
            get { return fs; }
        }
        #endregion

        #region Methods
        //method untuk setting range
        public void setRange(double start, double end)
        {
            Range.Add(start);
            Range.Add(end);
        }
        //method untuk mendapatkan nilai mf dengan menggunakan nama mfnya
        public MembershipFunction getMFbyName(String name)
        {
            return fs.Find(delegate(MembershipFunction mf) { return mf.Name == name; });
        }
        //method untuk menambahkan membershipFunction
        public void addMF(MembershipFunction mf)
        {
            if (mf != null)
            {
                fs.Add(mf);
            }
        }
        //method untuk menghapus membershipFunction
        public bool removeMF(MembershipFunction mf)
        {
            if (mf != null)
            {
                return fs.Remove(mf);
            }
            return false;
        }
        #endregion

    }

    //enumerator untuk tipe variabel
    public enum VarType
    {
        input,
        output
    };
}
