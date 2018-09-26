using System;

namespace Iftask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä sovellus laittaa kolme annettua lukua suuruus järjestykseen pienimmästä suurimpaan.");
            Console.Write("Anna luku. ");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);

            Console.Write("Anna toinen luku. ");
            userInput = Console.ReadLine();
            int y = int.Parse(userInput);

            Console.Write("Anna kolmas luku. ");
            userInput = Console.ReadLine();
            int z = int.Parse(userInput);

            Console.WriteLine($"Annoit luvut {x} - {y} - {z}");

            if (x < y && z < x)
            {
                Console.WriteLine($"järjestys on {z} - {x} - {y}");
            }
            else if (x < y && x < z && y < z)
            {
                Console.WriteLine($"Järjestys on {x} - {y} - {z}");
            }
            else if (x < y && x < z && z < y)
            {
                Console.WriteLine($"Järjestys on {x} - {z} - {y}");
            }
            else if (y < x && x < z)
            {
                Console.WriteLine($"Järjestys on {y} - {x} - {z}");
            }
            else if (y < x && z < x && y < z)
            {
                Console.WriteLine($"Järjestys on {y} - {z} - {x}");
            }
            else if (y < x && z < x && z < y)
            {
                Console.WriteLine($"Järjestys on {z} - {y} - {x}");
            }



















        }
    }
}
