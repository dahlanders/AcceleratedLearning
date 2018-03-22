using System;
using System.Collections.Generic;
using System.Text;

namespace Modul43
{
    public class NameValidation
    {
        public bool ValidateNames(string names)
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
    }
}
