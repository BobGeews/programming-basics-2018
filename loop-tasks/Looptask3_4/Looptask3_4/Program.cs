using System;

namespace Looptask3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee annetun luvun summan.");
            int number = 0;
            int i = 1;
            int summ = 0;
            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());

                
                

            } while (number <= 0);

            while (i <= number)
            {
                summ = summ + i; //summ=+i
                i = i + 1; //i++;
            }
            Console.WriteLine($"Luvun {number}! = {summ}");
        }
    }
}
