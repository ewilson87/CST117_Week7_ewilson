/**
 * Program: Inventory Management Program
 * File: LoginScreen.cs
 * Summary: Multi form inventory management application - Milestone 5
 * Author: Evan Wilson
 * Date: May 20th, 2018
 **/

using System;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace CST117_InventoryManagementProgram
{
    public partial class LoginScreen : Form
    {
        private string defaultUsername = "admin";
        private string defaultPassword = "password";
        private bool saveLogonChecked;
        private string username;
        private string password;

        public LoginScreen()
        {
            InitializeComponent();

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            readLogonFile();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //generic username/password for entry
            if (usernameTextBox.Text == defaultUsername && passwordTextBox.Text == defaultPassword)
            {
                saveLogonFile();

                HomeScreen homeScreenForm = new HomeScreen();

                this.Hide();
                homeScreenForm.Show(this);
            }
            else MessageBox.Show("Wrong username or password entered");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void saveLogonFile()
        {
            try
            {
                //creates a new backup file (overwrites previous backup) upon execution of program as a safeguard in case of accidental changes
                FileStream fcreate = File.Open("logon.csv", FileMode.Create);

                StreamWriter streamWriter = new StreamWriter(fcreate);

                if (checkBox1.Checked)
                {
                    streamWriter.Write("true," + usernameTextBox.Text + "," + passwordTextBox.Text);
                }
                else streamWriter.Write("false," + usernameTextBox.Text + "," + passwordTextBox.Text);

                streamWriter.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void readLogonFile()
        {
            try
            {
                //opens inventory file
                StreamReader streamReader = new StreamReader(File.OpenRead("logon.csv"));
                    string logonFile = streamReader.ReadLine();
                    string[] logonDetails = logonFile.Split(',');
                    saveLogonChecked = bool.Parse(logonDetails[0]);
                    username = logonDetails[1];
                    password = logonDetails[2];

                streamReader.Dispose();
            }
            catch
            {

            }

            if (saveLogonChecked)
            {
                usernameTextBox.Text = username;
                passwordTextBox.Text = password;
                checkBox1.Checked = true;
            }
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
