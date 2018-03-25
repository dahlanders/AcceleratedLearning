using System;

namespace Modul91
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter a string to convert:");
            var con1 = Console.ReadLine();
            var resCon1 = ToSUpper(con1);
            Console.WriteLine(resCon1);

            Console.Write("Enter a string to convert:");
            var con2 = Console.ReadLine();
            var resCon2 = ToTripple(con2);
            Console.WriteLine(resCon2);

            Console.Write("Enter a string to convert:");
            var con3 = Console.ReadLine();
            var resCon3 = AddStars(con3);
            Console.WriteLine(resCon3);
        }
        static string ToSUpper(string input)
        {
            string result = input.ToUpper();
            return result;
        }
        static string ToTripple(string input)
        {
            string result = input + input + input;
            return result;
        }
        static string AddStars(string input)
        {
            string x = "";
            foreach (char n in input)
            {
                x += n + "*";
            }return x.Trim('*');
            
        }
    }
}
