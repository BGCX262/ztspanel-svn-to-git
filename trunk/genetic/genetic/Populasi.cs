using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    public class island
    {
        
        private int Populasi;
        private double CrossOverRate;
        private double MutasiRate;
        private int Rb;
        private int Ra;
        private int Var;
        private int I;
        private int Generation;
        

        public int[, ,] chromosome;
        public int[, ,] anak;
        public int[, ,] parent;
        
        public double[,] hasil;
        public double[] jml;

        private double[] fitnessVal;
        private double fitnessSum;
        private double fitnessAvg;
        private int JenisCross;

        Random rnd = new Random();
       public double[,]  data = new double[,]
            {
                 {5.43,8.54,6.55,3.43,3.54,5.42,5.00},
                              {5.53,8.43,(-7.12),2.54,2.06,(-5.56),4.77},
                              {6.12,8.52,(-7.21),2.46,2.32,(-5.67),4.98},
                              {6.43,8.44,(-7.23),2.28,2.26,(-5.72),5.25},
                              {6.45,8.75,(-7.54),2.65,3.55,(-5.96),5.49},
            };

        #region //chromosome
        public void Chromosome()
        {
            chromosome = new int[Populasi, 100, Var];
            for (int pop = 0; pop < Populasi; pop++)
            {
                int sum = 0;
                for (int gen = 0; gen < (data.GetLength(1)-1); gen++)
                {
                    for (int gen2 = gen; gen2 <(data.GetLength(1)-1); gen2++)
                    {
                        for (int dna = 0; dna < Var; dna++)
                        {
                            int angkaacak = rnd.Next(0,2);
                            chromosome[pop, sum, dna] = angkaacak;
                            Console.Write(chromosome[pop, sum, dna]);
                        }
                        Console.Write(" ");
                        sum++;
                    }
                }
                Console.WriteLine();
                Thread.Sleep(5);
            }
            
        }
        #endregion
        #region     //fitness Value
        public void fitnessValue(int[,,] chromosome)
        {
            fitnessVal = new double[Populasi];
            fitnessSum = 0;
            fitnessAvg = 1;
            hasil = new double[Populasi, 100];
            for (int pop = 0; pop < Populasi; pop++)
            {
                double value;
                int sum = 0;
                for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                {
                    for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                    {
                        int pangkat = -1;
                        value = 0;
                        double jmlPangkat = 0;
                        for (int dna = 0; dna < Var; dna++)
                        {
                            double p =(Math.Pow(2, pangkat));
                            double value2 = chromosome[pop, sum, dna] * p;
                            jmlPangkat += p;
                            pangkat -= 1;
                            value += value2;
                        }
                        hasil[pop, sum] = Rb + (((Ra - Rb) / jmlPangkat) * value);
                       
                        sum++;
                    }
                }
            }
            for (int pop = 0; pop < Populasi; pop++)
            {
                double jmlError = 0;
                double[] error = new double[data.GetLength(0)];
                jml = new double[data.GetLength(0)];
               
                for (int datRow = 0; datRow < data.GetLength(0); datRow++)
                {
                    double jumlah = 0;
                   
                    double kaliData = 0;
                    int sum = 0;
                    for (int datCol = 0; datCol < (data.GetLength(1) - 1); datCol++)
                    {
                        for (int datCol2 = datCol; datCol2 < (data.GetLength(1) - 1); datCol2++)
                        {
                            kaliData = (data[datRow, datCol] * data[datRow, datCol2]) * hasil[pop, sum];
                            jumlah += kaliData;
                            sum++;
                        }
                    }
                    jml[datRow] = jumlah;
                   
                    error[datRow] = Math.Abs(jml[datRow] - Math.Pow( data[datRow, (data.GetLength(1) - 1)],2));
                    jmlError += error[datRow];
                    
                }

                fitnessVal[pop] = 100 / ((jmlError/data.GetLength(0)) + 1);
                fitnessSum += fitnessVal[pop];
                fitnessAvg = fitnessSum / (fitnessSum + 1);
            }
            

      }
#endregion 
        #region selection
        public void selection(double[] fitnessVal,double fitnessSum, int[,,] chromosome)
        {
            //Probabilita
            double[] prob = new double[Populasi];
            for (int pop = 0; pop < Populasi; pop++)
            {
                prob[pop] = fitnessVal[pop] / fitnessSum;
             //   Console.Write(prob[pop]+ " " );
            }

            //Cumulative
            double[] cum = new double[100];
            for (int pop = 0; pop < Populasi; pop++)
            {
                if (pop == 0)
                {
                    cum[pop] = prob[pop];
                }
                else
                {
                    cum[pop] = cum[pop - 1] + prob[pop];
                }
              //Console.Write(cum[pop]+" " );
               
            }

            //putar Roulette Wheel
            double[] putar = new double[Populasi];
            int[, ,] hslPutar = new int[Populasi, 100, Var];
            for (int pop = 0; pop < Populasi; pop++)
            {
                double putarAcak = rnd.NextDouble();
                putar[pop] = putarAcak;
                int sum = 0;
                for (int datCol = 0; datCol < (data.GetLength(1) - 1); datCol++)
                {
                    for (int datCol2 = datCol; datCol2 < (data.GetLength(1) - 1); datCol2++)
                    {
                        for (int dna = 0; dna < Var; dna++)
                        {
                            for (int cekCum = 0; cekCum < Populasi; cekCum++)
                            {
                                if (putar[pop] < cum[cekCum])
                                {
                                    hslPutar[pop, sum, dna] = chromosome[cekCum, sum, dna];
                                    cekCum = Populasi;
                                }
                                else if (putar[pop] > cum[cekCum] && putar[pop] < cum[cekCum + 1])
                                {
                                    hslPutar[pop, sum, dna] = chromosome[cekCum + 1, sum, dna];
                                    cekCum = Populasi;
                                }
                                else
                                {
                                }
                            }
                        }
                        sum++;
                    }
                }
            }
            //setelah diputar
            copy(hslPutar);
            Thread.Sleep(1);


        }
        #endregion
        public void crossover(int[,,] chromosome)
        {
            #region milih parent
            //memilih parent untuk crossover
            parent = new int[Populasi, 100, Var];
            anak = new int[Populasi, 100, Var];
            int par = 0;
            double[] cross = new double[Populasi];
            for (int pop = 0; pop < Populasi; pop++)
            {
                cross[pop] = rnd.NextDouble();
                if (cross[pop] < CrossOverRate)
                {
                    int sum = 0;
                    for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                    {
                        for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                        {
                            for (int dna = 0; dna < Var; dna++)
                            {
                                parent[par, sum, dna] = chromosome[pop, sum, dna];
                            }
                            sum++;
                        }
                    }
                    par++;
                }
                else
                {
                    int sum = 0;
                    for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                    {
                        for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                        {
                            for (int dna = 0; dna < Var; dna++)
                            {
                                chromosome[pop, sum, dna] = chromosome[pop, sum, dna];
                            }
                            sum++;
                        }
                    }
                }
            }
            #endregion
            #region crossOver 1 point
            if (JenisCross == 1)
            {
                par = 0;
                for (int pop = 0; pop < Populasi; pop++)
                {
                    int temp;
                    if (cross[pop] < CrossOverRate)
                    {
                        int titik_cross = rnd.Next(1, Var - 1);
                        int sum = 0;
                        for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                        {
                            for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                            {
                                for (int dna = 0; dna < Var; dna++)
                                {
                                    if (pop == (Populasi - 1))
                                    {
                                        if (dna > titik_cross - 1)
                                        {
                                            anak[par, sum, dna] = parent[0, sum, dna];
                                        }
                                        else
                                        {
                                            anak[par, sum, dna] = parent[par, sum, dna];
                                        }
                                    }
                                    else if (dna > titik_cross - 1)
                                    {
                                        temp = parent[par, sum, dna];
                                        anak[par, sum, dna] = parent[par + 1, sum, dna];
                                        anak[par + 1, sum, dna] = temp;
                                    }
                                    else
                                    {
                                        anak[par, sum, dna] = parent[par, sum, dna];
                                    }
                                }
                                sum++;
                            }
                        }
                        par++;
                    }
                    else
                    {
                        int sum = 0;
                        for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                        {
                            for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                            {
                                for (int dna = 0; dna < Var; dna++)
                                {
                                    chromosome[pop, sum, dna] = chromosome[pop, sum, dna];

                                }
                                sum++;

                            }
                        }
                    }
                }
            }
            #endregion
            #region crossOver N point
            else if (JenisCross == 2)
            {
                par = 0;
                for (int pop = 0; pop < Populasi; pop++)
                {
                    int temp;
                    if (cross[pop] < CrossOverRate)
                    {
                        int titik_cross1 = rnd.Next(1, Var-1);
                        int titik_cross2 = rnd.Next(titik_cross1, Var-1);
                        int sum = 0;
                        for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                        {
                            for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                            {
                                for (int dna = 0; dna < Var; dna++)
                                {
                                    if (pop == Populasi - 1)
                                    {
                                        if (dna > (titik_cross1 - 1) && dna < (titik_cross2 + 1))
                                        {
                                            anak[par, sum, dna] = parent[0, sum, dna];
                                        }
                                        else
                                        {
                                            anak[par, sum, dna] = parent[par, sum, dna];
                                        }
                                    }
                                    else if (dna > (titik_cross1 - 1) && dna < (titik_cross2 + 1))
                                    {
                                        temp = parent[par, sum, dna];
                                        anak[par, sum, dna] = parent[par + 1, sum, dna];
                                        anak[par + 1, sum, dna] = temp;
                                    }
                                    else
                                    {
                                        anak[par, sum, dna] = parent[par, sum, dna];
                                    }
                                }
                                sum++;
                            }
                        }
                        par++;
                    }
                    else
                    {
                        int sum = 0;
                        for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                        {
                            for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                            {
                                for (int dna = 0; dna < Var; dna++)
                                {
                                    chromosome[pop, sum, dna] = chromosome[pop, sum, dna];
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            #region crossOver Uniform
            else
            {
                par = 0;
                for (int pop = 0; pop < Populasi; pop++)
                {
                    if (cross[pop] < CrossOverRate)
                    {
                        int sum = 0;
                        for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                        {
                            for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                            {
                                for (int dna = 0; dna < Var; dna++)
                                {
                                    int uniform = rnd.Next(0, 2);
                                    if (pop == Populasi - 1)
                                    {
                                        if (uniform == 0)
                                        {
                                            anak[par, sum, dna] = parent[par, sum, dna];
                                        }
                                        else
                                        {
                                            anak[par, sum, dna] = parent[0, sum, dna];
                                        }
                                    }
                                    else if (uniform == 0)
                                    {
                                        anak[par, sum, dna] = parent[par, sum, dna];
                                    }
                                    else
                                    {
                                        anak[par, sum, dna] = parent[par + 1, sum, dna];
                                    }
                                }
                                sum++;
                            }
                        }
                        par++;
                    }
                    else
                    {
                        int sum = 0;
                        for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                        {
                            for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                            {
                                for (int dna = 0; dna < Var; dna++)
                                {
                                    chromosome[pop, sum, dna] = chromosome[pop, sum, dna];
                                }
                            }
                        }
                    }
                }
            }


            #endregion
            copyCross(cross, anak);
        }
        public void mutasi(int[,,] chromosome)
        {
            #region mutasi
            for (int pop = 0; pop < Populasi; pop++)
            {
                    int sum = 0;
                    for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                    {
                        for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                        {
                            for (int dna = 0; dna < Var; dna++)
                            {
                                double mutasi = rnd.NextDouble();
                                if(mutasi < MutasiRate)
                                {
                                    if(chromosome[pop,sum,dna]==0)
                                    {
                                        anak[pop,sum,dna]=1;
                                    }
                                    else
                                    {
                                        anak[pop,sum,dna]=0;
                                    }
                                }
                                else
                                {
                                    anak[pop,sum,dna] = chromosome [pop,sum,dna];
                                }

                            }
                            sum++;
                        }
                    }
            }
            CopyMut(anak);
            #endregion
        }
        public void NextGenerasi()
        {
            

           
            fitnessValue(chromosome);
            selection(fitnessVal,fitnessSum,chromosome);
            crossover(chromosome);
            mutasi(chromosome);
            if (I == Generation - 1)
            {
                sorting(chromosome, fitnessVal);
                output(chromosome, jml);
            }
            I++;
            
           
        }
        public void copy(int[, ,] hslPutar)
        {
            for (int pop = 0; pop < Populasi; pop++)
            {
                int sum = 0;
                for (int datCol = 0; datCol < (data.GetLength(1) - 1); datCol++)
                {
                    for (int datCol2 = datCol; datCol2 < (data.GetLength(1) - 1); datCol2++)
                    {
                        for (int dna = 0; dna < Var; dna++)
                        {
                            chromosome[pop, sum, dna] = hslPutar[pop, sum, dna];
                        }
                        sum++;
                    }
                }
            }
            fitnessValue(chromosome);
        }

        public void copyCross(double[] cross, int[, ,] anak)
        {
            int par = 0;
            int sum;
            for (int pop = 0; pop < Populasi; pop++)
            {
                if (cross[pop] < CrossOverRate)
                {
                    sum = 0;
                    for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                    {
                        for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                        {
                            for (int dna = 0; dna < Var; dna++)
                            {
                                chromosome[pop, sum, dna] = anak[par, sum, dna];
                                
                            }
                            sum++;
                        }
                    }
                }
                else
                {
                    sum = 0;
                    for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                    {
                        for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                        {
                            for (int dna = 0; dna < Var; dna++)
                            {
                                chromosome[pop, sum, dna] = chromosome[pop, sum, dna];
                               
                            }
                            sum++;
                        }
                    }
                }
            }
        }
        public void CopyMut(int[, ,] anak)
        {
            for (int pop = 0; pop < Populasi; pop++)
            {
                int sum = 0;
                for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                {
                    for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                    {
                        for (int dna = 0; dna < Var; dna++)
                        {
                            chromosome[pop, sum, dna] = anak[pop, sum, dna];
                         //   Console.Write(chromosome[pop, sum, dna]);
                        }
                        sum++;
                    }
                }
            }
        }
        public void setting(int populasi, double crossOverRate, double mutasiRate,int jenisCross,int rb,int ra,int var,int i,int generasi)
        {
           this.Populasi = populasi;
           this.CrossOverRate = crossOverRate;
           this.MutasiRate = mutasiRate;
           this.JenisCross = jenisCross;
           this.Rb = rb;
           this.Ra = ra;
           this.Var = var;
           this.I = i;
           this.Generation = generasi;
          
        }

        public void sorting(int[, ,] chromosome, double[] fitnessVal)
        {
            
            int temp2;
            for(int pop=Populasi;pop>=0;pop--)
            {
                for(int pop2 =0;pop2<pop-1;pop2++)
                {
                    if(fitnessVal[pop2] < fitnessVal[pop2+1])
                    {
                        int sum=0;
                        for(int gen=0;gen<(data.GetLength(1)-1);gen++)
                        {
                            for(int gen2=gen;gen2<(data.GetLength(1)-1);gen2++)
                            {
                                for (int dna = 0; dna < Var; dna++)
                                {
                                    temp2=chromosome[pop2,sum,dna];
                                    chromosome[pop2,sum,dna]=chromosome[pop2+1,sum,dna];
                                    chromosome[pop2+1,sum,dna]=temp2;
                                    
                                }
                                sum++;
                            }
                        }
                    }
                }
            }
            fitnessValue(chromosome);
           
        }
        public void output(int[, ,] chromosome,double[] jml)
        {
            fitnessValue(chromosome);
            for (int pop = 0; pop < 1; pop++)
            {
                int sum = 0;
                for (int gen = 0; gen < (data.GetLength(1) - 1); gen++)
                {
                    for (int gen2 = gen; gen2 < (data.GetLength(1) - 1); gen2++)
                    {
                        Console.WriteLine("koefisien = " + hasil[pop, sum]);
                        sum++;
                    }
                }
                for (int datRow = 0; datRow < data.GetLength(0); datRow++)
                {
                    Console.WriteLine("data[{0}]:{1}",datRow, jml[datRow]);
                }
                Console.WriteLine("fitness val: " + fitnessVal[pop]);

            }
        }

    }
}
