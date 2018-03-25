using System;

namespace Chekpoint2
{

    class Program
    {
        static void Main()
        {
            var r1 = new Room("Kök",10);
            var r2 = new Room("Toa",20);
            var r3 = new Room("Vardagsrum",30);


            Console.WriteLine(r1.Report());
        }
    }
}
