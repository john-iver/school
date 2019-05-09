using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    class Occupanicies
    {
        string ClientID { get; set; }
        string RoomNumber { get; set; }

        public Occupanicies( string clientID, string roomNumber)
        {
            clientID = ClientID;
            roomNumber = RoomNumber;
        }
    }
}
