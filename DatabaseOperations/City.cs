using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Appointment.DatabaseOperations
{
    class City
    {   //Sql query used to populate a datagridview.
        public static string selectCities = "SELECT city.cityId, city.city, city.countryId, country.country FROM city join country on city.countryId = country.countryId order by cityId;";

        //Populates table with city data to serve as datasource for a datagridview.   
        public static DataTable FillCityTable(string s, DataTable dt)
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

        //Inserts a city into the database.
        public static void InsertCity(string s)
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

        //Obtains missing parts of string to return the complete insert city string.
        public static string GetInsertCityString(string cityBox, string cmbCountry)
        {            
            string insert = "INSERT INTO  client_schedule.city (city,countryId,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('" + cityBox + "','" + cmbCountry + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test');";
            return insert;
        }

        //Deletes a city from the database.
        public static void DeleteCity(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgv.SelectedRows)
                    {
                        string value = dgv.SelectedRows[0].Cells[0].Value.ToString();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM city WHERE cityId = @Value", DBConnection.conn);
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

        //Updates the selected city in the database.
        public static void UpdateCity(DataGridView dgv, string cityBox, string cmbCountry)
        {
            String query = "UPDATE city SET cityId = @cityId, city = @city, countryId = @countryId WHERE cityId = @cityId";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.Parameters.AddWithValue("@cityId", dgv.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@city", cityBox);
            cmd.Parameters.AddWithValue("@countryId", cmbCountry);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Populates a ComboBox with city data.
        public static void FillCityCombo(ComboBox city, DataSet ds)
        {
            try
            {
                string query = "SELECT city, cityId FROM  city";
                MySqlDataAdapter mda = new MySqlDataAdapter(query, DBConnection.conn);
                mda.Fill(ds, "City");
                city.DisplayMember = "city";
                city.ValueMember = "cityId";
                city.DataSource = ds.Tables["City"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Counts the number of rows in the city table.
        public static void CityCount(Label city)
        {
            try
            {
                String query = "SELECT COUNT(*) FROM city;";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                Int32 countCity = Int32.Parse(cmd.ExecuteScalar().ToString());
                city.Text = countCity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
