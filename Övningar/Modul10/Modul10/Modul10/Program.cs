using System;
using System.Collections.Generic;

namespace Modul10
{
    class Program
    {
        static void Main(string[] args)
        {
            var productlist = new Dictionary<int, string>();

            while (true)
            {
                Console.Write("Enter a prouctcode");
                var readCode = Console.ReadLine();
                if (readCode.Length == 0)

                {
                    break;
                }

                var productCode = Convert.ToInt32(readCode);

                if (productlist.ContainsKey(productCode))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lika värde, testa nytt");
                    Console.ResetColor();
                    continue;
                }


                Console.Write("Enter a prouctname");
                var productName = Console.ReadLine();

                productlist.Add(productCode, productName);

            }
            foreach (var product in productlist)
            {
               
                Console.WriteLine(product.Key + "," + product.Value);
            }

        }
    }
}

