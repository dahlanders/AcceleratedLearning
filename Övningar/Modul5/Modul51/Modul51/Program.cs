﻿using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Cycles:\t\t\tLength of string:\t\t\tTime:");
            Console.ResetColor();
            TakeTimeWithStopwatch("Tennis, anyone?", 5);
            TakeTimeWithStopwatch("Tennis, anyone?", 50);
            TakeTimeWithStopwatch("Tennis, anyone?", 500);
            TakeTimeWithStopwatch("Tennis, anyone?", 5000);
            TakeTimeWithStopwatch("Tennis, anyone?", 50000);
        //}
        //static string GenerateString(string repeat, int cycles)
        //{

        //    string message = "";

        //    for (int i = 0; i < cycles; i++)
        //    {
        //        message = repeat + "";


        //    }

        //    return message;

        }
        static string TakeTimeWithStopwatch(string repeat, int cycles)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string message = "";

            for (int i = 0; i < cycles; i++)
            {
                message = message + repeat;


            }
            stopwatch.Stop();
            var lengthOfString = message.Length;
            Console.WriteLine($"{cycles}\t\t\t{lengthOfString}\t\t\t\t\t{stopwatch.Elapsed.TotalMilliseconds}");
            return message;
        }
    }
}


