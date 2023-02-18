using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Appointment.DatabaseOperations
{
    class Appointment
    {   //Sql query used to populate a datagridview.
        public static string selectAppointments = "SELECT appointmentId, customerId, userId, type, start, end FROM appointment WHERE userId = @userId order by appointmentId;";

        //Alerts the current user of an appointment starting within the next 15 minutes(if any).
        public static void AppointmentAlert(string user)
        {
            DateTime userLogin = DateTime.Now.ToUniversalTime();
            DateTime appointmentSoon = userLogin.AddMinutes(15);
            String query2 = "SELECT EXISTS(SELECT * FROM appointment WHERE start <= @soon AND start >= @login AND userId = @userId)";
            MySqlCommand cmd2 = new MySqlCommand(query2, DBConnection.conn);
            cmd2.Parameters.AddWithValue("@userId", user);
            cmd2.Parameters.AddWithValue("@soon", appointmentSoon);
            cmd2.Parameters.AddWithValue("@login", userLogin);

            if (cmd2.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("You have an appointment starting within the next 15 minutes");
            }
            else
            {

            }
        }

        //Populates table with appointment data to serve as datasource for a datagridview        
        public static DataTable FillAppointmentTable(string s, DataTable dt, ComboBox cmbUser)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(s, DBConnection.conn);
                cmd.Parameters.AddWithValue("@userId", cmbUser.SelectedValue);
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

        //Inserts an appointment into the database.
        public static void InsertAppointment(string s, DateTimePicker start, DateTimePicker end)
        {
            MySqlCommand cmd = new MySqlCommand(s, DBConnection.conn);
            cmd.Parameters.AddWithValue("@start", start.Value.ToUniversalTime());
            cmd.Parameters.AddWithValue("@end", end.Value.ToUniversalTime());
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Obtains missing parts of string to return the complete insert appointment string.
        public static string GetInsertAppointmentString(string customerBox, string cmbUser, string typeBox)
        {
            string insert = "INSERT INTO  client_schedule.appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES('" + customerBox + "','" + cmbUser + "','na','na','na','na','" + typeBox + "','na',@start,@end,'" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test');";
            return insert;
        }

        //Deletes an appointment from the database.
        public static void DeleteAppointment(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgv.SelectedRows)
                    {
                        string value = dgv.SelectedRows[0].Cells[0].Value.ToString();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM appointment WHERE appointmentId =@Value", DBConnection.conn);
                        cmd.Parameters.AddWithValue("@Value", value);
                        int i = cmd.ExecuteNonQuery();

                        if (i != 0)
                        {
                            dgv.Rows.RemoveAt(item.Index);
                        }
                        else
                        {
                            MessageBox.Show("Deleted Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Updates the selected appointment in the database.
        public static void UpdateAppointment(DataGridView dgv, string customerBox, string cmbUser, string typeBox, DateTimePicker start, DateTimePicker end)
        {
            String query = "UPDATE appointment SET appointmentId = @appointmentId, customerId = @customerId, userId = @userId, type = @type, start = @start, end = @end WHERE appointmentId = @appointmentId;";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.Parameters.AddWithValue("@appointmentId", dgv.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@customerId", customerBox);
            cmd.Parameters.AddWithValue("@userId", cmbUser);
            cmd.Parameters.AddWithValue("@type", typeBox);
            cmd.Parameters.AddWithValue("@start", start.Value.ToUniversalTime());
            cmd.Parameters.AddWithValue("@end", end.Value.ToUniversalTime());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Determines if adding an appointment to the database would cause 2 appointments to overlap for a specific user and prevents adding of an overlapping appointment.
        public static bool AddAppointmentDetectOverlap(DateTimePicker start, DateTimePicker end, string cmbUser, bool overlap)
        {            
            try
            {  
                String query = "SELECT EXISTS(SELECT * FROM appointment WHERE end >= @start AND start <= @end AND userId = @userId)";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                cmd.Parameters.AddWithValue("@start", start.Value.ToUniversalTime());
                cmd.Parameters.AddWithValue("@end", end.Value.ToUniversalTime());
                cmd.Parameters.AddWithValue("@userId", cmbUser);

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    overlap = true;
                    return overlap;
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            overlap = false;
            return overlap;
        }

        //Determines if updating an appointment in the database would cause 2 appointments to overlap for a specific user and prevents an update that would cause overlapping appointments.
        public static bool UpdateAppointmentDetectOverlap(DateTimePicker start, DateTimePicker end, DataGridView dgv, bool overlap)
        {
            try
            {
                //Added AND appointmentId != @appointmentId, because updating an appointment would compare the new time with its old time and throw an overlap error message.
                //Example: changing a 10:00 to 10:30 appointment to 10:10 to 10:30 would overlap with itself and not allow the change.
                String query = "SELECT EXISTS(SELECT * FROM appointment WHERE end >= @start AND start <= @end AND appointmentId != @appointmentId)";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                cmd.Parameters.AddWithValue("@start", start.Value.ToUniversalTime());
                cmd.Parameters.AddWithValue("@end", end.Value.ToUniversalTime());
                cmd.Parameters.AddWithValue("@appointmentId", dgv.SelectedRows[0].Cells[0].Value.ToString());

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    overlap = true;
                    return overlap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            overlap = false;
            return overlap;
        }

        //Counts the number of rows in the appointment table.
        public static void AppointmentCount(Label appointment)
        {
            try
            {
                String query = "SELECT COUNT(*) FROM appointment;";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                Int32 countAppointment = Int32.Parse(cmd.ExecuteScalar().ToString());
                appointment.Text = countAppointment.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
