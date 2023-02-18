using Appointment.DatabaseOperations;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Appointment
{
    public partial class AppointmentForm : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataSet ds = new DataSet();
        public AppointmentForm()
        {
            InitializeComponent();
            
            User.FillUserCombo(cmbUser, ds);

            DatabaseOperations.Appointment.FillAppointmentTable(DatabaseOperations.Appointment.selectAppointments, dt, cmbUser);
            appointmentView.DataSource = dt;
           
            Customer.FillCustomerTable(Customer.selectCustomers, dt2);
            customerView.DataSource = dt2;

            customerBox.BackColor = Color.Pink;            
            typeBox.BackColor = Color.Pink;
            select2Label.Show();
            
            startPicker.Format = DateTimePickerFormat.Custom;
            startPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            
            endPicker.Format = DateTimePickerFormat.Custom;
            endPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        //Allows the user to click the add button if the condition is met.
        private bool AddEnabled()
        {
            return (!string.IsNullOrWhiteSpace(customerBox.Text)) && (!string.IsNullOrWhiteSpace(cmbUser.Text)) && (!string.IsNullOrWhiteSpace(typeBox.Text));
        }

        //Allows the user to click the update button if the condition is met.
        private bool UpdateEnabled()
        {
            return (!string.IsNullOrWhiteSpace(customerBox.Text)) && (!string.IsNullOrWhiteSpace(cmbUser.Text)) && (!string.IsNullOrWhiteSpace(typeBox.Text)) && (appointmentView.SelectedRows.Count > 0);
        }

        //Refreshes the datagridview to reflect changes.
        private void LoadDataGridView()
        {            
            DataTable dt = new DataTable();
            DatabaseOperations.Appointment.FillAppointmentTable(DatabaseOperations.Appointment.selectAppointments, dt, cmbUser);
            appointmentView.DataSource = dt;
        }

        //Populates all TextBoxes and ComboBoxes with data from the selected customer in the datagridview.
        private void CustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                customerBox.Text = customerView.SelectedRows[0].Cells[0].Value.ToString();              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                    
        private void AddButton_Click(object sender, EventArgs e)
        {
            bool overlap = false;

            bool result = DatabaseOperations.Appointment.AddAppointmentDetectOverlap(startPicker, endPicker, cmbUser.SelectedValue.ToString(), overlap);
            
            //Business hours
            TimeSpan openTime = TimeSpan.Parse("08:00");
            TimeSpan closeTime = TimeSpan.Parse("17:00");
            
            if(startPicker.Value >= endPicker.Value)
            {
                MessageBox.Show("Start date/time must be before end date/time");
            }

            //Determines if the time frame of the appointment being added is within business hours.
            if ((startPicker.Value.TimeOfDay > openTime) && (startPicker.Value.TimeOfDay < closeTime) && (endPicker.Value.TimeOfDay > openTime) && (endPicker.Value.TimeOfDay < closeTime))
            {
                //Determines if the appointment being added overlaps with any other appointment for the user.
                if (result == false)               
                {
                    DatabaseOperations.Appointment.InsertAppointment(DatabaseOperations.Appointment.GetInsertAppointmentString(customerBox.Text, cmbUser.SelectedValue.ToString(), typeBox.Text), startPicker, endPicker);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("appointments overlap");
                }
            }
            else
            {
                MessageBox.Show("Appointment outside of business hours");
            }
        }

        //Populates all TextBoxes and ComboBoxes with data from the selected appointment in the datagridview.
        private void AppointmentView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                customerBox.Text = appointmentView.SelectedRows[0].Cells[1].Value.ToString();
                cmbUser.Text = appointmentView.SelectedRows[0].Cells[2].Value.ToString();
                typeBox.Text = appointmentView.SelectedRows[0].Cells[3].Value.ToString();
                startPicker.Value = DateTime.Parse(appointmentView.SelectedRows[0].Cells[4].Value.ToString()).ToLocalTime();
                endPicker.Value = DateTime.Parse(appointmentView.SelectedRows[0].Cells[5].Value.ToString()).ToLocalTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {            
            bool overlap = false;
           
            bool result = DatabaseOperations.Appointment.UpdateAppointmentDetectOverlap(startPicker, endPicker, appointmentView, overlap);

            //Business hours 
            TimeSpan openTime = TimeSpan.Parse("08:00");
            TimeSpan closeTime = TimeSpan.Parse("17:00");

            if (startPicker.Value >= endPicker.Value)
            {
                MessageBox.Show("Start date/time must be before end date/time");
            }
            //Determines if the new time frame of the appointment being updated is within business hours.
            if ((startPicker.Value.TimeOfDay >= openTime) && (startPicker.Value.TimeOfDay <= closeTime) && (endPicker.Value.TimeOfDay >= openTime) && (endPicker.Value.TimeOfDay <= closeTime))
            {
                //Determines if the new DateTime of the appointment being updated overlaps with any other appointment for the user.
                if (result == false)
                {
                    DatabaseOperations.Appointment.UpdateAppointment(appointmentView, customerBox.Text, cmbUser.SelectedValue.ToString(), typeBox.Text, startPicker, endPicker);
                    LoadDataGridView();                  
                }
                else
                {
                    MessageBox.Show("appointments overlap");
                }
            }
            else
            {
                MessageBox.Show("Appointment outside of business hours");
            }
        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DatabaseOperations.Appointment.DeleteAppointment(appointmentView);
                LoadDataGridView();           
        }

        //Clears text in all TextBoxes and ComboBoxes.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            customerView.ClearSelection();
            appointmentView.ClearSelection();
            try
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                }
                customerBox.Text = "";
                cmbUser.Text = "";
                typeBox.Text = "";
                startPicker.Text = "";
                endPicker.Text = "";               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void CustomerView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customerView.ClearSelection();
        }

        private void CustomerBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerBox.Text))
            {
                customerBox.BackColor = Color.Pink;
                select2Label.Show();
            }
            else
            {
                customerBox.BackColor = Color.White;
                select2Label.Hide();
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        //TextChanged events determine if fields are blank or not, if any of the fields are blank the add button and update button will not be clickable.
        //KeyPress events help to enforce proper input of data.
        private void CmbUser_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbUser.Text))
            {
                cmbUser.BackColor = Color.Pink;
            }
            else
            {
                cmbUser.BackColor = Color.White;
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void TypeBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeBox.Text))
            {
                typeBox.BackColor = Color.Pink;
            }
            else
            {
                typeBox.BackColor = Color.White;
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void TypeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) //Type allows only letters.
            {
                e.Handled = true;
            }
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

        private void Appointment_Load(object sender, EventArgs e)
        {
            //Lambda expressions used to contain all simple button events in one method as opposed to separate methods for button clicks, mouse enter, and mouse leave. 
            //This helps with organization and readability.
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

            addButton.MouseEnter += (o, i) =>
            {
                addButton.BackColor = Color.Aqua;
            };

            addButton.MouseLeave += (o, i) =>
            {
                addButton.BackColor = Color.Transparent;
            };

            updateButton.MouseEnter += (o, i) =>
            {
                updateButton.BackColor = Color.Aqua;
            };

            updateButton.MouseLeave += (o, i) =>
            {
                updateButton.BackColor = Color.Transparent;
            };

            resetButton.MouseEnter += (o, i) =>
            {
                resetButton.BackColor = Color.Aqua;
            };

            resetButton.MouseLeave += (o, i) =>
            {
                resetButton.BackColor = Color.Transparent;
            };

            deleteButton.MouseEnter += (o, i) =>
            {
                deleteButton.BackColor = Color.Aqua;
            };

            deleteButton.MouseLeave += (o, i) =>
            {
                deleteButton.BackColor = Color.Transparent;
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
