using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    //public delegate double FitnessDelegate(object chromosomeRepresentation);
    //public delegate ChromosomePair SelectionDelegate();
    //public struct ChromosomePair
    //{
    //    public Chromosome parent1;
    //    public Chromosome parent2;
    //}
    public class Chromosome
    {
        public string ChromosomeString
        {
            set;
            get;
        }
        public Chromosome()
        {
            Random r = new Random(Convert.ToInt32(DateTime.Now.Ticks % Int16.MaxValue));
            this.ChromosomeString = String.Empty;
            for (int i = 0; i < 8; i++)
            {
                this.ChromosomeString += "" + r.Next() % 2;
               
            }
            Console.WriteLine(ChromosomeString);
           
            Thread.Sleep(30);
        }
        //public double CalculateFitness(FitnessDelegate fitnessFunction)
        //{
        //    return fitnessFunction(ChromosomeString);
        //}
        //public double fitnessFunction(string chromosomeString)
        //{

        //    double fitVal = 0;
        //    foreach (char c in (string)ChromosomeString)
        //    {
        //        int pangkat = 7;
        //        double nilaistring = 0;
        //        for (int i = 0; i < 8; i++)
        //        {

        //            double pang = Math.Pow(2, pangkat);
        //            double kali = c * pang;
        //            pangkat = -1;
        //            nilaistring += kali;
        //        }
        //        fitVal = 1 - +(nilaistring / 127.5);
        //        Console.WriteLine(fitVal);
        //    }
        //    return fitVal;
        //}


        //public static int SumStringCharacter(object chromosomeString)
        //{
        //    int sum = 0;
        //    foreach (char c in (string)chromosomeString)
        //    {
        //        if (c == '1')
        //        {
        //            sum++;
        //        }
        //        else if (c == '0')
        //        {
        //        }
        //        else
        //        {
        //            //tODO:AddErrorCondition
        //        }
        //    }
        //    return sum;
        //}
            
    }
}
