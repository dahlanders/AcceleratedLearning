using System;

namespace Modul431
{
    class Program
    {
        static bool errorsettings;
        static void Main()
        {

            var separator = AskUserForSeparator();
            errorsettings = AskUserForErrorMessage();
            while (true)
            {

                var Mynames = Validlist(separator);
                var Mylist = cleanuparray(Mynames);
                printlist(Mylist, ConsoleColor.Green);
                Console.WriteLine("Do you want to fortsatta Yes/No");
                if (Console.ReadLine() == "no")
                    break;
            }


        }

        static string getInfo()
        {
            while (true)
            {
                Console.WriteLine("Enter some names:");
                var names = Console.ReadLine();

                if (names.Length <= 0)
                {
                    errormessage("Du får inte ange ett tomt värde");

                    continue;
                }
                return names;
            }

        }

        static string[] getlist(string Mynames, char separator)
        {
            string[] nameList = Mynames.Split(separator);
            foreach (string name in nameList)
            {
                if (name.Length < 2 || name.Length > 9)
                {
                    errormessage("Namnet must vara mellan 2 och 9 bokstaver");

                    continue;
                }

            }
            return nameList;

        }
        static void printlist(string[] Mylist, ConsoleColor color)
        {
            foreach (string name in Mylist)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"***SUPER-{name.ToUpper().Trim()}***");
                Console.ResetColor();
            }

        }

        static string[] cleanuparray(string[] input)
        {
            string[] temp = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                temp[i] = input[i].Trim();
            }
            return temp;
        }
        static string[] Validlist(char separator)
        {

            while (true)
            {
                var Mynames = getInfo();
                string[] nameList = getlist(Mynames, separator);
                bool testifinvalid = false;
                foreach (string name in nameList)
                {
                    if (name.Length < 2 || name.Length > 9)
                    {
                        errormessage("Namnet must vara mellan 2 och 9 bokstaver");

                        testifinvalid = true;
                        break;
                    }
                }
                if (testifinvalid == false)
                {
                    return nameList;
                }
            }
        }
        static char AskUserForSeparator()
        {
            Console.WriteLine("Enter a tecken to separera med:");
            char separator = Convert.ToChar(Console.ReadLine());

            return separator;

        }
        static bool AskUserForErrorMessage()
        {
            Console.WriteLine("Do you want to see a error massage(default is yes):");
            string message = Console.ReadLine();

            switch (message.ToLower())
            {
                case "no":
                    return false;

                default:
                    return true;
            }
        }
        static void errormessage(string message)
        {
            if (errorsettings)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }


    }
}
