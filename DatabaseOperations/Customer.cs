using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Appointment.DatabaseOperations
{
    class Customer
    {   //Sql query used to populate a datagridview. 
        public static string selectCustomers = "SELECT customer.customerId AS Customer_ID, customer.customerName AS Customer_Name, address.addressId AS Address_ID, address.address AS Address, " +
                "address.address2 AS Address_2, city.city AS City, address.postalCode AS Postal_Code, country.country AS Country, address.phone AS Phone from customer " +
                "join address on customer.addressId = address.addressId join city on address.cityId = city.cityId join country on city.countryId = country.countryId order by customerId;";

        //Populates table with customer data to serve as datasource for a datagridview.
        public static DataTable FillCustomerTable(string s, DataTable dt)
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

        //Inserts a customer into the database.
        public static void InsertCustomer(string s)
        {
            MySqlCommand cmd = new MySqlCommand(s, DBConnection.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Obtains missing parts of string to return the complete insert customer string.
        public static string GetInsertCustomerString(string nameBox, string addressidBox)
        {           
            string insert = "INSERT INTO  client_schedule.customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
            "VALUES('" + nameBox + "','" + addressidBox + "','1','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test'" +
            ",'" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test');";
            return insert;
        }

        //Deletes a customer from the database.
        public static void DeleteCustomer(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgv.SelectedRows)
                    {
                        string value = dgv.SelectedRows[0].Cells[0].Value.ToString();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM customer WHERE customerId =@Value", DBConnection.conn);
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

        //Updates the selected customer in the database.
        public static void UpdateCustomer(DataGridView dgv, string nameBox, string addressidBox)
        {
            String query = "UPDATE customer SET customerId = @customerId, customerName = @customerName, addressId = @addressId WHERE customerId = @customerId";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);           
            cmd.Parameters.AddWithValue("@customerId", dgv.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@customerName", nameBox);
            cmd.Parameters.AddWithValue("@addressId", addressidBox);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Counts the number of rows in the customer table.
        public static void CustomerCount(Label customer)
        {
            try
            {
                String query = "SELECT COUNT(*) FROM customer;";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                Int32 countCustomer = Int32.Parse(cmd.ExecuteScalar().ToString());
                customer.Text = countCustomer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
