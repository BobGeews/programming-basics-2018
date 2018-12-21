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
                choise = UserInterface();
                switch (choise.ToUpper())

                {
                    case "Q":

                        if (Viitteentarkistus())
                        {
                            Console.WriteLine("Syöttämäsi viitenumero on oikein");

                        }
                        else
                        {
                            Console.WriteLine("Syöttämäsi viitenumero on väärin");
                        }
                        break;

                    case "W":

                        


                        break;

                    case "E":


                        break;

                    default:
                        Console.WriteLine("Valitse Q, W, E, X");
                        break;

                }
            }
            while (choise.ToUpper() != "X");


        }

        static string UserInterface()
        {
            Console.WriteLine();
            Console.WriteLine("[Q] Tarkasta jo olemassa oleva viitenumero.");
            Console.WriteLine("[W] Generoi viitenumeron.");
            Console.WriteLine("[E] Generoi haluttu määrä viitenumeroita.");
            Console.WriteLine("[X] Sulje ohjelma.");

            return Console.ReadLine();
        }


        static bool Viitteentarkistus()
        {
            Console.Write("Syötä viitenumero: ");
            string refNum = Console.ReadLine();

            string kertoimet = "731";
            int bump = 0;

            for (int i = 0; i < refNum.Length - 1; i++)
            {
                bump += int.Parse(refNum[refNum.Length - 2 - i].ToString()) * int.Parse(kertoimet[i % 3].ToString());


            }
            

            int seuraavakybä = (int)Math.Ceiling((decimal)bump / 10) * 10;
            int tarkiste = seuraavakybä - bump;

            if (tarkiste == 0)
            {
                tarkiste = 0;
            }
            if (refNum[refNum.Length - 1].ToString() == tarkiste.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }

        }




        
        




    }

}
