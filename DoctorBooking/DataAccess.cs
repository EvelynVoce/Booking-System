using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace WinForms
{
    public class DataAccess
    {
        public List<int> GetDoctorID(string doctor)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDatabase")))
            {
                return connection.Query<int>($"SELECT DoctorID FROM Doctors WHERE DoctorName = '{ doctor }'").ToList();
            }
        }

        public List<DateTime> availability(string surgeries, int doctor, DateTime date)
        {
            DateTime endDate = date.AddDays(1);

            string queryString =
                "SELECT DateAndTime " +
                "FROM dbo.Appointments " +
                "WHERE Surgery = @surgery AND DoctorID = @doctorSQL " +
                "AND DateAndTime BETWEEN @dateSQL AND @endDateSQL";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDatabase")))
            {
                return connection.Query<DateTime>(queryString,
                    new { surgery = surgeries, doctorSQL = doctor, dateSQL = date, endDateSQL = endDate }).ToList();
            }
        }

        public void createBooking(string surgeries, int doctor, DateTime date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDatabase")))
            {
                Random rnd = new Random();
                int randomID = rnd.Next(10000, 99999);

                Appointment AppointmentBooking = new Appointment {AppointmentID = randomID, DoctorID = doctor, Surgery = surgeries, DateAndTime = date};
                connection.Execute("dbo.Appointments_Insert @AppointmentID, @DoctorID, @Surgery, @DateAndTime", AppointmentBooking);

            }
        }
    }
}
