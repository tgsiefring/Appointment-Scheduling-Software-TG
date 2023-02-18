using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Appointment.DatabaseOperations
{
    class Country
    {   //Sql query used to populate a datagridview.     
        public static string selectCountries = "SELECT countryId, country FROM country order by countryId;";

        //Populates table with country data to serve as datasource for a datagridview.  
        public static DataTable FillCountryTable(string s, DataTable dt)
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

        //Inserts a country into the database.
        public static void InsertCountry(string s)
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

        //Obtains missing parts of string to return the complete insert country string.
        public static string GetInsertCountryString(string s)
        {
            string insert = "INSERT INTO  client_schedule.country (country,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('" + s + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','test');";            
            return insert;
        }

        //Deletes a country from the database.
        public static void DeleteCountry(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgv.SelectedRows)
                    {
                        string value = dgv.SelectedRows[0].Cells[0].Value.ToString();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM country WHERE countryId =@Value", DBConnection.conn);
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

        //Updates the selected country in the database.
        public static void UpdateCountry(DataGridView dgv, string countryBoxText)
        {
            String query = "UPDATE country SET countryId = @countryId, country = @country WHERE countryId = @countryId";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            cmd.Parameters.AddWithValue("@countryId", dgv.SelectedRows[0].Cells[0].Value.ToString());            
            cmd.Parameters.AddWithValue("@country", countryBoxText);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Populates a ComboBox with country data.
        public static void FillCountryCombo(ComboBox country, DataSet ds)
        {
            try
            {
                string query = "SELECT country, countryId FROM  country";
                MySqlDataAdapter mda = new MySqlDataAdapter(query, DBConnection.conn);
                mda.Fill(ds, "Country");
                country.DisplayMember = "country";
                country.ValueMember = "countryId";
                country.DataSource = ds.Tables["Country"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Counts the number of rows in the country table.
        public static void CountryCount(Label country)
        {
            try
            {
                String query = "SELECT COUNT(*) FROM country;";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                Int32 countCountry = Int32.Parse(cmd.ExecuteScalar().ToString());
                country.Text = countCountry.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
