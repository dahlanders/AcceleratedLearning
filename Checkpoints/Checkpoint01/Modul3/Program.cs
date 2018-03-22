using System;

namespace Modul3
{
    class Program
    {
        static void Addstars(int numberOfStars)
        {
            for (int col = 1; col <= numberOfStars; col++)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {

            Console.Write("Ange kommando:");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            string[] nameList = input.Split('-');

            foreach (string s in nameList)
            {

                // A12
                if (s.ToUpper().StartsWith("A"))
                {
                    var x = s.Remove(0, 1);

                    int numberOfStart = int.Parse(x);

                    for (int starCount = 1; starCount <= numberOfStart; starCount++)
                    {
                        Addstars(starCount);
                        Console.WriteLine();
                    }

                }  else 
                
                if (s.ToUpper().StartsWith("B"))
                {
                    var y = s.Remove(0,1);

                    int numberOfStart = int.Parse(y);

                    for (int starCount = numberOfStart; starCount >= 1; starCount--)
                    {
                        Addstars(starCount);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
