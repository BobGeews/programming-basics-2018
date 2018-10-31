using System;

namespace Functions1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            Console.WriteLine("Syötä 10 lukua.");
            Console.WriteLine($"Suurin luku oli {LargesNumber(ref index)} oli {index}.");
        }
        static int LargesNumber(ref int index)
        {
            int LargesNumber=0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}. ");
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber < 0)
                {
                    Console.WriteLine("Väärä syöte. Syötä positiivinen luku!!!");
                    i--;
                }
                if (userNumber > LargesNumber)
                {

                }
            }

            return LargesNumber;


        }
    }
}
