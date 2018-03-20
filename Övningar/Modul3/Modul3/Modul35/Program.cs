using System;

namespace Modul35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name in a lsit ( like Maria,Peter,Lisa):");
            string names = Console.ReadLine();
            string[] nameList = names.Split('-');


            foreach (string s in nameList)
            {
                if (s.Contains("Zelda"))
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
                Console.ResetColor();
            }
        }
    }
}

