using System;

namespace Modul37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number as setvalue:");
            int setnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            string classify;

            //if (number > setnumber)
                classify = "To high";
            //else
                classify = "Too low";

            classify = (setnumber < number) ? "To high" :(setnumber == number) ?"Equal" : "Too low";

            Console.WriteLine(classify);

        }
    }
}
