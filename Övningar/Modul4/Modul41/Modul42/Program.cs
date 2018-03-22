using System;

namespace Modul42
{
    class Program
    {
        static void Main(string[] args)
        {

            string names = GetInputFromUser();
            string[] namelist = CreateArrayOfPeople(names, ',');
            RespondToUser(namelist);

        }
        static string GetInputFromUser()
        {
            Console.Write("Enter names seperated by comma( e.g Maria, Peter,Lisa):");
            string names = Console.ReadLine();
            return names;
        }
        static string[] CreateArrayOfPeople(string names, char separator = ',')
        {

            string[] list = names.Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            return list;
        }
        static void RespondToUser(string[] namelist)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string person in namelist)
            {
                Console.WriteLine("***SUPER-" + person.Trim().ToUpper() + "***");

            }
            Console.ResetColor();

        }
    }
}
