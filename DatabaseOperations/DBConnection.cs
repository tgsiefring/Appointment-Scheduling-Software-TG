using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Appointment.DatabaseOperations
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set; }

        public static void StartConnection()
        {
            try
            {
                //get the connection string
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                conn = new MySqlConnection(constr);

                //open the connection
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                //close the connection
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
