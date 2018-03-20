using System;

namespace Modul61
{
    class Test
    {
        static void Main(string[] args)
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            mycube.WriteVolume();
            supercube.WriteVolume();
        }
    }
    class Cube
    {
        int _length;
        int _height;
        int _depth;

        public Cube(int height, int length, int depth)
        {
            _length = length;
            _height = height;
            _depth = depth;


        }

        public void mycube()
        {
        

        }
        public void mysupercube()
        {



        }
        public void WriteVolume()
        {
            double volume = _length * _height * _depth;
            Console.WriteLine($"The volume of the cube is {volume}");
           


        }
    }
}
