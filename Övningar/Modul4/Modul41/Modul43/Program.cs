using System;

namespace Modul43
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
                if( person.Length >= 1 || person.Length > 10 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Namnet måste innehålla minst 2 bokstäver och max 9");
                }Console.WriteLine();

                Console.WriteLine("***SUPER-" + person.Trim().ToUpper() + "***");

            }
            Console.ResetColor();

        }
    }
}
