using System;

namespace Looptask4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma simuloi nopanheittoa 1000 kertaa ja näyttää kuinka monta kuutosta arvottiin.");
            Random rnd = new Random();
            int randomRnd;
            

            for (int i = 1; i < 1001; i++)
            {
                randomRnd = rnd.Next(7);
                Console.WriteLine($"{i}\t {randomRnd}");

            }
            
            

            
        }
    }
}
