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
        public string location_db = "";
        public string connect = "server=" + Program.server + ";port=" + Program.port + ";user=" + Program.user + ";password=" + Program.pass + ";database=" + Program.db + ";";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            locCombo.SelectedIndex = 0;

            getData_Leaderboard();

            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
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
            string command = "select pemenang Pemenang, count(*) Jumlah from (SELECT * FROM " + Program.db + ".bantul b UNION ALL SELECT * FROM " + Program.db + ".gunungkidul gk UNION ALL SELECT * FROM " + Program.db + ".jogjakota jk UNION ALL SELECT * FROM " + Program.db + ".jogjaprov jp UNION ALL SELECT * FROM " + Program.db + ".kulonprogo kp UNION ALL SELECT * FROM " + Program.db + ".sleman s UNION ALL SELECT * FROM " + Program.db + ".ugm u) x group by pemenang order by count(*) desc limit 10";
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

            if (locCombo.SelectedIndex == 0)
            {
                location_db = "(SELECT * FROM " + Program.db + ".bantul b UNION ALL SELECT * FROM " + Program.db + ".gunungkidul gk UNION ALL SELECT * FROM " + Program.db + ".jogjakota jk UNION ALL SELECT * FROM " + Program.db + ".jogjaprov jp UNION ALL SELECT * FROM " + Program.db + ".kulonprogo kp UNION ALL SELECT * FROM " + Program.db + ".sleman s UNION ALL SELECT * FROM " + Program.db + ".ugm u) x";
                openedData = "semua";
            }
            else if (locCombo.SelectedIndex == 1)
            {
                location_db = Program.db + ".bantul";
                openedData = "bantul";
            }
            else if (locCombo.SelectedIndex == 2)
            {
                location_db = Program.db + ".kulonprogo";
                openedData = "kulonprogo";
            }
            else if (locCombo.SelectedIndex == 3)
            {
                location_db = Program.db + ".sleman";
                openedData = "sleman";
            }
            else if (locCombo.SelectedIndex == 4)
            {
                location_db = Program.db + ".gunungkidul";
                openedData = "gunungkidul";
            }
            else if (locCombo.SelectedIndex == 5)
            {
                location_db = Program.db + ".jogjakota";
                openedData = "jogjakota";
            }
            else if (locCombo.SelectedIndex == 6)
            {
                location_db = Program.db + ".jogjaprov";
                openedData = "jogjaprov";
            }
            else if (locCombo.SelectedIndex == 7)
            {
                location_db = Program.db + ".ugm";
                openedData = "ugm";
            }

            command += location_db;

            getData_Loc(command);
            exportBtn.Enabled = true;
        }

        private void idGet_Click(object sender, EventArgs e)
        {
            string command = "SELECT * FROM (SELECT * FROM "+Program.db+ ".bantul b UNION ALL SELECT * FROM " + Program.db + ".gunungkidul gk UNION ALL SELECT * FROM " + Program.db + ".jogjakota jk UNION ALL SELECT * FROM " + Program.db + ".jogjaprov jp UNION ALL SELECT * FROM " + Program.db + ".kulonprogo kp UNION ALL SELECT * FROM " + Program.db + ".sleman s UNION ALL SELECT * FROM " + Program.db + ".ugm u) x WHERE id=" + searchBox.Text;
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                MySqlCommand check = new MySqlCommand();
                check.Connection = conn;
                check.CommandText = "SELECT count(*) FROM (SELECT * FROM " + Program.db + ".bantul b UNION ALL SELECT * FROM " + Program.db + ".gunungkidul gk UNION ALL SELECT * FROM " + Program.db + ".jogjakota jk UNION ALL SELECT * FROM " + Program.db + ".jogjaprov jp UNION ALL SELECT * FROM " + Program.db + ".kulonprogo kp UNION ALL SELECT * FROM " + Program.db + ".sleman s UNION ALL SELECT * FROM " + Program.db + ".ugm u) x WHERE id=" + searchBox.Text;
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

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new db_login().ShowDialog();
        }

        private void locCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            exportBtn.Enabled = false;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Comma-separated values | *.csv";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string tmp2 = @"'\n'";
                char tmp3 = '"';
                save.FileName = save.FileName.Replace(@"\", @"\\");
                string command = "SELECT * INTO OUTFILE " + '"' + save.FileName + '"' + " FIELDS TERMINATED BY ';' OPTIONALLY ENCLOSED BY '" + tmp3 + "' LINES TERMINATED BY " + tmp2 + " FROM " + location_db + ";";
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    MySqlCommand cmd = new MySqlCommand(command, conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteReader();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                }
            }
        }

        private void graphOpt_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible)
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
            }
        }
    }
}
