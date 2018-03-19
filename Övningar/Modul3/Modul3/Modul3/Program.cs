using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("When did you go to bed yesterday? ");
            int toSleep = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wokeUp = int.Parse(Console.ReadLine());

            int sleepTime = wokeUp +(24 - toSleep);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            if ( sleepTime < 6)
            {
                Console.WriteLine($" You slept for {sleepTime} hours, go to bed again");
            }

            else if (sleepTime > 6 && sleepTime <12)
            {
                Console.WriteLine($" You slept for {sleepTime} hours, That great");
            }
            else
            {
                Console.WriteLine($" You slept for {sleepTime} hours, That too much");
            }
        }
    }
}