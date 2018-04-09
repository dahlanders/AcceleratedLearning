using System;
using System.Collections.Generic;
using System.IO;

namespace Modul11
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            List<string> list = parser.CreateListOfNames("PersonShort.csv");


        }

    }

    class Parser
    {
        public Parser()
        {

        }
        public List<string> CreateListOfNames(string path)
        {
            //string fileName = @"C:\Project\AcceleratedLearning\Övningar\Modul11\Modul11\PersonShort.csv";
            //string path = @"C:\Project\AcceleratedLearning\Övningar\Modul11\Modul11";
            //string result;

            string result = string.Empty;
            string[] inDataFromFile = File.ReadAllLines(@"C:\Project\AcceleratedLearning\Övningar\Modul11\Modul11\PersonShort.csv");

            foreach (var line in inDataFromFile)
            {

                {
                    var split = line.Split(',');
                    var firstName = split[1];
                    var lastName = split[2];
                    Console.WriteLine(firstName);
                    Console.WriteLine(lastName);

                }

            }

            var list = new List<string>();
            return list;

        }

    }
}

