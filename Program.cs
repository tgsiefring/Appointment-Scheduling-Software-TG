using Appointment.DatabaseOperations;
using System;
using System.Windows.Forms;

namespace Appointment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBConnection.StartConnection();
            Application.Run(new Login());
            DBConnection.CloseConnection();
        }
    }
}
