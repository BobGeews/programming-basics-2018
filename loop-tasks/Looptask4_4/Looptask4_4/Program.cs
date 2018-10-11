using System;

namespace Looptask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolikonheitto");
            int number;
            int klaava = 0;
            int kruuna = 0;
            int rndNumber;
            Random rnd = new Random();
            
                Console.Write("Kuinka monta kertaa heitetään kolikkoa?: ");
                number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                rndNumber = rnd.Next(2);
                if (rndNumber == 1)
                {
                    kruuna = kruuna + 1;
                }
                else
                {
                    klaava = klaava + 1;
                }
            }

                Console.WriteLine($"Heittojen määrä {number}");
                Console.WriteLine($"Kruunien määrä {kruuna}");
                Console.WriteLine($"Klaavojen määrä {klaava}");
                    

            
            







        }
    }
}
