using SportsSearch.DatabaseNFLDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsSearch
{
    public partial class NFLForm : Form
    {
        public NFLForm()
        {
            InitializeComponent();
        }

        //On Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            //Load data into the 7 tables
                this.nFLDefensiveStats2023TableAdapter.Fill(this.databaseNFLDataSet.NFLDefensiveStats2023);
                this.nFLReceivingStats2023TableAdapter.Fill(this.databaseNFLDataSet.NFLReceivingStats2023);
                this.nFLPassingStats2023TableAdapter.Fill(this.databaseNFLDataSet.NFLPassingStats2023);
                this.nFLRushingStats2023TableAdapter.Fill(this.databaseNFLDataSet.NFLRushingStats2023);
                this.nFLTeamStatsDefensive2023TableAdapter.Fill(this.databaseNFLDataSet.NFLTeamStatsDefensive2023);
                this.nFLTeamStatsOffense2023TableAdapter.Fill(this.databaseNFLDataSet.NFLTeamStatsOffense2023);
                this.nFLStandings2023TableAdapter.Fill(this.databaseNFLDataSet.NFLStandings2023);

            //Fill listbox with names of columns
            DataTable table = databaseNFLDataSet.NFLStandings2023;
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
            string column = "[" + lbColumn.SelectedItem.ToString() + "]"; //Get column selected [Put in brackets or sql gets mad]
            string text = tSearch.Text; //Get text from texbox

            Search(index, column, text); //Call search method
        }


        //Search method
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
                case 0:     table = "NFLStandings2023";             adapter = nFLStandings2023TableAdapter.Adapter;         break;
                case 1:     table = "NFLTeamStatsOffense2023";      adapter = nFLTeamStatsOffense2023TableAdapter.Adapter;  break;
                case 2:     table = "NFLTeamStatsDefensive2023";    adapter = nFLDefensiveStats2023TableAdapter.Adapter;    break;
                case 3:     table = "NFLRushingStats2023";          adapter = nFLRushingStats2023TableAdapter.Adapter;      break;
                case 4:     table = "NFLPassingStats2023";          adapter = nFLPassingStats2023TableAdapter.Adapter;      break;
                case 5:     table = "NFLReceivingStats2023";        adapter = nFLReceivingStats2023TableAdapter.Adapter;    break;
                case 6:     table = "NFLDefensiveStats2023";        adapter = nFLDefensiveStats2023TableAdapter.Adapter;    break;
            }

            string query = $"SELECT * FROM {table} WHERE {column} LIKE @search"; //Build query
            adapter.SelectCommand.Parameters.Clear();   //Clear parameters (or it will keep adding new ones)
            adapter.SelectCommand.CommandText = query;  //Set query
            adapter.SelectCommand.Parameters.AddWithValue("@search", $"{text}%"); //Set parameter

            //Execute query based on tab (I couldnt get adapter.fill to work, which would've made this one line)
            switch (index)
            {
                case 0:     nFLStandings2023TableAdapter.Fill(databaseNFLDataSet.NFLStandings2023);                     break;
                case 1:     nFLTeamStatsOffense2023TableAdapter.Fill(databaseNFLDataSet.NFLTeamStatsOffense2023);       break;
                case 2:     nFLTeamStatsDefensive2023TableAdapter.Fill(databaseNFLDataSet.NFLTeamStatsDefensive2023);   break;
                case 3:     nFLRushingStats2023TableAdapter.Fill(databaseNFLDataSet.NFLRushingStats2023);               break;
                case 4:     nFLPassingStats2023TableAdapter.Fill(databaseNFLDataSet.NFLPassingStats2023);               break;
                case 5:     nFLReceivingStats2023TableAdapter.Fill(databaseNFLDataSet.NFLReceivingStats2023);           break;
                case 6:     nFLDefensiveStats2023TableAdapter.Fill(databaseNFLDataSet.NFLDefensiveStats2023);           break;
            }
        }

        //Tab Change
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbColumn.Items.Clear(); //Clear items so they dont just get added to the end
            DataTable table = databaseNFLDataSet.NFLStandings2023;

            //Change table based on tab
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    table = databaseNFLDataSet.NFLStandings2023;
                    break;
                case 1:
                    table = databaseNFLDataSet.NFLTeamStatsOffense2023;
                    break;
                case 2:
                    table = databaseNFLDataSet.NFLTeamStatsDefensive2023;
                    break;
                case 3:
                    table = databaseNFLDataSet.NFLRushingStats2023;
                    break;
                case 4:
                    table = databaseNFLDataSet.NFLPassingStats2023;
                    break;
                case 5:
                    table = databaseNFLDataSet.NFLReceivingStats2023;
                    break;
                case 6:
                    table = databaseNFLDataSet.NFLDefensiveStats2023;
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

        //Exit
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
