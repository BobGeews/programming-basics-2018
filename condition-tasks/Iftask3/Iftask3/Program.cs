using System;

namespace Iftask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma selvittää onko luku parillinen, pariton ja negatiivinen tai positiivinen.");
            Console.Write("Syötä numero. ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number < 0)

                    if (number % 2 == 0)
                        Console.WriteLine($"Luku {number} on parillinen ja negatiivinen.");
                    else
                        Console.WriteLine($"Luku {number} on pariton ja negatiivinen.");
            }
            if (isNumber)
            {
                if (number > 0)
                    if (number % 2 == 0)
                        Console.WriteLine($"Luku {number} on parillinen ja positiivinen");
                    else
                        Console.WriteLine($"Luku {number} on pariton ja positiivinen");
            }
            else
                Console.WriteLine("Väärä syöte! ");







        }
    }
}
