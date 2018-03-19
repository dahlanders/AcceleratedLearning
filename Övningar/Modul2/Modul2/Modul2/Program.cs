using System;

namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?:");
            string name = Console.ReadLine();
            Console.Write("How old are you?:");
            string old = Console.ReadLine();
            Console.Write("What is your favorite letter?:");
            string letter = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Thank you!");

            Console.WriteLine("\t");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is:" +name);
            Console.WriteLine("Your are"+    old   + "years old");
            Console.WriteLine("Your favorite letter is:" + letter);
            Console.ResetColor();



        }
    }
}
