using Appointment.DatabaseOperations;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Appointment
{
    public partial class ReportsForm : Form
    {
        DataSet ds = new DataSet();
        public ReportsForm()
        {
            InitializeComponent();
            
            User.FillUserCombo(cmbUser, ds);
            
            Reports.GenerateAppointmentReport(appointmentReport);
            appointmentReport.Select(0, 0);
                                                
            DataTable dt2 = new DataTable();
            DatabaseOperations.Appointment.FillAppointmentTable(DatabaseOperations.Appointment.selectAppointments, dt2, cmbUser);
            appointmentView.DataSource = dt2;

            DatabaseOperations.Appointment.AppointmentCount(appointmentLabel);            
            User.UserCount(userLabel);
            Customer.CustomerCount(customerLabel);
            Address.AddressCount(addressLabel);
            Country.CountryCount(countryLabel);
            City.CityCount(cityLabel);
        }

        //Refreshes the datagridview to reflect changes.
        private void LoadDataGridView()
        {           
            DataTable dt2 = new DataTable();
            DatabaseOperations.Appointment.FillAppointmentTable(DatabaseOperations.Appointment.selectAppointments, dt2, cmbUser);
            appointmentView.DataSource = dt2;          
        }

        private void CmbUser_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        //Allows user to exit the program.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //Lambda expressions used to contain all simple button events in one method as opposed to separate methods for button clicks, mouse enter, and mouse leave. 
            //This helps with organization and readability
            countryButton.Click += (o, i) =>
            {
                CountryForm c = new CountryForm();
                c.Show();
                this.Hide();
            };

            countryButton.MouseEnter += (o, i) =>
            {
                countryButton.BackColor = Color.Aqua;
            };

            countryButton.MouseLeave += (o, i) =>
            {
                countryButton.BackColor = Color.Transparent;
            };

            cityButton.Click += (o, i) =>
            {
                CityForm c = new CityForm();
                c.Show();
                this.Hide();
            };

            cityButton.MouseEnter += (o, i) =>
            {
                cityButton.BackColor = Color.Aqua;
            };

            cityButton.MouseLeave += (o, i) =>
            {
                cityButton.BackColor = Color.Transparent;
            };

            addressButton.Click += (o, i) =>
            {
                AddressForm a = new AddressForm();
                a.Show();
                this.Hide();
            };

            addressButton.MouseEnter += (o, i) =>
            {
                addressButton.BackColor = Color.Aqua;
            };

            addressButton.MouseLeave += (o, i) =>
            {
                addressButton.BackColor = Color.Transparent;
            };

            customerButton.Click += (o, i) =>
            {
                CustomerForm c = new CustomerForm();
                c.Show();
                this.Hide();
            };

            customerButton.MouseEnter += (o, i) =>
            {
                customerButton.BackColor = Color.Aqua;
            };

            customerButton.MouseLeave += (o, i) =>
            {
                customerButton.BackColor = Color.Transparent;
            };

            appointmentButton.Click += (o, i) =>
            {
                AppointmentForm a = new AppointmentForm();
                a.Show();
                this.Hide();
            };

            appointmentButton.MouseEnter += (o, i) =>
            {
                appointmentButton.BackColor = Color.Aqua;
            };

            appointmentButton.MouseLeave += (o, i) =>
            {
                appointmentButton.BackColor = Color.Transparent;
            };

            calendarButton.Click += (o, i) =>
            {
                CalendarForm c = new CalendarForm();
                c.Show();
                this.Hide();
            };

            calendarButton.MouseEnter += (o, i) =>
            {
                calendarButton.BackColor = Color.Aqua;
            };

            calendarButton.MouseLeave += (o, i) =>
            {
                calendarButton.BackColor = Color.Transparent;
            };

            reportButton.Click += (o, i) =>
            {
                ReportsForm r = new ReportsForm();
                r.Show();
                this.Hide();
            };

            reportButton.MouseEnter += (o, i) =>
            {
                reportButton.BackColor = Color.Aqua;
            };

            reportButton.MouseLeave += (o, i) =>
            {
                reportButton.BackColor = Color.Transparent;
            };

            exitButton.MouseEnter += (o, i) =>
            {
                exitButton.BackColor = Color.Aqua;
            };

            exitButton.MouseLeave += (o, i) =>
            {
                exitButton.BackColor = Color.Transparent;
            };
        }        
    }
}
