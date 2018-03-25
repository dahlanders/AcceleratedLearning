using System;

namespace Modul35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name in a lsit ( like Maria,Peter,Lisa):");
            string names = Console.ReadLine();
            string[] nameList = names.Split('|');


            foreach (string s in nameList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
                Console.ResetColor();
            }

            for (int i = 1; i <= nameList.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Person"+i+":"+nameList[i-1]);
                Console.ResetColor();
            }
        }
    }
}

