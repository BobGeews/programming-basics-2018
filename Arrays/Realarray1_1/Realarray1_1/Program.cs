using System;

namespace Realarray1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuotteiden hinta taulukko.");
            decimal[] productprice = new decimal[] { 7.96m, 72.0m, 99.90m };
            int[] productamount = new int[] { 1, 3, 2 };
            decimal[] producttotalprice = new decimal[3];

            for (int i = 0; i < producttotalprice.Length; i++)
            {
                producttotalprice[i] = productamount[i] * productprice[i];
                Console.WriteLine($"Tuote {i + 1}. {producttotalprice[i]:c}");
            }
            
        }
    }
}
