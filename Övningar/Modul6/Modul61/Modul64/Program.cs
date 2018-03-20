using System;

namespace Modul64
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Lisa = new Person("Lisa", "Persson", DateTime.Now.AddYears(-25), Gender.female, Sports.Curling);
            Console.WriteLine($"{Lisa.FirstName} is a {Lisa.Gender}");
            Console.WriteLine($"{Lisa.FirstName} like to play {Lisa.FavoriteSports}");
            Console.WriteLine($"{Lisa.FirstName} is a {Lisa.Gender}");
            Console.WriteLine($"{Lisa.FirstName} dont like to play {Lisa.FavoriteSports}");
        }
    }
    enum Sports
    {
        Tennis, Rugby, Soccer, Curling, Squash
    }

    enum Gender { male, female, other }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public Sports FavoriteSports { get; set; }




        string _firstname;
        string _lastname;
        DateTime _birthday;
        Gender _gender;
        Sports _favoritesport;

        public Person(string firstName, string lastName, DateTime birthday, Gender gender, Sports favoriteSport)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Gender = gender;
            FavoriteSports = favoriteSport;
        }

    }
}
