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
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }

        private void exitBtnCheckOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finalCheckOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void prizeListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prizeListBx.Text= Client.GetPrize();
        }
    }
}
