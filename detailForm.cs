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
    public partial class detailForm : Form
    {
        MySqlConnection mysql_con;
        MySqlCommand command;

        public detailForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
