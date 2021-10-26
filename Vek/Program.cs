using System;

namespace Vek
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double narozeni = 0;
            double rok;
            double vypocet = 0;

            Console.CursorVisible = false;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine();
            Console.SetCursorPosition(10, 11);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Write your year of birth:");
            double.TryParse(Console.ReadLine(), out narozeni );
            if (narozeni < 1912)
            {
                Console.WriteLine($"Invalid year");
            }
            else
            {
                Console.ReadLine();

               
                vypocet = (DateTime.Now.Year - narozeni);
                if (vypocet > 100)
                { Console.WriteLine($"Your age is {vypocet}, you are very old"); }
                if (vypocet >=65 & vypocet <=100)
                {
                    Console.WriteLine($"Your age is {vypocet}, you are senior");
                }
               if (vypocet >= 40 & vypocet <= 65)
                {
                    Console.WriteLine($"Your age is {vypocet}, you are an older person");
                }
            if (vypocet >=20 & vypocet <=40)
                {
                    Console.WriteLine($"Your age is {vypocet}, you are adult person");
                }
            if (vypocet >=13 & vypocet <= 20)
                {
                    Console.WriteLine($"Your age is {vypocet}, you are teenager");
                }
            if (vypocet >=0 & vypocet <=13)
                {
                    Console.WriteLine($"Your age is {vypocet}, you are kid");
                }
            }


          
         
            
        }
    }
}
