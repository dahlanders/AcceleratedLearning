using System;

namespace Modul41
{
    class Program
    {
        static void Main(string[] args)
        {
            


            string[] nameList = names.Split(",");

            foreach (string name in nameList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***SUPER-" + name.ToUpper() + "***");
                Console.ResetColor();
            }


        }
        public void GetInputFromUser()
        {
            Console.Write("Enter names seperated by comma( e.g Maria, Peter,Lisa):");
            string names = Console.ReadLine();
            return names;

        }
    }
}
