using System;

namespace Merkkijono3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee k kirjainten määrän syötteessä.");
            Console.Write("Kirjoita jotain: ");
            string userInput = Console.ReadLine().ToUpper();
            int laskuri = 0;
            
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'K')
                {
                    laskuri++;
                }
                

            }

            Console.WriteLine($"CIA löysi {laskuri} verran K kirjaimia tekstistäsi: {userInput}");

        }
    }
}
