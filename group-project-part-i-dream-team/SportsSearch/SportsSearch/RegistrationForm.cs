using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsSearch
{
    public partial class RegistrationForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = textNewUsername.Text;
            string password = textNewPassword.Text;

            // In a real-world application, you would validate username and password and store them securely.
            // For this example, we are just displaying a message.
            MessageBox.Show("Account created successfully!");
            this.Username = username;
            this.Password = password;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
