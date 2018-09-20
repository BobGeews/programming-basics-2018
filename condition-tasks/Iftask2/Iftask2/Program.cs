using System;

namespace Iftask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma selvittää onko luku parillinen vai pariton.");
            Console.Write("Syötä numero. ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number % 2 == 0)
                Console.WriteLine($"Luku {number} on parillinen.");
            else
                Console.WriteLine($"Luku {number} on pariton.");



        
        }
    }
}
