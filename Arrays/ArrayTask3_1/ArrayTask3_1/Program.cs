using System;

namespace ArrayTask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma joka arpoo taulukkoon lukuja 0-20 väliltä.");
            int[] taulukko = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < taulukko.Length; i++)
            {
                taulukko[i] = rnd.Next(20);              
            }
        }
    }
}
