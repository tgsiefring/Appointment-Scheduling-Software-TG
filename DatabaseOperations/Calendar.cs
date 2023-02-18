using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Appointment.DatabaseOperations
{
    class Calendar
    {   //Sql query used to populate a datagridview for the calendar for (all radio button) checked.       
        public static string selectCalendarAll = "SELECT appointmentId, customerId, userId, type, start, end FROM appointment order by appointmentId;";

        //Obtains missing parts of string to return the complete select string for the calendar for (week or month radio button) checked.
        public static string GetSelectCalendarWMString(string start, string end)
        {
            string selectCalendarWM = "SELECT appointmentId, customerId, userId, type, start, end FROM appointment WHERE (start BETWEEN ' " + start + " ' AND ' " + end + " ');";
            return selectCalendarWM;
        }

        //Populates table with appointment data to serve as datasource for a datagridview.  
        public static DataTable FillCalendarTable(string s, DataTable dt)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(s, DBConnection.conn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                mda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }       
    }
}
