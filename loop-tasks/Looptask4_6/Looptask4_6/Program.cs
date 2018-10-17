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
            int z = 0;
            
            for (int i = 1; i < 1001; i++)
            {
                
                do
                {
                    randomRnd = rnd.Next(7);

                } while (randomRnd == 0);

                if (randomRnd == 6)
                {
                    z++;
                }

                Console.WriteLine($"{i}\t {randomRnd}");

            }
            Console.WriteLine($"Kuutonen esiintyi {z} kertaa.");
            

            
        }
    }
}
