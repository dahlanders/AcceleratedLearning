using System;
using System.Collections.Generic;
using System.Text;

namespace Chekpoint2.Anders_Dahl
{
    public class Room
    {
        public string RoomName { get; set; }
        public int Size { get; set; }
        public Room(string roomname, int size)
        {
            RoomName = roomname;
            Size = size;

        }
        public string Report()
        {
            return $"{RoomName}";
        }
    }
}

