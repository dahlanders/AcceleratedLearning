using System;

namespace Modul33
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Ange kommando:");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                Console.Write("Ange rader");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ange kolumner");
                int col = Convert.ToInt32(Console.ReadLine());
                int size = 20;
                string[] nameList = input.Split('-');

                foreach (string s in nameList)
                {
                   //int i = int.Parse(s);


                    for (int i = 0; i < row; ++i)
                    {
                        for (int j = 0; j< col ; j++)
                        {
                            Console.Write(Fill(s,size));
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
        static string Fill(string str, int size)
        {
            if (str.Length == size)
            {
                return str;
            }
            if (str.Length < size)
            {
                while (str.Length < size)
                {
                    str = str + " ";
                }
            }return str;
        }
    }
}
