using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsSearch
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool AuthenticateUser(string username, string password)
        {
            txtPassword.UseSystemPasswordChar = true; 

            if (File.Exists("credentials.txt"))
            {
                string[] lines = File.ReadAllLines("credentials.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && parts[0].Trim() == username && parts[1].Trim() == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if the username exists
            if (AuthenticateUser(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        private void SaveUserCredentials(string username, string password)
        {
            using (StreamWriter writer = new StreamWriter("credentials.txt", true))
            {
                writer.WriteLine($"{username}:{password}");
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            // Show the registration form
            RegistrationForm registrationForm = new RegistrationForm();
            if (registrationForm.ShowDialog() == DialogResult.OK)
            {
                // If registration was successful, save the new user credentials to file
                using (StreamWriter writer = new StreamWriter("credentials.txt", true))
                {
                    writer.WriteLine($"{registrationForm.Username}:{registrationForm.Password}");
                }
                MessageBox.Show("Account created successfully!");
            }

        }
    }
}
