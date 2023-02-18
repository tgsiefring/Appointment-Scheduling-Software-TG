using Appointment.DatabaseOperations;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Appointment
{
    public partial class CalendarForm : Form
    {
        DateTime currentDate;
        public CalendarForm()
        {
            InitializeComponent();

            currentDate = DateTime.Now;
            miniCalendar.AddBoldedDate(currentDate);
            All();            
        }
        
        private void AllRadio_CheckedChanged(object sender, EventArgs e)
        {
            All();
        }
        private void MonthRadio_CheckedChanged(object sender, EventArgs e)
        {
            Month();
        }

        private void WeekRadio_CheckedChanged(object sender, EventArgs e)
        {
            Week();
        }

        //Displays appointments for the selected month in the datagridview.
        private void Month()
        {
            miniCalendar.RemoveAllBoldedDates();
            int month = currentDate.Month;
            int year = currentDate.Year;
            int day = 0;
            string startDate = year.ToString() + "/" + month.ToString() + "/01";
            DateTime selectDate = Convert.ToDateTime(startDate);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    day = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                default:
                    day = 29;
                    break;
            }
            for (int i = 0; i < day; i++)
            {
                miniCalendar.AddBoldedDate(selectDate.AddDays(i));
            }
            miniCalendar.UpdateBoldedDates(); 
            string endDate = year.ToString() + "/" + month.ToString() + "/" + day.ToString();   
            
            DataTable dt = new DataTable();           
            Calendar.FillCalendarTable(Calendar.GetSelectCalendarWMString(startDate, endDate), dt);
            appointmentView.DataSource = dt;

        }

        //Displays appointments for the selected week in the datagridview.
        private void Week()
        {
            miniCalendar.RemoveAllBoldedDates();
            int weekday = (int)currentDate.DayOfWeek;
            string startDate = currentDate.AddDays(-weekday).ToString("yyyy-MM-dd HH:mm:ss");
            DateTime selectDate = Convert.ToDateTime(startDate);
            for (int i = 0; i < 7; i++)
            {
                miniCalendar.AddBoldedDate(selectDate.AddDays(i));                
            }
            miniCalendar.UpdateBoldedDates();
            string endDate = currentDate.AddDays(7 - weekday).ToString("yyyy-MM-dd HH:mm:ss");
                       
            DataTable dt = new DataTable();            
            Calendar.FillCalendarTable(Calendar.GetSelectCalendarWMString(startDate, endDate), dt);
            appointmentView.DataSource = dt;
        }

        //Displays all appointments in the datagridview.
        private void All()
        {
            miniCalendar.RemoveAllBoldedDates();
            miniCalendar.UpdateBoldedDates();
                        
            DataTable dt = new DataTable();            
            Calendar.FillCalendarTable(Calendar.selectCalendarAll, dt);
            appointmentView.DataSource = dt;
        }

        private void MiniCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            currentDate = e.Start;
            if (allRadio.Checked)
            {
                All();
            }
            else
            {
                if (monthRadio.Checked)
                {
                    Month();
                }
                else
                {    
                        Week();                    
                }
            }
        }

        //Displays appointments in the datagridview in local time.
        private void AppointmentView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime)
            {
                var date = (DateTime)e.Value;
                var localDate = date.ToLocalTime();                                                 
                e.Value = localDate;
            }
        }

        private void AppointmentView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            appointmentView.ClearSelection();
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

        private void Calendar_Load(object sender, EventArgs e)
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
