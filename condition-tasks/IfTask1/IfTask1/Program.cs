using System;

namespace IfTask1
{
    //This one line comment
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma selvittää onko syötetty luku positiivinen, negatiivinen vai nolla.");
            Console.Write("Syötä luku: ");
            String userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0)
                Console.WriteLine($"Numero {number} on nolla!");
            else if (number < 0)
                Console.WriteLine($"Numero {number} on negatiivinen!");
            else
                Console.WriteLine($"Numero {number} on positiivinen!");

            Console.WriteLine($"Syötin numeron {userInput}");


        }
    }
}
