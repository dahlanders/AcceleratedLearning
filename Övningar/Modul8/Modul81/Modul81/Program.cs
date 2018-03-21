using System;

namespace Modul81
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pices = HowManyPices();

            Console.Write("How many people are you?:");
            decimal people = Convert.ToInt32(Console.ReadLine());

            //decimal count = pices / people;
            //Console.WriteLine("Pices per people" + count);

            try
            {
                if (people == 0)
                {
                    throw new ArgumentException("People kan inte vara 0");
                }
                throw new Exception("Detta är en test");

            }
            catch (Exception e)
            {
                Console.WriteLine("Fel inpu");
            }
        }
        static decimal HowManyPices()
        {
            Console.Write("How many pices do you want to share?:");
            decimal pices = decimal.Parse(Console.ReadLine());
            return pices;
        }
    }
}
