using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_book_click(object sender, EventArgs e)
        {
            string chosenSurgery = surgeryDrop.Text;
            string chosenDoctor = doctorDrop.Text;

            string SelectedTime = timeBox.SelectedItem.ToString();

            DateTime SelectedDateTime = DateTime.Parse(SelectedTime);

            DataAccess db = new DataAccess();
            int selectedDoctorID = db.GetDoctorID(chosenDoctor)[0];
            db.createBooking(chosenSurgery, selectedDoctorID, SelectedDateTime);
            valuesChanged();
        }

        private void valuesChanged()
        {
            string chosenSurgery = surgeryDrop.Text;
            string chosenDoctor = doctorDrop.Text;

            if (chosenSurgery != "" && chosenDoctor != "")
            {
                timeBox.Items.Clear();
                DateTime dateWithIncorrectTime = dateTimePicker1.Value;
                DateTime chosenDate = dateWithIncorrectTime.Date.Add(new TimeSpan(9, 0, 0));

                DataAccess db = new DataAccess();
                int selectedDoctorID = db.GetDoctorID(chosenDoctor)[0];

                List<DateTime> allDateTimes = new List<DateTime> { chosenDate };
                for (int i = 1; i < 17; i++)
                    allDateTimes.Add(allDateTimes[0].AddMinutes(i*30));

                List<DateTime> bookedDateTimes = db.availability(chosenSurgery, selectedDoctorID, chosenDate);
                List<DateTime> availableDateTimes = allDateTimes.Except(bookedDateTimes).ToList();

                foreach (var v in availableDateTimes)
                    timeBox.Items.Add(v);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            valuesChanged();
        }

        private void doctorDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesChanged();
        }

        private void surgeryDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesChanged();
        }
    }
}
