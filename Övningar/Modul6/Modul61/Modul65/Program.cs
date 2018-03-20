using System;

namespace Modul65
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress hem = new Adress("Bergsgatan", 7, "Varberg", 12365);
            Adress villan = new Adress("Kungsgatan", 10, "Stockholm", 45672);
            villan.GetFullStreet();
        }
    }
    class Adress
    {
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public Adress(string street, int streetnumber, string city, int zipcode)
        {
            Street = street;
            StreetNumber = streetnumber;
            City = city;
            ZipCode = zipcode;


        }
        public void GetFullStreet()
        {
            Console.WriteLine($"The full adress is {Street} {StreetNumber} {City} {ZipCode}");
        }


    }
}
