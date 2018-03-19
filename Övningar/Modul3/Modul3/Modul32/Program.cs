using System;

namespace Modul32
{
    class Program
    {
        static void Main(string[] args)
        {
            Extra21();
        }
        static void Test()
        {
            Console.Write("Enter your name:");
            var input = Console.ReadLine();
            Console.Write("Reapet times:");
            int reapetTimes = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < reapetTimes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your name is {input}");
                Console.ResetColor();
                i++;
            }


        }
        static void Extra2()
        {
            Console.Write("Enter your name:");
            var input = Console.ReadLine();
            Console.Write("Reapet times:");
            int reapetTimes = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < reapetTimes)
            {
                {
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Your name is {input}");
                        i++;
                        Console.ResetColor();
                    }
                }
            }

        }
        static void Extra21()
        {
            Console.Write("Enter your name:");
            var input = Console.ReadLine();
            Console.Write("Reapet times:");
            int reapetTimes = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (true)
            {
                int value = i++;
                if (value < reapetTimes)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your name is {input}");
                    Console.ResetColor();
                    continue; ;
                }
                break;
            }
        }

    }
}
