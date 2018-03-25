using System;
using System.Text;


namespace Modul53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text");
            string firstLine = Console.ReadLine();
            Console.Write("Enter a text");
            string secondLine = Console.ReadLine();

            StringBuilder sb = new StringBuilder();


            sb.Append(firstLine).Append(secondLine);
            Console.WriteLine(sb);
            
           
        }
        //public string ChangeString()
        //{
            

        //}
        //public string ChangeCoord()
        //{
        //    Console.Write("Enter old x:");
        //    string x = Convert.ToString(Console.ReadLine());
        //    Console.Write("Enter new x:");
        //    string xnew = Convert.ToString(Console.ReadLine());

        //    Console.Write("Enter old y:");
        //    string y = Convert.ToString(Console.ReadLine());
        //    Console.Write("Enter new y:");
        //    string ynew = Convert.ToString(Console.ReadLine());

        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("The initial coord of X and Y: '{0}'  '{1}' ", x, y);
        //    x = x.Replace(x, xnew);
        //    y = y.Replace(y, ynew);
        //    Console.WriteLine("The final coord of X and Y: '{0}'  '{1}'", x, y);
        //    Console.ResetColor();
        }
    }

