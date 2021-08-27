using System;
using System.ComponentModel;

namespace MonteCarlov2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int iterations, oneWin = 0, twoWin = 0; 

            iterations = Int32.Parse(args[0]);

            for (int i = 0; i < iterations; i++)
            {
                int[] rollSix = new int[6];
                int[] rollTwelve = new int[12];
                
                for (int j = 0; j < 6; j++)
                {
                    rollSix[j] = random.Next(7);
                }

                for (int j = 0; j < 12; j++)
                {
                    rollTwelve[j] = random.Next(7);
                }

                foreach (int var in rollSix)
                {
                    if (var == 1)
                    {
                        oneWin++;
                        break;
                    }
                }

                int amnt = 0;
                foreach (int var in rollTwelve)
                {
                    if (var == 1)
                    {
                        amnt++;
                        if (amnt >= 2)
                        {
                            twoWin++;
                            break;
                        }
                    }
                }
            }

            double sixRoll = (double) oneWin / iterations;
            double twelveRoll = (double) twoWin / iterations;
            
            Console.WriteLine("Six roll win rate "+sixRoll+", Twelve roll win rate "+twelveRoll);
        }
    }
}