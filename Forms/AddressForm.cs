using Appointment.DatabaseOperations;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Appointment
{
    public partial class AddressForm : Form
    {
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public AddressForm()
        {
            InitializeComponent();  
            
            Address.FillAddressTable(Address.selectAddresses, dt);
            addressView.DataSource = dt;

            addressBox.BackColor = Color.Pink;
            cmbCity.BackColor = Color.Pink;
            zipBox.BackColor = Color.Pink;
            phoneBox.BackColor = Color.Pink;
          
            City.FillCityCombo(cmbCity, ds);
        }

        //Allows the user to click the add button if the condition is met.
        private bool AddEnabled()
        {
            return (!string.IsNullOrWhiteSpace(addressBox.Text)) && (!string.IsNullOrWhiteSpace(cmbCity.Text)) && (!string.IsNullOrWhiteSpace(zipBox.Text)) && (!string.IsNullOrWhiteSpace(phoneBox.Text));
        }

        //Allows the user to click the update button if the condition is met.
        private bool UpdateEnabled()
        {
            return (!string.IsNullOrWhiteSpace(addressBox.Text)) && (!string.IsNullOrWhiteSpace(cmbCity.Text)) && (!string.IsNullOrWhiteSpace(zipBox.Text)) && (!string.IsNullOrWhiteSpace(phoneBox.Text)) && (addressView.SelectedRows.Count > 0);
        }

        //Refreshes the datagridview to reflect changes.
        private void LoadDataGridView()
        {           
            DataTable dt = new DataTable();
            Address.FillAddressTable(Address.selectAddresses, dt);
            addressView.DataSource = dt;
        }        
        private void AddButton_Click(object sender, EventArgs e)
        {   //Requires the postal code to be 5 numerical digits
            if (!Regex.IsMatch(zipBox.Text, "^[0-9]{5}$"))
            {
                MessageBox.Show("zip code must be 5 numerical digits");
            }
            //Requires the phone number to be in format of ###-####.
            else if (!Regex.IsMatch(phoneBox.Text, "^[0-9]{3}-[0-9]{4}$"))
            {
                MessageBox.Show("phone number must contain 7 numbers and one - in format of: ###-####");
            }

            else
            {              
                Address.InsertAddress(Address.GetInsertAddressString(addressBox.Text, address2Box.Text, cmbCity.SelectedValue.ToString(), zipBox.Text, phoneBox.Text));
                LoadDataGridView();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {           
            Address.DeleteAddress(addressView);
            LoadDataGridView();
        }
         
        //Clears text in all TextBoxes and ComboBoxes.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            addressView.ClearSelection();
            try
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                }
                addressBox.Text = "";
                address2Box.Text = "";
                cmbCity.Text = "";
                zipBox.Text = "";
                phoneBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Populates all TextBoxes and ComboBoxes with data from the selected address in the datagridview.
        private void AddressView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                addressBox.Text = addressView.SelectedRows[0].Cells[1].Value.ToString();
                address2Box.Text = addressView.SelectedRows[0].Cells[2].Value.ToString();
                cmbCity.Text = addressView.SelectedRows[0].Cells[4].Value.ToString();
                zipBox.Text = addressView.SelectedRows[0].Cells[5].Value.ToString();
                phoneBox.Text = addressView.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {   //Requires the postal code to be 5 numerical digits.
            if (!Regex.IsMatch(zipBox.Text, "^[0-9]{5}$"))
            {
                MessageBox.Show("zip code must be 5 numerical digits");
            }
            //Requires the phone number to be in format of ###-####.
            else if (!Regex.IsMatch(phoneBox.Text, "^[0-9]{3}-[0-9]{4}$"))
            {
                MessageBox.Show("phone number must contain 7 numbers and one - in format of: ###-####");
            }

            else
            {                
                Address.UpdateAddress(addressView, addressBox.Text, address2Box.Text, cmbCity.SelectedValue.ToString(), zipBox.Text, phoneBox.Text);
                LoadDataGridView();
            }
        }

       

        private void AddressView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            addressView.ClearSelection();
        }

        //TextChanged events determine if fields are blank or not, if any of the fields are blank the add button and update button will not be clickable.
        //KeyPress events help to enforce proper input of data.
        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressBox.Text))
            {
                addressBox.BackColor = Color.Pink;
            }
            else
            {
                addressBox.BackColor = Color.White;
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void CmbCity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCity.Text))
            {
                cmbCity.BackColor = Color.Pink;
            }
            else
            {
                cmbCity.BackColor = Color.White;
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void ZipBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(zipBox.Text))
            {
                zipBox.BackColor = Color.Pink;
            }
            else
            {
                zipBox.BackColor = Color.White;
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneBox.Text))
            {
                phoneBox.BackColor = Color.Pink;
            }
            else
            {
                phoneBox.BackColor = Color.White;
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void AddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '.') 
            {
                e.Handled = true;
            }
            //Address allows numbers, letters, and periods.
            //Ensuring valid address is tricky, this code allows for periods for ex. P.O. Box, Main St. , etc. but does not allow other special characters.
            //Code still relies on user for valid address to some extent.
        }

        private void ZipBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Postal code allows only numbers.
            {
                e.Handled = true;
            }

            else if (!char.IsControl(e.KeyChar) && zipBox.Text.Length == 5) //Postal code is 5 digits.
            {
                e.Handled = true;
            }
        }

        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' && phoneBox.Text.Contains("-")) //Phone allows only one dash.
            {
                e.Handled = true;
            }

            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-') //Phone allows only numbers and dashes.
            {
                e.Handled = true;
            }

            else if (!char.IsControl(e.KeyChar) && phoneBox.Text.Length == 8) //Phone is 7 numbers and one - aka 8 characters.
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

        private void Address_Load(object sender, EventArgs e)
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
