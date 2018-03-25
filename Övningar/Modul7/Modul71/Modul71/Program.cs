using System;

namespace Modul71
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Elevator("Lisa", 1 ,10, 20);
            var e2 = new Elevator("Bosse", 5, 1, 10);

            e1.GoUp();
            e2.GoDown();

            Console.WriteLine(e1.Report());
            Console.WriteLine(e1.TotalNumbersUpsandDown);
            Console.WriteLine(e2.Report());
            Console.WriteLine(e2.TotalNumbersUpsandDown);
        }
    }
}
