using System;

namespace ArrayTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaksiulotteinen taulukko.");
            int[,] taulukko;
            taulukko = new int[10, 20];
            Random rnd = new Random();
            Console.WriteLine("[x,y] = arvo");

            for (int x = 0; x <10; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    taulukko[x, y] = rnd.Next(100);
                    Console.WriteLine($"{x} {y}\t{taulukko[x, y]:d2}");
                }
            }
            
        }
    }
}
