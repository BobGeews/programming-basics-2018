using System;

namespace merkkijono1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita jotain: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Syöttessä on {userInput.Length} kirjainta.");

            
        }
    }
}
