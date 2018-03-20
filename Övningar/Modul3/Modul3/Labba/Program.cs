
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint01.AndersDahl
{
    class App
    {
        static void Main(string[] args)
        {

            Console.Write("Ange kommando:");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            string[] nameList = input.Split('-');

            foreach (string s in nameList)
            {
                int i = int.Parse(s);

                {


                    for (int row = 1; row <= i; ++row)
                    {


                        Addstars(row);
                        Console.WriteLine();



                    }
                }
            }
        }
        static void Addstars(int numberOfStars)
        {
            for (int col = 1; col <= numberOfStars; col++)
            {
                Console.Write("*");
            }
        }
    }
}




