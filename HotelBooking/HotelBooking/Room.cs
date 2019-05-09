using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    public class Room
    {
        private int amtOfRooms;
        int[] roomTxtFile;
        int roomNumber;
      

        public string RoomNumber { get; set; }
        public bool Balcony { get; set; }
        public bool DownForRepair { get; set; }
        public bool NumberOfBeds { get; set; }

        public Room() { }

        public Room(string roomNumber, bool balcony, bool repair, bool numberOfBeds)
        {
            roomNumber = RoomNumber;
            balcony = Balcony;
            repair = DownForRepair;
            numberOfBeds = NumberOfBeds;
        }

        public void MakeRoom()
        {
            roomNumber = 12;// I need to figure out how topull from the RoomList.txt to populate 
                            //ReadyList.txt
            Balcony = true;
            DownForRepair = false;
            NumberOfBeds = true;
            //Smoking = false;
            //I will need to save this to ReadyList.txt and be able to append DownForRepair

        }
    }
}
