using System;

namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ange kommando:");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            string[] nameList = input.Split('-');

            foreach (string s in nameList)
            {
                int numberOfStart = int.Parse(s);

                for (int starCount = 1; starCount <= numberOfStart; starCount++)
                {
                    Addstars(starCount);
                    Console.WriteLine();
                }
                 void Addstars(int numberOfStars)
                {
                    for (int col = 1; col <= numberOfStars; col++)
                    {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}