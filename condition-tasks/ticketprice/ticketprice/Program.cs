using System;

namespace ticketprice
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ohjelma selvittää maatalousnäyttelyn lipunhinnan.");
            int ticketPrice = 16;
            double discount = 0.00; //ale
            int age = 0;
            string userInput;
            
                Console.Write("Oletko varusmies k/e ");
                userInput = Console.ReadLine();

                if

                     (userInput == "k")
                    discount = 0.50;

                else

                    Console.Write("Oletko opiskelija k/e ");
                userInput = Console.ReadLine();
            

                if

                (userInput == "k")

                    Console.Write("Oletko MTK jäsen k/e ");
                userInput = Console.ReadLine();

                if

                (userInput == "k")
                    discount = 0.60;

                else
                    discount = 0.45;
            
           Console.WriteLine($"Lipunhintasi on {ticketPrice - ticketPrice * discount} €");


            }
        }
    }

    

