using System;

namespace Modul36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number as setvalue:");
            int setnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > setnumber)
            {
                Console.WriteLine($"It´s higher then {setnumber}");
            }
            else if(number == setnumber)
            {
                Console.WriteLine($"It´s equal to {setnumber}");
            }
            else
            {
                Console.WriteLine($"It´s lower then {setnumber}");
            }
        }
    }
}
