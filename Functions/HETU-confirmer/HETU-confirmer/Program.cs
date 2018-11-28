using System;

namespace HETU_confirmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tarkastaa henkilötunnuksen oikeellisuuden.");
            hetuCheck();
            
        }

        public static void hetuCheck()
        {
            Console.Write("Syötä henkilötunnuksesi: ");
            string userInput = Console.ReadLine();

            userInput = userInput.ToUpper();
            if (DateCheck(userInput))
            {
                string merkit = "0123456789ABCDEFHJKLMNPRSTUVWXY";
                char tarkiste = userInput[userInput.Length - 1];
                userInput = userInput.Remove(6, 1);
                userInput = userInput.Remove(9);
                int x = int.Parse(userInput);
                int hetuNumber = x % 31;


                if (tarkiste == merkit[hetuNumber])
                {
                    Console.WriteLine("Tunniste on oikein.");
                }
                else
                {
                    Console.WriteLine("Tunniste on väärä! Tarkista syöttämäsi henkilötunnus.");
                }
            }
            else
                Console.WriteLine("Virhe syötteessä!");

        }


        public static bool DateCheck(string userInput)
        {

            int day = int.Parse(userInput.Substring(0, 2));
            int month = int.Parse(userInput.Substring(2, 2));
            int year = int.Parse(userInput.Substring(4, 2));

            try
            {
                DateTime D = new DateTime(year, month, day);

            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;

        }


    }
}













