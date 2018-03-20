using System;

namespace Modul61
{
    class Test
    {
        static void Main(string[] args)
        {
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);

            bob.SayHello();
            lisa.SayHello();

            Console.WriteLine();

            bob.WriteArea();
            lisa.WriteArea();
        }
    }
    class Circle
    {
        string _name;
        float _radius;

        public Circle(string name, int radius)
        {
            _name = name;
            _radius = radius;
        }

        public void SayHello()
        {
            Console.WriteLine($"I am a circle with the name of {_name}");


        }
        public void WriteArea()
        {
            double area = Math.Pow(_radius, 2) * Math.PI;
            Console.WriteLine($"My name is {_name}.I have the radius of {_radius} and an area of {area}");
        }
    }
}
