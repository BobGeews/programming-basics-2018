﻿using System;

namespace functions1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Käyttäjä antaa numeron 1-10 väliltä.");
            int number = numberFromRange(1, 10);
            Console.WriteLine($"Lukusi {number} on väliltä 1-10.");
        }

        static int numberFromRange(int lowerBound, int upperBound)
        {
            int allowedNumber;
            while (true)
            {
                Console.Write("Syötä luku: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (userInput >= lowerBound && userInput <= upperBound)
                {
                    allowedNumber = userInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte!");
                }
            }
            return allowedNumber;
        }

    }
}
