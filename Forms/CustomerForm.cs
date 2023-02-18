using Appointment.DatabaseOperations;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Appointment
{
    public partial class CustomerForm : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public CustomerForm()
        {
            InitializeComponent();
            
            Customer.FillCustomerTable(Customer.selectCustomers, dt);
            customerView.DataSource = dt;
                        
            Address.FillAddressTable(Address.selectCustFormAddresses, dt2);
            addressView.DataSource = dt2;

            nameBox.BackColor = Color.Pink;
            addressidBox.BackColor = Color.Pink;
            addressBox.BackColor = Color.Pink;
            address2Box.BackColor = Color.Pink;
            cityBox.BackColor = Color.Pink;
            zipBox.BackColor = Color.Pink;
            countryBox.BackColor = Color.Pink;
            phoneBox.BackColor = Color.Pink;
            selectLabel.Show();
        }

        //Allows the user to click the add button if the condition is met.
        private bool AddEnabled()
        {
            return (!string.IsNullOrWhiteSpace(nameBox.Text)) && (!string.IsNullOrWhiteSpace(addressidBox.Text));
        }

        //Allows the user to click the update button if the condition is met.
        private bool UpdateEnabled()
        {
            return (!string.IsNullOrWhiteSpace(nameBox.Text)) && (!string.IsNullOrWhiteSpace(addressidBox.Text)) && (customerView.SelectedRows.Count > 0);
        }

        //Refreshes the datagridview to reflect changes.
        private void LoadDataGridView()
        {           
            DataTable dt = new DataTable();            
            Customer.FillCustomerTable(Customer.selectCustomers, dt);
            customerView.DataSource = dt;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {            
            Customer.InsertCustomer(Customer.GetInsertCustomerString(nameBox.Text, addressidBox.Text));                                       
            LoadDataGridView();
        }

        //Populates all TextBoxes with data from the selected address in the datagridview.
        private void AddressView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                addressidBox.Text = addressView.SelectedRows[0].Cells[0].Value.ToString();
                addressBox.Text = addressView.SelectedRows[0].Cells[1].Value.ToString();
                address2Box.Text = addressView.SelectedRows[0].Cells[2].Value.ToString();
                cityBox.Text = addressView.SelectedRows[0].Cells[3].Value.ToString();
                zipBox.Text = addressView.SelectedRows[0].Cells[4].Value.ToString();
                countryBox.Text = addressView.SelectedRows[0].Cells[5].Value.ToString();
                phoneBox.Text = addressView.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Populates all TextBoxes with data from the selected customer in the datagridview.
        private void CustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nameBox.Text = customerView.SelectedRows[0].Cells[1].Value.ToString();
                addressidBox.Text = customerView.SelectedRows[0].Cells[2].Value.ToString();
                addressBox.Text = customerView.SelectedRows[0].Cells[3].Value.ToString();
                address2Box.Text = customerView.SelectedRows[0].Cells[4].Value.ToString();
                cityBox.Text = customerView.SelectedRows[0].Cells[5].Value.ToString();
                zipBox.Text = customerView.SelectedRows[0].Cells[6].Value.ToString();
                countryBox.Text = customerView.SelectedRows[0].Cells[7].Value.ToString();
                phoneBox.Text = customerView.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {            
            Customer.UpdateCustomer(customerView, nameBox.Text, addressidBox.Text);
            LoadDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {            
            Customer.DeleteCustomer(customerView);
            LoadDataGridView();            
        }

        //Clears text in all TextBoxes.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            customerView.ClearSelection();
            addressView.ClearSelection();
            try
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                }
                nameBox.Text = "";
                addressidBox.Text = "";
                addressBox.Text = "";
                address2Box.Text = "";
                cityBox.Text = "";
                zipBox.Text = "";
                countryBox.Text = "";
                phoneBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void CustomerView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customerView.ClearSelection();
        }

        private void AddressView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            addressView.ClearSelection();
        }

        //TextChanged events determine if fields are blank or not, if any of the fields are blank the add button and update button will not be clickable.
        //KeyPress events help to enforce proper input of data.
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                nameBox.BackColor = Color.Pink;
            }
            else
            {
                nameBox.BackColor = Color.White;
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void AddressidBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressidBox.Text))
            {
                addressidBox.BackColor = Color.Pink;
                addressBox.BackColor = Color.Pink;
                address2Box.BackColor = Color.Pink;
                cityBox.BackColor = Color.Pink;
                zipBox.BackColor = Color.Pink;
                countryBox.BackColor = Color.Pink;
                phoneBox.BackColor = Color.Pink;
                selectLabel.Show();
            }
            else
            {
                addressidBox.BackColor = Color.White;
                addressBox.BackColor = Color.White;
                address2Box.BackColor = Color.White;
                cityBox.BackColor = Color.White;
                zipBox.BackColor = Color.White;
                countryBox.BackColor = Color.White;
                phoneBox.BackColor = Color.White;
                selectLabel.Hide();
            }

            addButton.Enabled = AddEnabled();
            updateButton.Enabled = UpdateEnabled();
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Customer_Load(object sender, EventArgs e)
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

