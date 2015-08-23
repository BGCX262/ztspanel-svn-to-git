using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            int populasi;
            int generasi;
            double crossOverRate;
            double mutasiRate;

            

            Console.Write("masukkan jumlah generasi : ");
            generasi = int.Parse(Console.ReadLine());
            Console.Write("masukkan jumlah populasi : ");
            populasi = int.Parse(Console.ReadLine());
            Console.Write("masukkan crossOver rate : ");
            crossOverRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan mutasi Rate : ");
            mutasiRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("crossover: 1.1 point 2.N point 3.Uniform :");
            int crossOver = int.Parse(Console.ReadLine());
            Console.Out.Write("masukkan range bawah koefisien : ");
            int Rb = Convert.ToInt32(Console.In.ReadLine());
            Console.Out.Write("masukkan range atas koefisien : ");
            int Ra = Convert.ToInt32(Console.In.ReadLine());
            Console.Out.Write("masukkan jml byte tuk chromosome: ");
            int var = Convert.ToInt32(Console.In.ReadLine());
           

          
               
               island pulauA = new island();
               int i = 0;
               pulauA.setting(populasi, crossOverRate, mutasiRate,crossOver,Rb,Ra,var,i,generasi);
               pulauA.Chromosome();
               
               do
               {
                   
                   Console.WriteLine("generasi :" + (i + 1));

            Thread pulau1 = new Thread(new ThreadStart(pulauA.NextGenerasi));
            //  Populasi2 pulauB = new Populasi2();
          //   Thread pulau2 = new Thread(new ThreadStart(pulauA.NextGenerasi));
              pulau1.Start();
              //     pulauA.NextGenerasi();
               i++;
         //    pulau2.Start();  
               
                
            }
               while( i < generasi);
            

               Console.ReadLine();
           
        }
        
       
    }
}
