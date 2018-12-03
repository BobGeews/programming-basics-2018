using System;
using System.IO;


namespace reference_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma joko tarkistaa viitenumeron, luo uuden viitenumeron tai luo halutun määrän viitenumeroita.");

            string choise = null;

            do
            {
                choise = userInterface();

                switch (choise.ToUpper())
                {
                    case "Q":
                        {
                            



                            break;
                        }
                    case "W":
                    break;

                    case "E":
                    break;
                }
            } while (choise.ToUpper() != "X");

            string userInterface()
            {
                Console.WriteLine("[Q] Tarkasta jo olemassa oleva viitenumero.");
                Console.WriteLine("[W] Generoi viitenumero.");
                Console.WriteLine("[E] Generoi haluttu määrä viitenumeroita.");
                Console.WriteLine("[X] Sulje ohjelma.");
                return Console.ReadLine();
            }

            
            
                
            
        }
    }
}
