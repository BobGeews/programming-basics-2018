using System;

namespace ArrayTask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tulostaa taulukon.");
            int[] taulukko = new int[10];
            Rndtaulukko(ref taulukko);
        }

        static void Rndtaulukko(ref int[] taulukko1)
        {
            Random rnd = new Random();

            for (int i = 0; i < taulukko1.Length; i++)
            {
                taulukko1[i] = rnd.Next(21);
                Console.WriteLine($"{i}.\t{taulukko1[i]:d2}");
            }
        }
    }
}
