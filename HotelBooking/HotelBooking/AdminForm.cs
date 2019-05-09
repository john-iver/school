using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class AdminForm : Form
    {
        Random rand = new Random();
        int[] roomTxtFile;
        bool suite;

        public AdminForm()
        {
            InitializeComponent();
            
        }

        private void startingRoomNumberTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminEnterBtn_Click(object sender, EventArgs e)
        {
            int roomNumber = int.Parse(startingRoomNumTxtBx.Text);
            int amtOfRooms = int.Parse(amtRoomsTxtBx.Text);
            int twoBedRooms = int.Parse(twoBedRoomsTxtBx.Text);
            int smokingRooms = int.Parse(smokingRoomsTxtBx.Text);
            int balconyRooms = int.Parse(balconyRoomsTxtBx.Text);
            bool damagedRooms = false;
            bool isTwoBedRoom = true;
            bool isBalconyRoom = true;
            

            //this will write to a list starting with the starting with the starting room number
            //and going unitl it fills out the amount of rooms
            roomTxtFile = new int[amtOfRooms];
            for (int x = 0; x < amtOfRooms; ++x)
            {
                roomTxtFile[x] = roomNumber;
                ++roomNumber;

            }
            ////this makes my room numbers into a text file and saves it
            File.Delete(@"RoomList.txt");
            foreach (var room in roomTxtFile)
            {
                File.AppendAllText(@"RoomList.txt", room.ToString());
                File.AppendAllText(@"RoomList.txt", "\r\n\n");
             }

            //Room rooms = new Room(roomsForRent,isBalconyRoom,damagedRooms,isTwoBedRoom);
            //Room.MakeRoom();

            //clearing out text boxes//
            smokingRoomsTxtBx.Clear();
            startingRoomNumTxtBx.Clear();
            balconyRoomsTxtBx.Clear();
            amtRoomsTxtBx.Clear();
            twoBedRoomsTxtBx.Clear();

        }

        private void adminFormExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void suiteYesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            suite = true;
        }

        private void suiteNoRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            suite = false;
        }

        private void repairbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
