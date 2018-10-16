using System;

namespace Looptask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tulostaa vakioveikkauksen rivin jossa 13 kohdetta. 1=kotivoitto, x=tasapeli, 2=vierasvoitto.");
            double rndNumber;
            Random rnd = new Random();
            for (int i = 1; i < 14; i++)
            {
              rndNumber = rnd.NextDouble();
                if (rndNumber <= 0.4)
                {
                    Console.WriteLine($"{i}\t 1");

                }
                else if (rndNumber > 0.4 && rndNumber < 0.7)
                {
                    Console.WriteLine($"{i}\t x");
                }
                else
                {
                    Console.WriteLine($"{i}\t 2");
                }




            }
        }
    }
}
