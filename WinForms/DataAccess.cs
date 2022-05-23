using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Globalization;

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
            var cultureInfo = new CultureInfo("en-GB");
            var endDate = date.AddDays(1);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDatabase")))
            {
                var x = date.ToString("o");
                var y = endDate.ToString("o");


                return connection.Query<DateTime>($"SELECT DateAndTime FROM Appointments WHERE Surgery = '{ surgeries }' AND DoctorID = { doctor } " +
                    $"AND DateAndTime > '{date:o}' AND DateAndTime < '{endDate:o}'").ToList();
            }
        }
    }
}
