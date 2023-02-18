using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Appointment.DatabaseOperations
{
    class User
    {
        //Obtains missing parts of string to return the complete select users string.
        public static string GetSelectUsersString(string userBox, string passBox)
        {
            string selectUsers = "SELECT * FROM user WHERE userName = '" + userBox + "' AND password = '" + passBox + "'";
            return selectUsers;
        }

        //Utilizes GetSelectUsersString to compare entered username and password with database values to allow or disallow login attempts.
        public static DataTable LoginAttempt(string s, DataTable dt)
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

        //Populates a ComboBox with user data.
        public static void FillUserCombo(ComboBox user, DataSet ds)
        {
            try
            {
                string query = "SELECT userId FROM  user";
                MySqlDataAdapter mda = new MySqlDataAdapter(query, DBConnection.conn);
                mda.Fill(ds, "User");
                user.DisplayMember = "userId";
                user.ValueMember = "userId";
                user.DataSource = ds.Tables["User"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Counts the number of rows in the user table.
        public static void UserCount(Label user)
        {
            try
            {
                String query = "SELECT COUNT(*) FROM user;";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                Int32 countUser = Int32.Parse(cmd.ExecuteScalar().ToString());
                user.Text = countUser.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
