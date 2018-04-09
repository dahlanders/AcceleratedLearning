using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Labben
{
    class SwitchTest
    {
        static void Main()
        {
            Console.WriteLine("Skriv in vilken del på huset du vill räkna på");
            Console.WriteLine(" 1 för vägg, 2 för grunden eller 3 för taket");
            Console.Write("Please enter your selection: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int cost = 0;
            switch (n)
            {
                case 1:
                    Console.WriteLine("Du valde väggarna");
                    
                    break;
                case 2:
                    Console.WriteLine("Du valde gruden");
                    break;
                case 3:
                    Console.WriteLine("Du valde taket");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            //Console.WriteLine("Thank you for your business.");
        }
    }
}