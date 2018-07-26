using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LPSE_UGM_Winner_Parser
{
    public partial class Form1 : Form
    {
        MySqlConnection mysql_con;
        MySqlCommand command;

        public Form1()
        {
            InitializeComponent();
            typeCombo.SelectedIndex = 0;

            mysql_con.ConnectionString = "server=localhost;user=root;password=;database=pkl";

            MySqlDataReader reader;
        }

        private void topGraph_Click(object sender, EventArgs e)
        {
            detailForm dF = new detailForm();
            dF.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox about = new aboutBox();
            about.Show();
        }
    }
}
