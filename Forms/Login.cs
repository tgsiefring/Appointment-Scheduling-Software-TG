using Appointment.DatabaseOperations;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Appointment
{
    public partial class Login : Form
    {
        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();            
            //The following commented code is to force japanese language for testing purposes:

            //var culture = new CultureInfo("ja");
            //Thread.CurrentThread.CurrentUICulture = culture;
            //Thread.CurrentThread.CurrentCulture = culture;

            DetectLanguage();
        }

        //Determines language settings of local machine.
        private void DetectLanguage()
        {
            switch (CultureInfo.CurrentCulture.TwoLetterISOLanguageName)//The full name of the country/region in English.
            {
                case "en":
                    English();
                    break;
                case "ja":
                    Japanese();
                    break;

                default:
                    English();
                    //Japanese();
                    break;
            }
        }

        private void English()
        {
            titleLabel.Text = "Siefring Scheduling";
            this.Text = "Log In";            
            userLabel.Text = "User Name";
            passLabel.Text = "Password";            
            loginButton.Text = "Login";
            exitButton.Text = "Exit";
            errorLabel.Text = "Error: Incorrect login details";
        }

        private void Japanese()
        {
            //Done with google translate

            titleLabel.Text = "シーフリングスケジューリング";
            this.Text = "ログインする";
            userLabel.Text = "ユーザ名";
            passLabel.Text = "パスワード";
            loginButton.Text = "ログイン";
            exitButton.Text = "出口";
            errorLabel.Text = "エラー：ログインの詳細が正しくありません";
        }      

        private void LoginButton_Click(object sender, EventArgs e)
        {                        
            String username, password, userId;

            username = userBox.Text;
            password = passBox.Text;
            userId = idBox.Text;

            try
            {                
                User.LoginAttempt(User.GetSelectUsersString(userBox.Text, passBox.Text), dt);
                if(dt.Rows.Count > 0)
                {
                    //Writes to logfile.txt in bin > debug.
                    using (StreamWriter streamWriter = new StreamWriter("logfile.txt", true))
                    {
                        streamWriter.WriteLine("user: " + username + " successfully logged in at time: " + DateTime.Now.ToString());
                        streamWriter.WriteLine("");
                    }
                    userId = dt.Rows[0][0].ToString();
                    username = userBox.Text;
                    password = passBox.Text;
                   
                    Navigation f = new Navigation();
                    f.Show();
                    this.Hide();
                }
                else
                {                  
                    //Writes to logfile.txt in bin > debug.
                    using (StreamWriter streamWriter = new StreamWriter("logfile.txt", true))
                    {
                        streamWriter.WriteLine("Failed login attempt with username: " + username + " at time: " + DateTime.Now.ToString());
                        streamWriter.WriteLine("");                       
                    }
                    errorLabel.Show();
                    userBox.Clear();
                    passBox.Clear();
                    userBox.Focus();                    
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            DatabaseOperations.Appointment.AppointmentAlert(userId);
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

        private void Login_Load(object sender, EventArgs e)
        {   //Lambda expressions used to contain all simple button events in one method as opposed to separate methods for button clicks, mouse enter, and mouse leave. 
            //This helps with organization and readability
            loginButton.MouseEnter += (o, i) =>
            {
                loginButton.BackColor = Color.Aqua;
            };

            loginButton.MouseLeave += (o, i) =>
            {
                loginButton.BackColor = Color.Transparent;
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
