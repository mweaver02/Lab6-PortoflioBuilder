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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nbaPictureBox_Click(object sender, EventArgs e)
        {
            NBAForm nBAForm = new NBAForm();
            nBAForm.ShowDialog();
        }

        private void footballPictureBox_Click(object sender, EventArgs e)
        {
            NFLForm nFLForm = new NFLForm();
            nFLForm.ShowDialog();
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
