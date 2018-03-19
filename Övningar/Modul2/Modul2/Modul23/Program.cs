using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Modul23
{
    class Program
    {
        static void Main(string[] args)
        {

            fruitlist();
        }
        static void fruit()
        {
            Console.Write("Enter fruit 1:");
            string fruit1 = Console.ReadLine();
            Console.Write("Enter fruit 2:");
            string fruit2 = Console.ReadLine();
            Console.Write("Enter fruit 3:");
            string fruit3 = Console.ReadLine();

            //Concatenation
            Console.WriteLine("You enterd three fruit:" + fruit1 + "," + fruit2 + "," + fruit3);
            //Using placeholders
            Console.WriteLine("You enterd three fruit: {0}, {1}, {2}", fruit1, fruit2, fruit3);
            //Interpolation
            Console.WriteLine($"You enterd three fruit: {fruit1},{fruit2},{fruit3}");
        }
        static void fruitStrBuild()
        {
            Console.Write("Enter a fruit :");
            string fruit1 = Console.ReadLine();
            Console.Write("Enter a fruit :");
            string fruit2 = Console.ReadLine();
            Console.Write("Enter a fruit :");
            string fruit3 = Console.ReadLine();

            StringBuilder userString = new StringBuilder("You entered three fruits:");
            userString.Append(fruit1.Trim() + ",");
            userString.Append(fruit2.Trim() + ",");
            userString.Append(fruit3.Trim() + "!");

            Console.WriteLine(userString);
        }
        static void fruitlist()
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
                Console.WriteLine(fruit);
                Console.ResetColor();
            }
        }
    }
}
