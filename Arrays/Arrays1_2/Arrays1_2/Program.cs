using System;

namespace Arrays1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tekee taulukon joka arpoo 100 lukua 0-50 väliltä ja laskee lukujen keskiarvon.");
            int[] luvut;
            luvut = new int[100];
            Random rnd = new Random();
            double summa = 0;
            double ka = 0;
            

            for (int i = 0; i < luvut.Length; i++)
            {
                luvut[i] = rnd.Next(50);
                summa += luvut[i];
                Console.WriteLine($"{i + 1}. {luvut[i]}");
                ka = summa / luvut.Length;
            }
            Console.WriteLine($"Arvottujen lukujen keskiarvo on {ka}.");


            


          
            
            

            


            
            
               
            
        

            

        }
    }
}
