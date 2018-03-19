using System;

namespace Modul34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name in a lsit ( like Maria,Peter,Lisa):");
            string names = Console.ReadLine();
            string[] nameList = names.Split('-');

            while (true)
            {
                if (string.IsNullOrWhiteSpace(names))
                {
                    Console.WriteLine("Du måste ange ett namn:");
                    break;
                }

                else
                {
                    foreach (string s in nameList)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{s} Andersson");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
    }