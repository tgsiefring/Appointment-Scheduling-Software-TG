using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Appointment.DatabaseOperations
{
    class Reports
    {   //Populates TextBox with a report of the number of each type of appointment listed by month.
        public static void GenerateAppointmentReport(TextBox appointment)
        {
            appointment.Text = "Number of each type of appointment, by month\r\n\r\n";
            string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int monthInc = 1;

            for (int i = 0; i < Months.Length; i++)
            {
                string month = Months[i];
                appointment.Text = appointment.Text + month + "\r\n";
                string query = "SELECT type, count(*) FROM  appointment WHERE month(start) = " + monthInc++ + " group by type;";                
                DataTable dt = new DataTable();             
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    mda.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                foreach (DataRow row in dt.Rows)
                {
                    appointment.Text = appointment.Text
                                             + "\t"
                                             + string.Format("{0,-20}", row[0].ToString())
                                             + "\t"
                                             + string.Format("{0,-20}", row[1].ToString())
                                             + "\r\n";
                }
            }
        }
    }
}
