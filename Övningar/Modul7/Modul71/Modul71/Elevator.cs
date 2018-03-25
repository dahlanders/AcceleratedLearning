using System;
namespace Modul71
{
    public class Elevator
    {
        public string Name { get; set; }
        

        public int CurrentFloor { get; set; }
        public int MaxFloor { get; set; }
        public int MinFloor { get; set; }
        public int MAX_UpsAndDowns { get; set; }
        public int TotalNumbersUpsandDown { get; set; }
        //public int StartFloor { get; set; }
        public Elevator(string name,int startfloor , int minfloor, int maxfloor)
        {
            Name = name;
            CurrentFloor = startfloor;
            MinFloor = minfloor;
            MaxFloor = maxfloor;
            MAX_UpsAndDowns = 10;
            TotalNumbersUpsandDown = 0;
        }

        public void GoDown()
        {
            if (!NeedService())
            {
                if (CurrentFloor == MinFloor)
                {
                    Console.WriteLine($"Minsta våning för {Name} är {MinFloor} och den högsta våningen är {MaxFloor}");
                    return;
                }
                CurrentFloor--;
            }
        }

        public void GoUp()
        {
            if (!NeedService())
            {

                if (CurrentFloor == MaxFloor)
                {
                    Console.WriteLine($"Minsta våning för {Name} är {MinFloor} och den högsta våningen är {MaxFloor}");
                    return;
                }

                CurrentFloor++;
            }
        }
        public int Count => Math.Abs(MaxFloor - MinFloor) + 1;
        public string Report()
        {
            return $"Hissen {Name} är på våning {CurrentFloor} och det finns totalt {Count} våningar för {Name}";
        }
        public bool NeedService()
        {
            if (TotalNumbersUpsandDown == 10)
            {
                Console.WriteLine("Need Service");
                return true;
            }
            else
            {
                TotalNumbersUpsandDown++;
            }
            return false;
        }

    }
}
