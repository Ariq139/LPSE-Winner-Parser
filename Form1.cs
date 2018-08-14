using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            graphLocBox.SelectedIndex = 0;
            sortBox.SelectedIndex = 0;

            getData_Leaderboard();

            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void getData_Leaderboard()
        {
            DataTable dt = new DataTable();
            string command = "SELECT pemenang_detail.nama_perusahaan Nama_Perusahaan, count(*) Jumlah FROM pemenang,pemenang_detail WHERE pemenang_detail.npwp = pemenang.npwp GROUP BY pemenang_detail.nama_perusahaan ORDER BY count(*) desc limit 10";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader read = cmd.ExecuteReader();
                    dt.Load(read);

                    if (dt.Rows.Count > 0)
                    {
                        dataLeaderboard.DataSource = dt;
                    }

                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void topGraph_Click(object sender, EventArgs e)
        {
            detailForm dF = new detailForm();
            dF.Show();
        }

        private void idGet_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                string command = "SELECT pengumuman.*, pemenang_detail.nama_perusahaan, pemenang_detail.npwp FROM pengumuman, pemenang, pemenang_detail WHERE pengumuman.id_lelang = pemenang.id_lelang AND pemenang.npwp = pemenang_detail.npwp AND pengumuman.id_lelang = " + searchBox.Text;
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    MySqlCommand check = new MySqlCommand();
                    check.Connection = conn;
                    check.CommandText = "SELECT count(*) FROM (SELECT pengumuman.*, pemenang_detail.nama_perusahaan, pemenang_detail.npwp FROM pengumuman, pemenang, pemenang_detail WHERE pengumuman.id_lelang = pemenang.id_lelang AND pemenang.npwp = pemenang_detail.npwp AND pengumuman.id_lelang = " + searchBox.Text + ") x";
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
                            MessageBox.Show("No data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            searchBox.Text = "";
                        }
                        else
                        {
                            MySqlCommand cmd = new MySqlCommand(command, conn);

                            DataTable dt = new DataTable();

                            try
                            {
                                MySqlDataReader read = cmd.ExecuteReader();
                                dt.Load(read);

                                if (dt.Rows.Count > 0)
                                {
                                    dataLelang.DataSource = dt;
                                }

                                conn.Close();
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    conn.Close();
                }
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

        //option graph
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

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new crawler().ShowDialog();
        }

        private void disconnectFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new db_login().ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("readme.pdf");
        }


        //create graph
        private void button2_Click(object sender, EventArgs e)
        {
            if (colorMinBox.Text == "" || colorMaxBox.Text == "" || nodeMinBox.Text == "" || nodeMaxBox.Text == "" || labelMinBox.Text == "" || labelMaxBox.Text == "" || timeBox.Text == "" || repulsionBox.Text == "")
            {
                MessageBox.Show("Please fill in the box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedData = graphLocBox.SelectedItem.ToString();

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF|*.pdf|Gephi Graph|*.gexf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string tmp2 = @"'\n'";
                    char tmp3 = '"';
                    save.FileName = save.FileName.Replace(@"\", @"\\");

                    string source = Program.resource_path.Replace(@"\", @"\\");
                    source += "cache\\";
                    source += selectedData + ".csv";

                    //export graph
                    string command = "SELECT pemenang.id_lelang ID, pemenang.npwp NPWP, pemenang_detail.nama_perusahaan Nama_Perusahaan, pengumuman.instansi Instansi INTO OUTFILE " + '"' + source + '"' + " FIELDS TERMINATED BY ';' OPTIONALLY ENCLOSED BY '" + tmp3 + "' LINES TERMINATED BY " + tmp2 + " FROM pengumuman, pemenang, pemenang_detail WHERE pemenang.id_lelang = pengumuman.id_lelang AND pemenang.npwp = pemenang_detail.npwp;";
                    using (MySqlConnection conn = new MySqlConnection(connect))
                    {
                        MySqlCommand cmd = new MySqlCommand(command, conn);
                        try
                        {
                            conn.Open();
                            cmd.ExecuteReader();

                            conn.Close();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    ProcessStartInfo start = new ProcessStartInfo("java.exe");
                    start.Arguments = Program.resource_path + "-jar LPSEGraph.jar" + " " + source + " " + save.FileName + " " + colorMinBox.Text + " " + colorMaxBox.Text + " " + nodeMinBox.Text + " " + nodeMaxBox.Text + " " + labelMinBox.Text + " " + labelMaxBox.Text + " " + timeBox.Text + " " + repulsionBox.Text;
                    Console.WriteLine(start.Arguments);
                    start.UseShellExecute = false;// Do not use OS shell
                    start.CreateNoWindow = true;//no python window
                    start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
                    start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)

                    Process process = new Process();
                    process.StartInfo = start;

                    process.Start();

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();

                    // close the process 
                    process.Close();
                }
            }
        }

        private void importSampleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //sort data
        private void button1_Click(object sender, EventArgs e)
        {
            string command;
            string sortby = sortBox.SelectedItem.ToString();
            DataTable dt = new DataTable();

            if (sortBox.SelectedItem.ToString() == "None")
            {
                command = "SELECT pengumuman.*, pemenang_detail.nama_perusahaan FROM pengumuman, pemenang, pemenang_detail WHERE pengumuman.id_lelang = pemenang.id_lelang AND pemenang.npwp = pemenang_detail.npwp";
            }
            else
            {
                command = "SELECT pengumuman.*, pemenang_detail.nama_perusahaan FROM pengumuman, pemenang, pemenang_detail WHERE pengumuman.id_lelang = pemenang.id_lelang AND pemenang.npwp = pemenang_detail.npwp ORDER BY "+sortby;
            }
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader read = cmd.ExecuteReader();
                    dt.Load(read);

                    if (dt.Rows.Count > 0)
                    {
                        dataLelang.DataSource = dt;
                    }

                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rldBtn_Click(object sender, EventArgs e)
        {
            getData_Leaderboard();
        }
    }
}
