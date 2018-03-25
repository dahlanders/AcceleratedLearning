using System;
using System.Diagnostics;

namespace testa
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"Cycles:\t\t\tLength of string:\t\t\tTime:");
            TakeTimeWithStopwatch("Tennis, anyone?", 10);
            TakeTimeWithStopwatch("Tennis, anyone?", 50);
            TakeTimeWithStopwatch("Tennis, anyone?", 500);
            TakeTimeWithStopwatch("Tennis, anyone?", 5000);
            TakeTimeWithStopwatch("Tennis, anyone?", 50000);

        }

        public static string GenerateString(string repeatMe, int cycles)
        {
            var message = "";
            for (int i = 0; i < cycles; i++)
            {
                message += repeatMe;
            }
            return message;
        }

        public static void TakeTimeWithStopwatch(string repeatMe, int cycles)
        {
            var message = "";
            Stopwatch test1 = new Stopwatch();
            test1.Start();
            for (int i = 0; i < cycles; i++)
            {
                message = message + repeatMe;
            }
            test1.Stop();
            var lengthOfString = message.Length;
            Console.WriteLine($"{cycles}\t\t\t{lengthOfString}\t\t\t\t\t{test1.Elapsed.TotalMilliseconds}");
            Console.WriteLine();
        }
    }
}