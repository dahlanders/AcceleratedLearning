


using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint01.AndersDahl
{
    class App
    {
        public void Run()

        {
            Run3();
        }
        public void Run2()
        {
            Console.Write("Ange kommando:");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            for (int row = 1; row <= input; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public void Run3()
        {

            Console.Write("Ange kommando:");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange kommando:");
            Console.ForegroundColor = ConsoleColor.Green;
            var input2 = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            //List<int> list = new List<int>();
            int a, b, c;
            int i, j, k;
            for (i = 0; i <= input; i++)
            {
                for (j = 1; j <= input - i; j++)
                {
                    Console.Write("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (a = 1;  a <= input2; a++)
            {
                for (b = 1; b <= input2 - a; b++)
                {
                    Console.Write("");
                }
                for (c = 1; c <= a; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
