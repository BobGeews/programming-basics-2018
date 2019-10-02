using System;

using System.IO;

namespace ReferenceNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            //string path = @"C:\TEMP\referencenumber.txt";
            string message = "";

            do
            {
                choice = UserInterface();
                switch (choice.ToUpper())
                {
                    case "1":
                        if (CheckRefNum())
                        {
                            message = "\nSyöttämäsi viitenumero on oikein.";
                        }
                        else
                        {
                            message = "\nSyöttämäsi viitenumero on väärin.";
                        }
                        break;

                    case "2":
                        
                        
                        message = "\nKotimainen viitenumero on luotu.";
                        break;

                    case "3":
                        //CreateRefNumberFile(path);
                        message = "\nHaluamasi määrä viitenumeroita on luotu ja tallennettu tiedostoon.";
                        break;

                    case "X":
                        message = "\nOhjelman suoritus on päättynyt. Paina enter.";
                        break;

                    default:
                        message = "Komentoa ei löydy. Valitse 1, 2, 3 tai X poistuaksesi ohjelmasta";
                        break;
                }

                Console.WriteLine(message);
                Console.ReadLine();
                Console.Clear();
            }

            while (choice.ToUpper() != "X");

        }

        static string UserInterface()
        {
            Console.WriteLine("Tervetuloa viitenumero-ohjelmaan! Syötä haluamasi vaihtoehto.");
            Console.WriteLine("( 1 ) Tarkasta kotimainen viitenumero");
            Console.WriteLine("( 2 ) Luo kotimainen viitenumero");
            Console.WriteLine("( 3 ) Luo kotimaisia viitenumeroja ja tallenna ne tiedostoon");
            Console.WriteLine("( X ) Lopeta ohjelmansuoritus");

            Console.WriteLine();

            Console.Write("Mitä tehdään? ");

            return Console.ReadLine();
        }

        static bool CheckRefNum()
        {
            Console.WriteLine("Syötä kotimainen viitenumero.");
            string refNumber = Console.ReadLine();

            string multiplier = "731";
            int addUp = 0;
            int checkerNumber;
            int nextTenth;

            for (int i = 0; i < refNumber.Length - 1; i++)
            {
                addUp += int.Parse(refNumber[refNumber.Length - 2 - i].ToString()) * int.Parse(multiplier[i % 3].ToString());
                ;
            }

            nextTenth = (int)Math.Ceiling((decimal)addUp / 10) * 10;
            checkerNumber = nextTenth - addUp;

            if (checkerNumber == 10)
            {
                checkerNumber = 0;
            }

            if (refNumber[refNumber.Length - 1].ToString() == checkerNumber.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void CreateRefNum(int length)
        {
            var numbers = "0123456789";
            string multiplier = "731";
            int addUp = 0;
            int nextTenth;
            int checkerNumber;

            var refNumbers = new char[length];
            Random aNumber = new Random();
            for (int i = 0; i < length; i++)
            {
                refNumbers[i] = numbers[aNumber.Next(length)];
                if (refNumbers[0] == '0')
                {
                    i--;
                }
            }

            var finalRefNumbers = new String(refNumbers);

            for (int i = 0; i < length; i++)
            {
                addUp += int.Parse(finalRefNumbers[length - 1 - i].ToString()) * int.Parse(multiplier[i % 3].ToString());
                ;
            }

            nextTenth = (int)Math.Ceiling((decimal)addUp / 10) * 10;
            checkerNumber = nextTenth - addUp;

            if (checkerNumber == 10)
            {
                checkerNumber = 0;
            }

            Console.WriteLine($"Uusi viitenumero: {finalRefNumbers.Insert(3, " ")}{checkerNumber}");
        }
    }
}


