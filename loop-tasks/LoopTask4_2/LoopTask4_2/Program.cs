using System;

namespace LoopTask4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
                     
            Console.WriteLine("Tämä ohjelma näyttää kertotaulun luvuille 1-9.");
            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number*i}");
            }
        }
    }
}
