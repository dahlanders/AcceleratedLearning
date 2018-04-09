using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace ConsoleApp25
{
    class Program
    {
        public void App()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Ange namn och yta på rum:");
            Console.ResetColor();
            string roomDataString = Console.ReadLine();
          
            string[] roomData = roomDataString.Split('|');

            var roomList = new List<Room>();

            foreach (var room in roomData)
            {

                var nameAndSize = room.Trim().Split(' ');

                var roomObject = new Room
                {
                    Name = nameAndSize[0],
                    Size = int.Parse(nameAndSize[1].Replace("m2", string.Empty)),
                    Ljus = nameAndSize[2]
                };

                roomList.Add(roomObject);
            }

            for (int i = 1; i <= roomList.Count; i++)
            {
                Console.WriteLine("* Rumsnamn " + i + ": " + roomList[i - 1].Name);
            }

        
            var biggestroom = 1;
            var biggestroomname = "arne";
            var biggestroomlight = "Grå";

            foreach (var room in roomList)
            {
                if (room.Size > biggestroom)
                {
                    biggestroom = room.Size;
                    biggestroomname = room.Name;
                    biggestroomlight = room.Ljus;
                }

            }

                        
            var lightList = new List<string>();

        // Please use "och" as separator. If else, change in line 85.
            string printLigth = "Ljuset är tänt i ";
            foreach (var room in roomList)
            {
                if (room.Ljus == "På")
                {
                    lightList.Add(room.Name);
                   // printLigth += room.Name+" och ";
                }                  
            }var lightsJoin = string.Join(" och ", lightList);

            printLigth = (printLigth.TrimEnd(' ').TrimEnd('h').TrimEnd('c').TrimEnd('o'));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Det största rummet är {biggestroomname} och är på {biggestroom} och ljuset är {biggestroomlight}");
            Console.WriteLine($"Lägenheten består av {roomList.Count} rum");
            //Console.WriteLine(printLigth);
            Console.WriteLine("Ljuset är tänt i " + lightsJoin);

            Console.ResetColor();
        }

        public class Room
        {
            public string Name { get; set; }
            public int Size { get; set; }
            public string Ljus { get; set; }
        }
    }
}

