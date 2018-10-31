using System;

namespace Array1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ohjelma taulukoi lukuja 0-100 väliltä.");
            int[] numbers = new int[10];
            Random rnd = new Random();


            //Set values to array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
            }

            //Get values from array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }






            Console.WriteLine("Ohjelma päättyy.");
        }
    }

}
