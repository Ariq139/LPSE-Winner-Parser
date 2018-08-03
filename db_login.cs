using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPSE_UGM_Winner_Parser
{
    public partial class db_login : Form
    {
        public db_login()
        {
            InitializeComponent();
        }

        private void db_login_Load(object sender, EventArgs e)
        {
            passBox.PasswordChar = '*';
        }

        //Create new db / first run
        private void createBtn_Click_1(object sender, EventArgs e)
        {
            Program.server = srvBox.Text;
            Program.port = portBox.Text;
            Program.user = userBox.Text;
            Program.pass = passBox.Text;
            Program.db = dbBox.Text;

            using (MySqlConnection conn = new MySqlConnection("server=" + srvBox.Text + ";port=" + portBox.Text + ";user=" + userBox.Text + ";password=" + passBox.Text + ";"))
            {
                try
                {
                    string command = "CREATE DATABASE IF NOT EXISTS " + dbBox.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(command, conn);
                    conn.Open();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            using (MySqlConnection conn = new MySqlConnection("server=" + srvBox.Text + ";port=" + portBox.Text + ";user=" + userBox.Text + ";password=" + passBox.Text + ";database=" + dbBox.Text + ";"))
            {
                try
                {
                    conn.Open();
                    conn.Close();
                    this.Hide();
                    new Form1().ShowDialog();
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Reset value
        private void button1_Click(object sender, EventArgs e)
        {
            srvBox.Text = "localhost";
            portBox.Text = "3306";
            userBox.Text = "root";
            passBox.Text = "";
            dbBox.Text = "pkl_v2";
        }

        //login to existing db
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Program.server = srvBox.Text;
            Program.port = portBox.Text;
            Program.user = userBox.Text;
            Program.pass = passBox.Text;
            Program.db = dbBox.Text;

            using (MySqlConnection conn = new MySqlConnection("server=" + srvBox.Text + ";port=" + portBox.Text + ";user=" + userBox.Text + ";password=" + passBox.Text + ";database=" + dbBox.Text + ";"))
            {
                try
                {
                    conn.Open();
                    conn.Close();
                    this.Hide();
                    new Form1().ShowDialog();
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
