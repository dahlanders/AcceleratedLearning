using System;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ange namn och yta på rum:");
            string roomDataString = Console.ReadLine();
            string[] roomData = roomDataString.Split('|');

            var roomList = new List<Room>();

            foreach (var room in roomData)
            {
                var nameAndSize = room.Trim().Split(' ');

                var roomObject = new Room
                {
                    Name = nameAndSize[0],
                    Size = int.Parse(nameAndSize[1].Replace("m2", string.Empty))
                };

                roomList.Add(roomObject);
            }

            for (int i = 1; i <= roomList.Count; i++)
            {
                Console.WriteLine("* Rumsnamn " + i + ": " + roomList[i - 1].Name);
            }

            var biggestRoom = roomList.OrderByDescending(r => r.Size).First();

            Console.WriteLine("* Det största rummet är Rumsnamn " + biggestRoom.Name + " på " + biggestRoom.Size + "m2");
        }

        public class Room
        {
            public string Name { get; set; }
            public int Size { get; set; }
        }
    }
}
