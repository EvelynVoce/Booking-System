using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        public int DoctorID { get; set; }
        
        public string Surgery { get; set; }
        
        public DateTime DateAndTime { get; set; }
    }
}
