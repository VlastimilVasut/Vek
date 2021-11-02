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
          Console.WriteLine("╔════════════════════════╗");
          Console.WriteLine("║Write your year of birth║:");
          Console.WriteLine("╚════════════════════════╝");   
            double.TryParse(Console.ReadLine(), out narozeni );
            if (narozeni < 1912)
            {
                 Console.WriteLine("╔════════════╗");
                Console.WriteLine($"║Invalid year║");
                 Console.WriteLine("╚════════════╝"); 
            }
            else
            {
                Console.ReadLine();

               
                vypocet = (DateTime.Now.Year - narozeni);
                if (vypocet > 100)
                { 
                     Console.WriteLine("╔═══════════════════════════════════════╗");
                    Console.WriteLine($"║Your age is {vypocet}, you are very old║"); }
                     Console.WriteLine("╚═══════════════════════════════════════╝");  
                if (vypocet >=65 & vypocet <=100)
                {
                     Console.WriteLine("╔═════════════════════════════════════╗");
                    Console.WriteLine($"║Your age is {vypocet}, you are senior║");
                     Console.WriteLine("╚═════════════════════════════════════╝"); 
                }
               if (vypocet >= 40 & vypocet <= 65)
                {
                     Console.WriteLine("╔══════════════════════════════════════════════╗");
                    Console.WriteLine($"║Your age is {vypocet}, you are an older person║");
                     Console.WriteLine("╚══════════════════════════════════════════════╝"); 
                }
            if (vypocet >=20 & vypocet <=40)
                {
                     Console.WriteLine("╔═══════════════════════════════════════════╗");
                    Console.WriteLine($"║Your age is {vypocet}, you are adult person║");
                     Console.WriteLine("╚═══════════════════════════════════════════╝"); 
                }
            if (vypocet >=13 & vypocet <= 20)
                {
                     Console.WriteLine("╔═══════════════════════════════════════╗");
                    Console.WriteLine($"║Your age is {vypocet}, you are teenager║");
                     Console.WriteLine("╚═══════════════════════════════════════╝"); 
                }
            if (vypocet >=0 & vypocet <=13)
                {
                     Console.WriteLine("╔══════════════════════════════════╗");
                    Console.WriteLine($"║Your age is {vypocet}, you are kid║");
                     Console.WriteLine("╚══════════════════════════════════╝"); 
                }
            }


          
         
            
        }
    }
}
