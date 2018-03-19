using System;

namespace Modul22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?:");
            string name = Console.ReadLine();
            Console.Write("How old are you?:");
            int old = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your favorite letter?:");
            string letter = Console.ReadLine();

            int until = 65 - old;

            int result = 0;

            Console.WriteLine();

                Console.WriteLine("Thank you!");

                Console.WriteLine("\t");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your name is:" + name);
                Console.WriteLine("Your have" + until + "years until retirement");
            if (int.TryParse(name, out result))

            {
                Console.WriteLine("You like numbers");
            }
            else
            {
                Console.WriteLine("You dont like number");
            }
            Console.ResetColor();
            }
        }
    }
