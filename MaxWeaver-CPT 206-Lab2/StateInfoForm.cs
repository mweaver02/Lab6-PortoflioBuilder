using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxWeaver_CPT_206_Lab2
{
    public partial class StateInfoForm : Form
    {
        //Decalre database connection
        private OleDbConnection connection;
        //// Set the connection string to the location of the Access database file.
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\maxwe\\source\\repos\\MaxWeaver-CPT 206-Lab2\\StatesDB.accdb\"";

        // Constructor for the StateInfoForm class, taking a selected state as input
        public StateInfoForm(string selectedState)
        {
            InitializeComponent();
            DisplayStateInformation(selectedState);
        }

        private void DisplayStateInformation(string state)
        {
            // Retrieve state information from database methods
            string capital = GetCapitalOfState(state);
            int population = GetPopulationOfState(state);
            string flag = GetStateFlag(state);
            string flower = GetStateFlower(state);
            string bird = GetStateBird(state);
            string color = GetStateColor(state);
            string city = GetCities(state);
            double income = GetIncome(state);
            int jobs = GetJobs(state);

            //Set text properties of labels to display state information
            nameLabel.Text = state;
            capLabel.Text = capital;
            popLabel.Text = population.ToString("N2");
            flagLabel.Text = flag;
            flowerLabel.Text = flower;
            birdLabel.Text = bird;
            colorLabel.Text = color;
            cityLabel.Text = city;
            medianLabel.Text = income.ToString("C2");
            compLabel.Text = jobs.ToString("N2");
        }

        private string GetCapitalOfState(string state)
        {
            // Initialize variable to store capital
            string capital = "";
            try
            {
                // Establish database connection.
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open(); // Open database connection
                    OleDbCommand command = new OleDbCommand("SELECT StateCapitol FROM StateInfo WHERE StateName = @StateName", connection);  // Define OleDb command to select capital based on state name.
                    command.Parameters.AddWithValue("@StateName", state); // Add parameter for state name to command
                    capital = command.ExecuteScalar()?.ToString(); // Execute SQL command to retrieve capital and store in variable
                }
            }
            //Catch any excpetion and display error message
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving capital: " + ex.Message);
            }
            return capital;
        }

        private int GetPopulationOfState(string state)
        {
            int population = 0;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT Population FROM StateInfo WHERE StateName = @StateName", connection);
                    command.Parameters.AddWithValue("@StateName", state);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                        population = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving population: " + ex.Message);
            }
            return population;
        }
        private string GetStateFlag(string state)
        {
            string flag = "";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT StateFlag FROM StateInfo WHERE StateName = @StateName", connection);
                    command.Parameters.AddWithValue("@StateName", state);
                    flag = command.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving capital: " + ex.Message);
            }
            return flag;
        }
        private string GetStateFlower(string state)
        {
            string flower = "";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT StateFlower FROM StateInfo WHERE StateName = @StateName", connection);
                    command.Parameters.AddWithValue("@StateName", state);
                    flower = command.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving capital: " + ex.Message);
            }
            return flower;
        }
        private string GetStateBird(string state)
        {
            string bird = "";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT StateBird FROM StateInfo WHERE StateName = @StateName", connection);
                    command.Parameters.AddWithValue("@StateName", state);
                    bird = command.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving capital: " + ex.Message);
            }
            return bird;
        }

        private string GetStateColor(string state)
        {
            string color = "";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT StateColors FROM StateInfo WHERE StateName = @StateName", connection);
                    command.Parameters.AddWithValue("@StateName", state);
                    color = command.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving capital: " + ex.Message);
            }
            return color;
        }

        private string GetCities(string state)
        {
            string cities = "";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT [3_LargestCities] FROM StateInfo WHERE StateName = @StateName", connection);
                    command.Parameters.AddWithValue("@StateName", state);
                    cities = command.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving capital: " + ex.Message);
            }
            return cities;
        }

        private double GetIncome(string state)
        {
            double income = 0.0;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT MedianIncome FROM StateInfo WHERE StateName = @StateName", connection);
                    command.Parameters.AddWithValue("@StateName", state);
                    object result = command.ExecuteScalar();
                    // Check if the result is not equal to DBNull.Value, indicating that a valid value was retrieved.
                    if (result != DBNull.Value)
                        income = Convert.ToInt32(result);  // Convert the result to an integer and assign it to the income variable.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving capital: " + ex.Message);
            }
            return income;
        }

        private int GetJobs(string state)
        {
            int jobs = 0;
            try
            {
                using (OleDbConnection connection =  new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT [# of COmputer Jobs] FROM StateInfo WHERE StateName = @StateName", connection);
                    command.Parameters.AddWithValue("StateName", state);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                        jobs = Convert.ToInt32(result);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error retreving # of Computer Jobs: " + ex.Message);
            }
            return jobs;
        }

        private void StateInfoForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
