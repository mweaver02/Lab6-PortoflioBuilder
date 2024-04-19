using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace MaxWeaver_CPT_206_Lab2
{
    public partial class StateForm : Form
    {
        //Declare connection ot the database
        private OleDbConnection connection; 
        // Set the connection string to the location of the Access database file.
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\maxwe\\source\\repos\\MaxWeaver-CPT 206-Lab2\\StatesDB.accdb\"";
        public StateForm()
        {
            InitializeComponent();
        }

        private void stateInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDBDataSet);

        }

        private void StateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDBDataSet.StateInfo' table. You can move, or remove it, as needed.
            this.stateInfoTableAdapter.Fill(this.statesDBDataSet.StateInfo);
            CenterToScreen();
            selectionToolTip.SetToolTip(stateComboBox, "Select a state to see it's information");
            restoreToolTip.SetToolTip(restoreButton, "Click to restore table to default display");
        }

        public void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = stateComboBox.SelectedItem.ToString();
            StateInfoForm stateDetailsForm = new StateInfoForm(selectedState);
            stateDetailsForm.Show();
        }

        //Event handlers for sorting and filtering state information based on various criteria.
        // These methods call corresponding methods in the stateInfoTableAdapter to retrieve and display data.
        private void revAlphButton_Click(object sender, EventArgs e)
        {
            this.stateInfoTableAdapter.FillByStateNameDesc(this.statesDBDataSet.StateInfo);
        }

        private void popAscButton_Click(object sender, EventArgs e)
        {
            this.stateInfoTableAdapter.FillByPopAsc(this.statesDBDataSet.StateInfo);
        }

        private void popDescButton_Click(object sender, EventArgs e)
        {
            this.stateInfoTableAdapter.FillByPopDesc(this.statesDBDataSet.StateInfo);
        }

        private void incomeAsc_Click(object sender, EventArgs e)
        {
            this.stateInfoTableAdapter.FillByIncomeAsc(this.statesDBDataSet.StateInfo);
        }

        private void compAscButton_Click(object sender, EventArgs e)
        {
            this.stateInfoTableAdapter.FillByCompAsc(this.statesDBDataSet.StateInfo);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.stateInfoTableAdapter.FillByStateSearched(this.statesDBDataSet.StateInfo);
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            StateForm stateForm = new StateForm();
            stateForm.ShowDialog();
        }

        private void popBelOneMilButton_Click(object sender, EventArgs e)
        {
 
            this.stateInfoTableAdapter.FillByBelOneMil(this.statesDBDataSet.StateInfo);
        }

        private void findIncomeBtn_Click(object sender, EventArgs e)
        {

            // Retrieve user-specified minimum and maximum job count values.
            decimal min = decimal.Parse(minTextBox.Text);
            decimal max = decimal.Parse(maxTextBox.Text);

            string query = "SELECT * FROM StateInfo WHERE MedianIncome BETWEEN @min AND @max";
            // Execute the SQL query with parameters
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MinPrice", min);
                    command.Parameters.AddWithValue("@MaxPrice", max);

                    // Execute the query and populate table with the filtered data
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    stateInfoDataGridView.DataSource = dataTable;
                }

            }
        }
        private void findMaxInBtn_Click(object sender, EventArgs e)
        {
            string stateWithMaxIncome;
            decimal maxIncome;

            // Retrieve the state with the maximum income
            DataRow row = this.stateInfoTableAdapter.GetData().Select("MedianIncome = MAX(MedianIncome)")[0];
            stateWithMaxIncome = row["StateName"].ToString();
            maxIncome = (decimal)row["MedianIncome"];

            // Display the state and its corresponding maximum income
            MessageBox.Show($"Highest Median Income is {stateWithMaxIncome}: {maxIncome.ToString("c")}");
        }
        private void minIncomeBtn_Click(object sender, EventArgs e)
        {
            string stateWithMinIncome;
            decimal minIncome;

            // Retrieve the state with the minimum income
            DataRow row = this.stateInfoTableAdapter.GetData().Select("MedianIncome = MIN(MedianIncome)")[0];
            stateWithMinIncome = row["StateName"].ToString();
            minIncome = (decimal)row["MedianIncome"];

            // Display the state and its corresponding minimum income
            MessageBox.Show($"Lowest Median Income is {stateWithMinIncome}: {minIncome.ToString("c")}");
        }


        private void findJobsBtn_Click(object sender, EventArgs e)
        {
            // Convert the text from minTextBox to decimal
            decimal min = decimal.Parse(minJobTextBox.Text);
            decimal max = decimal.Parse(maxJobTextBox.Text);

            string query = "SELECT * FROM StateInfo WHERE [# of Computer Jobs] BETWEEN @min AND @max";
            // Execute the SQL query with parameters
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MinJobs", min);
                    command.Parameters.AddWithValue("@MaxJobs", max);

                    // Execute the query and populate table with the filtered data
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    stateInfoDataGridView.DataSource = dataTable;
                }

            }
        }

        private void findMaxJobsBtn_Click(object sender, EventArgs e)
        {
            // Declaring variables to store the state with the most jobs and its job count
            string stateWithMostJobs;
            int maxJobs;

            // Retrieve the row from the StateInfo table where the number of computer jobs is maximum.
            DataRow row = this.stateInfoTableAdapter.GetData().Select("[# of Computer Jobs] = MAX([# of Computer Jobs])")[0];
            stateWithMostJobs = row["StateName"].ToString(); // Get the name of the state with the most jobs.
            maxJobs = (int)row["# of Computer Jobs"]; // Get the maximum number of computer jobs.

            MessageBox.Show($"State with the most amount of computer jobs is {stateWithMostJobs}: {maxJobs.ToString("n")}");
        }

        private void findMinJobsBtn_Click(object sender, EventArgs e)
        {
            string stateWithLeastJobs;
            int minJobs;

            DataRow row = this.stateInfoTableAdapter.GetData().Select("[# of Computer Jobs] = MIN([# of Computer Jobs])")[0];
            stateWithLeastJobs = row["StateName"].ToString();
            minJobs = (int)row["# of Computer Jobs"];

            MessageBox.Show($"State with the least amount of computer jobs is {stateWithLeastJobs}: {minJobs.ToString("n")}");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;
            string capital = capTextbox.Text;
            string largestCity = cityTextbox.Text;
            string bird = birdTextbox.Text;
            string flower = flowerTextbox.Text;


            // Get the data table from the statesDBDataSet
            try
            {
                DataTable dataTable = statesDBDataSet.StateInfo;

                // Filter the rows based on user input
                var filteredRows = dataTable.AsEnumerable();
                if (!string.IsNullOrEmpty(name))
                    filteredRows = filteredRows.Where(row => row.Field<string>("StateName") == name);
                if (!string.IsNullOrEmpty(capital))
                    filteredRows = filteredRows.Where(row => row.Field<string>("StateCapitol") == capital);
                if (!string.IsNullOrEmpty(largestCity))
                    filteredRows = filteredRows.Where(row => row.Field<string>("3_LargestCities") == largestCity);
                if (!string.IsNullOrEmpty(bird))
                    filteredRows = filteredRows.Where(row => row.Field<string>("StateBird") == bird);
                if (!string.IsNullOrEmpty(flower))
                    filteredRows = filteredRows.Where(row => row.Field<string>("StateFlower") == flower);

                // Convert filtered rows to a new DataTable
                DataTable filteredDataTable = filteredRows.CopyToDataTable();

                // Set the DataSource of your DataGridView to the filtered DataTable
                stateInfoDataGridView.DataSource = filteredDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTextbox.Text = "";
            capTextbox.Text = "";
            popTextbox.Text = "";
            cityTextbox.Text = "";
            birdTextbox.Text = "";
            flowerTextbox.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Create a list to hold references to forms to be closed
            List<Form> formsToClose = new List<Form>();

            // Add references to open forms to the list
            foreach (Form form in Application.OpenForms)
            {
                formsToClose.Add(form);
            }

            // Close each form in the list
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }

    }
}

