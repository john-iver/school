using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
        }

        private void nonsmokinfRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }

        private void checkInExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkInBtn_Click(object sender, EventArgs e)
        {
            string customerName = $"Name: {firstNameTxtBx.Text} {lastNameTxtBx.Text}";
            string phoneNumber = $"Phone Number: {phoneNumTxtBx.Text}";
            string customerAddress = $"Address: {addressTxtBx.Text}";
            //need to figure out how to display room number

            //int numberOfRooms = int.Parse(numberOfRoomsTxtBx.Text);
            //int numOfBeds = int.Parse(multiRoomBedCountTxtBx.Text);

            DisplayInputInfoListBx.Items.Add(customerName);
            DisplayInputInfoListBx.Items.Add(phoneNumber);
            DisplayInputInfoListBx.Items.Add(customerAddress);

            string IDNumber = lastNameTxtBx.Text + phoneNumTxtBx.Text;
            long phoneIDNumber = long.Parse(phoneNumTxtBx.Text);
            Client client = new Client(IDNumber, firstNameTxtBx.Text,
                lastNameTxtBx.Text, addressTxtBx.Text, phoneIDNumber);//need to save this Client to a list and file ClientList.txt

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNameTxtBx.Clear();
            lastNameTxtBx.Clear();
            phoneNumTxtBx.Clear();
            addressTxtBx.Clear();
            numberOfRoomsTxtBx.Clear();
            //string IDNumber = lastNameTxtBx.Text + phoneNumTxtBx.Text;
            //long phoneNumber = long.Parse(phoneNumTxtBx.Text);

            //Client client = new Client(IDNumber, firstNameTxtBx.Text,
            //    lastNameTxtBx.Text,addressTxtBx.Text,phoneNumber);
        }

        private void groupBoxBed_Enter(object sender, EventArgs e)
        {

        }

        private void oneBedBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void twoBedBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
