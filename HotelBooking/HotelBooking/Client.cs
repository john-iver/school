using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking 
{
    class Client
    {
        Random rand = new Random(8);
        string CustumerIDNum { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        long PhoneNumber { get; set; }
        //string[] DoorPrizes = new string[8] { "I-Pod","I-Pad","$150 to Ohama Steaks",
         //   "Wine Gift Basket", "One Year of Beer Of the Month Club","$50 Visa Gift Card",
         //   "X-Box","PS4"};

        public Client(string custumerID, string firstName, string lastName,string address, long phone)
        {
            custumerID = CustumerIDNum;
            firstName = FirstName;
            lastName = LastName;
            address = Address;
            phone = PhoneNumber;
            
        }
        
    }
}
