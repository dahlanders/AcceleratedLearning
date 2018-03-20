using System;

namespace Modul63
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(5, 6, 7);
            Rectangle myRectangle = new Rectangle(10, 20, 30, 40);
            Triangle myTriangle = new Triangle(15, 25, 35,45);
            Console.WriteLine(myCircle);
            Console.WriteLine(myRectangle);
            Console.WriteLine(myTriangle);
        }
    }
    class Circle
    {
        
        double _radius;
        int _x;
        int _y;

        public Circle( int x, int y, double radius)
        {
            
            _radius = radius;
            _x = x;
            _y = y;
        }

        public void SayHello()
        {
            Console.WriteLine();


        }
        public override string ToString()
        {
            return ($"I am a circle with{_x},{_y} and {_radius}");
        }
    }

    class Rectangle
    {
        int _x;
        int _y;
        int _height;
        int _width;

        public Rectangle(int x, int y, int height, int width)
        {
            _x = x;
            _y = y;
            _height = height;
            _width = width;
        }
        public override string ToString()
        {
            return ($"I am a rectangle with{_x},{_y}, {_height} and {_width}");
        }
    }
    class Triangle
    {
        int _x;
        int _y;
        int _height;
        int _baselength;


        public Triangle(int x, int y, int height, int baselength)
        {
            _x = x;
            _y = y;
            _height = height;
            _baselength = baselength;

        }
        public override string ToString()
        {
            return ($"I am a triangle with{_x},{_y}, {_baselength}  and {_height}");
        }

    }
}
