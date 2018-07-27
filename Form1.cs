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

        public string openedData;
        public string srv, port, user, pass, db;
        public string connect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            locCombo.SelectedIndex = 0;
            string srv = Program.server;
            string port = Program.port;
            string user = Program.user;
            string pass = Program.pass;
            string db = Program.db;

            connect = "server=" + srv + ";port=" + port + ";user=" + user + ";password=" + pass + ";database=" + db + ";";
            getData_Leaderboard();
        }

        private void getData_Loc(string command)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                try
                {
                    conn.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MySqlDataReader read = cmd.ExecuteReader();
                dt.Load(read);

                if (dt.Rows.Count > 0)
                {
                    dataLelang.DataSource = dt;
                }

                conn.Close();
            }
        }

        private void getData_Leaderboard()
        {
            DataTable dt = new DataTable();
            string command = "select pemenang Pemenang, count(*) Jumlah from (SELECT * FROM pkl.bantul b UNION ALL SELECT * FROM pkl.gunungkidul gk UNION ALL SELECT * FROM pkl.jogjakota jk UNION ALL SELECT * FROM pkl.jogjaprov jp UNION ALL SELECT * FROM pkl.kulonprogo kp UNION ALL SELECT * FROM pkl.sleman s UNION ALL SELECT * FROM pkl.ugm u) x group by pemenang order by count(*) desc limit 10";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                try
                {
                    conn.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MySqlDataReader read = cmd.ExecuteReader();
                dt.Load(read);

                if (dt.Rows.Count > 0)
                {
                    dataLeaderboard.DataSource = dt;
                }

                conn.Close();
            }
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

        private void locGraph_Click(object sender, EventArgs e)
        {
            if (openedData == "semua")
            {
                MessageBox.Show("Data terlalu banyak (> 10.000).\nSilahkan pilih lokasi lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void locGet_Click(object sender, EventArgs e)
        {
            string command = "SELECT * FROM ";
            string location = "";

            if (locCombo.SelectedIndex == 0)
            {
                location = "(SELECT * FROM pkl.bantul b UNION ALL SELECT * FROM pkl.gunungkidul gk UNION ALL SELECT * FROM pkl.jogjakota jk UNION ALL SELECT * FROM pkl.jogjaprov jp UNION ALL SELECT * FROM pkl.kulonprogo kp UNION ALL SELECT * FROM pkl.sleman s UNION ALL SELECT * FROM pkl.ugm u) x";
                openedData = "semua";
            }
            else if (locCombo.SelectedIndex == 1)
            {
                location = "bantul";
                openedData = location;
            }
            else if (locCombo.SelectedIndex == 2)
            {
                location = "kulonprogo";
                openedData = location;
            }
            else if (locCombo.SelectedIndex == 3)
            {
                location = "sleman";
                openedData = location;
            }
            else if (locCombo.SelectedIndex == 4)
            {
                location = "gunungkidul";
                openedData = location;
            }
            else if (locCombo.SelectedIndex == 5)
            {
                location = "jogjakota";
                openedData = location;
            }
            else if (locCombo.SelectedIndex == 6)
            {
                location = "jogjaprov";
                openedData = location;
            }
            else if (locCombo.SelectedIndex == 7)
            {
                location = "ugm";
                openedData = location;
            }

            command += location;

            getData_Loc(command);
        }

        private void idGet_Click(object sender, EventArgs e)
        {
            string command = "SELECT * FROM (SELECT * FROM pkl.bantul b UNION ALL SELECT * FROM pkl.gunungkidul gk UNION ALL SELECT * FROM pkl.jogjakota jk UNION ALL SELECT * FROM pkl.jogjaprov jp UNION ALL SELECT * FROM pkl.kulonprogo kp UNION ALL SELECT * FROM pkl.sleman s UNION ALL SELECT * FROM pkl.ugm u) x WHERE id="+searchBox.Text;
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                MySqlCommand check = new MySqlCommand();
                check.Connection = conn;
                check.CommandText = "SELECT count(*) FROM (SELECT * FROM pkl.bantul b UNION ALL SELECT * FROM pkl.gunungkidul gk UNION ALL SELECT * FROM pkl.jogjakota jk UNION ALL SELECT * FROM pkl.jogjaprov jp UNION ALL SELECT * FROM pkl.kulonprogo kp UNION ALL SELECT * FROM pkl.sleman s UNION ALL SELECT * FROM pkl.ugm u) x WHERE id=" + searchBox.Text;
                try
                {
                    conn.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    int result = int.Parse(check.ExecuteScalar().ToString()); //single value

                    if (result == 0)
                    {
                        MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        idSearch.Text = "n/a";
                        nameSearch.Text = "n/a";
                        instanceSearch.Text = "n/a";
                        typeSearch.Text = "n/a";
                        winnerSearch.Text = "n/a";
                        searchBox.Text = "";
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand(command, conn);
                        MySqlDataReader read = cmd.ExecuteReader();

                        while (read.Read())
                        {
                            idSearch.Text = read.GetString("ID");
                            nameSearch.Text = read.GetString("Nama Lelang");
                            instanceSearch.Text = read.GetString("Instansi");
                            typeSearch.Text = read.GetString("Tipe");
                            winnerSearch.Text = read.GetString("Pemenang");
                        }
                    }
                }
                conn.Close();
            }
        }
        private void detailSearchGet_Click(object sender, EventArgs e)
        {
            string loc = "";
            if (searchBox.Text.EndsWith("303"))
            {
                loc = "ugm.ac";
            }
            else if (searchBox.Text.EndsWith("367"))
            {
                loc = "kulonprogokab.go";
            }
            else if (searchBox.Text.EndsWith("021"))
            {
                loc = "jogjakota.go";
            }
            else if (searchBox.Text.EndsWith("054"))
            {
                loc = "slemankab.go";
            }
            else if (searchBox.Text.EndsWith("013"))
            {
                loc = "jogjaprov.go";
            }
            else if (searchBox.Text.EndsWith("621"))
            {
                loc = "gunungkidulkab.go";
            }
            else if (searchBox.Text.EndsWith("285"))
            {
                loc = "bantulkab.go";
            }

            System.Diagnostics.Process.Start("http://lpse."+loc+".id/eproc4/evaluasi/"+ searchBox.Text + "/pemenang");
        }
    }
}
