using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace Labba
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();


            Console.Write("How many fruits would you like to add?:");
            var noOfFruits = Convert.ToInt32(Console.ReadLine());

            var i = 0;
            for (i = 0; i < noOfFruits; i++)
            {

                Console.Write("Enter a fruit:");
                var fruit = Console.ReadLine();
                fruits.Add(fruit);
                

            }
            foreach (string fruit in fruits)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string fruity = string.Join(" ", fruit.ToArray());
                Console.WriteLine(fruity);
                Console.ResetColor();
            }
        }
    }
}
