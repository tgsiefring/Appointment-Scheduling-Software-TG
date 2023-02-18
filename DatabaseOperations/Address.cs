using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Appointment.DatabaseOperations
{
    class Address
    {   //Sql queries used to populate datagridview/s.
        public static string selectAddresses = "SELECT address.addressId, address.address, address.address2, address.cityId, city.city, address.postalCode, address.phone FROM address join city on address.cityId = city.cityId order by addressId;";
        public static string selectCustFormAddresses = "SELECT address.addressId, address.address, address.address2, city.city, address.postalCode, country.country, address.phone " +
                "FROM address join city on address.cityId = city.cityId join country on city.countryId = country.countryId order by addressId;";
        
        //Populates table with address data to serve as datasource for a datagridview
        public static DataTable FillAddressTable(string s, DataTable dt)
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

        //Inserts an address into the database.
        public static void InsertAddress(string s)
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

        //Obtains missing parts of string to return the complete insert address string.
        public static string GetInsertAddressString(string addressBox, string address2Box, string cmbCity, string zipBox, string phoneBox)
        {
            string insert = "INSERT INTO  client_schedule.address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES('" + addressBox + "','" + address2Box + "','" + cmbCity + "','" + zipBox + "','" + phoneBox + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test');";
            return insert;
        }

        //Deletes an address from the database.
        public static void DeleteAddress(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgv.SelectedRows)
                    {
                        string value = dgv.SelectedRows[0].Cells[0].Value.ToString();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM address WHERE addressId =@Value", DBConnection.conn);
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

        //Updates the selected address in the database.
        public static void UpdateAddress(DataGridView dgv, string addressBox, string address2Box, string cmbCity, string zipBox, string phoneBox)
        {
            String query = "UPDATE address SET addressId = @addressId, address = @address, address2 = @address2, cityId = @cityId, postalCode = @postalCode, phone = @phone WHERE addressId = @addressId";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.Parameters.AddWithValue("@addressId", dgv.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@address", addressBox);
            cmd.Parameters.AddWithValue("@address2", address2Box);
            cmd.Parameters.AddWithValue("@cityId", cmbCity);
            cmd.Parameters.AddWithValue("@postalCode", zipBox);
            cmd.Parameters.AddWithValue("@phone", phoneBox);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Counts the number of rows in the address table.
        public static void AddressCount(Label address)
        {
            try
            {
                String query = "SELECT COUNT(*) FROM address;";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                Int32 countAddress = Int32.Parse(cmd.ExecuteScalar().ToString());
                address.Text = countAddress.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
