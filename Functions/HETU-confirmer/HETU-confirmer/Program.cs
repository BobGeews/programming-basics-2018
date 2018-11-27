using System;

namespace HETU_confirmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tarkastaa henkilötunnuksen oikeellisuuden.");
            string merkit = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            Console.Write("Syötä henkilötunnuksesi: ");
            string userInput = Console.ReadLine();

            userInput = userInput.Remove(6, 1);
            userInput = userInput.Remove(9);
            int x = int.Parse(userInput);
            int day =int.Parse(userInput.Substring(0, 2));
                int month
                int year
            try
            {
                DateTime D = new DateTime(1952, 10, 30);
                
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }




            int hetuNumber = x % 31;
            Console.WriteLine($"tulostetaan tarkaste {merkit[hetuNumber]}");

            
        }
    }
}
        



    

        
        
            

        
    

