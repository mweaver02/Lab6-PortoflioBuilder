using SportsSearch.DatabaseNFLDataSetTableAdapters;
using SportsSearch.NBADatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SportsSearch
{
    public partial class NBAForm : Form
    {
        public NBAForm()
        {
            InitializeComponent();
        }
        private void NBAForm_Load(object sender, EventArgs e)
        {
            //Load data into 4 tables
            this.nBAPlayerStats2023UpdatedTableAdapter.Fill(this.nBADatabaseDataSet.NBAPlayerStats2023Updated);
            this.nBATeamStats2023UpdatedTableAdapter.Fill(this.nBADatabaseDataSet.NBATeamStats2023Updated);
            this.nBAStandings2023UpdatedTableAdapter.Fill(this.nBADatabaseDataSet.NBAStandings2023Updated);
            this.nBASchedule2023UpdatedTableAdapter.Fill(this.nBADatabaseDataSet.NBASchedule2023Updated);

            //Fill listbox with names of columns
            DataTable table = nBADatabaseDataSet.NBASchedule2023Updated;
            foreach (DataColumn column in table.Columns)
            {
                lbColumn.Items.Add(column.ColumnName);
            }
            lbColumn.SelectedIndex = 0; //select first item in listbox
        }

        //Search Button
        private void bSearch_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex; //Get table selected
            string column = "[" + lbColumn.SelectedItem.ToString() + "]"; //Get column selected [Put in brackets or else sql gets mad]
            string text = tSearch.Text; //Get text from texbox

            Search(index, column, text); //Call search method
        }

        private void Search(int index, string column, string text)
        {
            //The goal is to make a query that allows the user to pick the search text, and the column searched in.
            //To protect from sql injections, the search text needs to be a parameter.
            //This way, only one query is needed, instead of one query for every column

            string table = ""; //Table to be used
            OleDbDataAdapter adapter = null; //Adapter to be used

            switch (index) //switch based on tab
            {
                //Get table;                            Get adapter
                case 0: table = "NBASchedule2023Updated"; adapter = nBASchedule2023UpdatedTableAdapter.Adapter; break;
                case 1: table = "NBAStandings2023Updated"; adapter = nBAStandings2023UpdatedTableAdapter.Adapter; break;
                case 2: table = "NBATeamStats2023Updated"; adapter = nBATeamStats2023UpdatedTableAdapter.Adapter; break;
                case 3: table = "NBAPlayerStats2023Updated"; adapter = nBAPlayerStats2023UpdatedTableAdapter.Adapter; break;
            }

            string query = $"SELECT * FROM {table} WHERE {column} LIKE @search"; //Build query
            adapter.SelectCommand.Parameters.Clear();   //Clear parameters (or it will keep adding new ones)
            adapter.SelectCommand.CommandText = query;  //Set query
            adapter.SelectCommand.Parameters.AddWithValue("@search", $"{text}%"); //Set parameter

            //Execute query based on tab (I couldnt get adapter.fill to work, which would've made this one line)
            switch (index)
            {
                case 0: nBASchedule2023UpdatedTableAdapter.Fill(nBADatabaseDataSet.NBASchedule2023Updated); break;
                case 1: nBAStandings2023UpdatedTableAdapter.Fill(nBADatabaseDataSet.NBAStandings2023Updated); break;
                case 2: nBATeamStats2023UpdatedTableAdapter.Fill(nBADatabaseDataSet.NBATeamStats2023Updated); break;
                case 3: nBAPlayerStats2023UpdatedTableAdapter.Fill(nBADatabaseDataSet.NBAPlayerStats2023Updated); break;
            }
        }


        //Tab Change
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbColumn.Items.Clear(); //Clear items so they dont just get added to the end
            DataTable table = nBADatabaseDataSet.NBASchedule2023Updated;

            //Change table based on tab
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    table = nBADatabaseDataSet.NBASchedule2023Updated;
                    break;
                case 1:
                    table = nBADatabaseDataSet.NBAStandings2023Updated;
                    break;
                case 2:
                    table = nBADatabaseDataSet.NBATeamStats2023Updated;
                    break;
                case 3:
                    table = nBADatabaseDataSet.NBAPlayerStats2023Updated;
                    break;
            }

            //Fill listbox with column names
            foreach (DataColumn column in table.Columns)
            {
                lbColumn.Items.Add(column.ColumnName);
            }
            //reselect item 1 each time tab changes (it wont stay index 1 with dynamic items)
            lbColumn.SelectedIndex = 0;

        }

        //Exit
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear
        private void bClear_Click(object sender, EventArgs e)
        {
            //Clear variables before passing back to search method
            tSearch.Clear();
            lbColumn.SelectedIndex = 0;

            int index = tabControl1.SelectedIndex;
            string column = lbColumn.SelectedItem.ToString();
            string text = tSearch.Text;

            Search(index, column, text); //Call search method
        }
    }
}
