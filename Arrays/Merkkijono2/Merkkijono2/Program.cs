using System;

namespace Merkkijono2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma muuttaa kaikki e kirjaimet @ merkeiksi.");
            Console.Write("kirjoita jotain: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput.Replace("e", "@"));
        }
    }
}
