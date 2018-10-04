using System;

namespace LoopTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee parillisten ja parittomien lukujen summan niin montaka kertaa kuin käyttäjä syöttää");
            int i = 1;
            int number = 0;
            int evenSum = 0;
            int oddSum = 0;


                Console.Write("Syötä luku; ");
                number = int.Parse(Console.ReadLine());
            
            while(i <= number)
            {
                if (i % 2 == 0)
                {
                    evenSum += i; //evenSum = evenSum + i;
                   
                }
                else
                {
                    oddSum = oddSum + i;                    
                }
                i = i + 1;
            }
            Console.WriteLine($"Parillisten summa on {evenSum}");
            Console.WriteLine($"parittomien summa on {oddSum}");


            


        }

    }
}
