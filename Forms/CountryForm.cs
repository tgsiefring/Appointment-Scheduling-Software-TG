using Appointment.DatabaseOperations;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Appointment
{
    public partial class CountryForm : Form
    {
        DataTable dt = new DataTable();
        public CountryForm()
        {
            InitializeComponent();
            
            Country.FillCountryTable(Country.selectCountries, dt);
            countryView.DataSource = dt;

            countryBox.BackColor = Color.Pink;
        }

        //Refreshes the datagridview to reflect changes.
        private void LoadDataGridView()
        {            
            DataTable dt = new DataTable();
            Country.FillCountryTable(Country.selectCountries, dt);
            countryView.DataSource = dt;
        }

        //Allows the user to click the add button if the condition is met.
        private bool AddEnabled()
        {
            return (!string.IsNullOrWhiteSpace(countryBox.Text));
        }

        //Allows the user to click the update button if the condition is met.
        private bool UpdateEnabled()
        {
            return (!string.IsNullOrWhiteSpace(countryBox.Text)) && (countryView.SelectedRows.Count > 0);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {            
            Country.InsertCountry(Country.GetInsertCountryString(countryBox.Text));            
            LoadDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {            
            Country.DeleteCountry(countryView);
            LoadDataGridView();
        }

        //Clears text in all TextBoxes.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            countryView.ClearSelection();
            try
            {
                foreach(Control c in panel1.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                }
                countryBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Populates all TextBox with data from the selected country in the datagridview.
        private void CountryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                countryBox.Text = countryView.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {            
            Country.UpdateCountry(countryView, countryBox.Text);
            LoadDataGridView();
        }
                    
        private void CountryView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            countryView.ClearSelection();
        }

        //TextChanged events determine if fields are blank or not, if any of the fields are blank the add button and update button will not be clickable.
        //KeyPress events help to enforce proper input of data.
        private void CountryBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(countryBox.Text))
            {
                countryBox.BackColor = Color.Pink;
            }
            else
            {
                countryBox.BackColor = Color.White;
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void CountryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) //Name allows only letters.
            {
                e.Handled = true;
            }
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

        private void Country_Load(object sender, EventArgs e)
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
