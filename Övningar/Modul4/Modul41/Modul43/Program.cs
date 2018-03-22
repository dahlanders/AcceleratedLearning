using System;

namespace Modul43
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeatMainLoop = true;
            while (repeatMainLoop)
            {
                bool repeatValidateInput = true;
                string names = string.Empty;
                string[] namelist = null;


                while (repeatValidateInput)
                {
                    names = GetInputFromUser();
                    namelist = CreateArrayOfPeople(names, ',');
                   

                    bool namesIsValid = ValidateNames(names);
                    bool numberIsValid = ValidateNumbersOfChars(namelist);

                    if (namesIsValid && numberIsValid)
                    {
                        repeatValidateInput = false;

                    }

                }

                RespondToUser(namelist);

                repeatMainLoop = false;
            }
        }

        static bool ValidateNames(string names)
        {
            if (string.IsNullOrEmpty(names))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list dont contains any names");
                Console.ResetColor();
                return false;
            }

            return true;
        }

        public static bool ValidateNumbersOfChars(string[] namelist)
        {
            foreach (string names in namelist)
            {
                if (names.Length <= 2 || names.Length >= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A person can only have 2 to 9 letters");
                    Console.ResetColor();
                    return false;
                }
            }
            return true;
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
