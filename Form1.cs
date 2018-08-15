using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        public string kode_lpse;
        public string location_db = "";
        public string connect = "server=" + Program.server + ";port=" + Program.port + ";user=" + Program.user + ";password=" + Program.pass + ";database=" + Program.db + ";";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphLocBox.SelectedIndex = 0;

            getData_Leaderboard(Int32.Parse(limitLeaderboardBox.Text));
            getData_Overview();

            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        //Load Overview data
        private void getData_Overview()
        {
            string command = "SELECT pengumuman.*, pemenang_detail.nama_perusahaan FROM pengumuman, pemenang, pemenang_detail WHERE pengumuman.id_lelang = pemenang.id_lelang AND pemenang.npwp = pemenang_detail.npwp";
            DataTable dt = new DataTable();
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

        //Load Leaderboard data
        private void getData_Leaderboard(int limit)
        {
            DataTable dt = new DataTable();
            string command = "SELECT pemenang_detail.nama_perusahaan Nama_Perusahaan, count(*) Jumlah FROM pemenang,pemenang_detail WHERE pemenang_detail.npwp = pemenang.npwp GROUP BY pemenang_detail.nama_perusahaan ORDER BY count(*) desc limit " + limit;
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
            else
            {
                getData_Overview();
            }
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
            try
            {
                System.Diagnostics.Process.Start("README.txt");
            }
            catch
            {
                MessageBox.Show("README is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Graph Creation
        //"Start" button functionality
        private void button2_Click(object sender, EventArgs e)
        {
            //No input
            if (colorMinBox.Text == "" || colorMaxBox.Text == "" || nodeMinBox.Text == "" || nodeMaxBox.Text == "" || labelMinBox.Text == "" || labelMaxBox.Text == "" || timeBox.Text == "" || repulsionBox.Text == "")
            {
                MessageBox.Show("Please fill in the box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Wrong color input
            else if (!colorMinBox.Text.StartsWith("0x") || !colorMaxBox.Text.StartsWith("0x"))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //Selected data from the dropdown
                string selectedData = graphLocBox.SelectedItem.ToString();
                string tmp_selected = '"' + selectedData + '"';
                string command_selected = "SELECT kode_lpse,link_lpse FROM daftar_lpse WHERE nama_lpse = " + tmp_selected;

                using (MySqlConnection conn_getCode = new MySqlConnection(connect))
                {
                    try
                    {
                        //Get code
                        conn_getCode.Open();

                        MySqlCommand cmd_getCode = new MySqlCommand(command_selected, conn_getCode);
                        MySqlDataReader read = cmd_getCode.ExecuteReader();

                        while (read.Read())
                        {
                            kode_lpse = read.GetString("kode_lpse");
                        }
                        conn_getCode.Close();

                        //Check the result
                        using (MySqlConnection conn_check = new MySqlConnection(connect))
                        {
                            MySqlCommand check = new MySqlCommand();
                            check.Connection = conn_check;
                            check.CommandText = "SELECT count(*) FROM (SELECT pemenang.id_lelang ID, pemenang_detail.nama_perusahaan Nama_Perusahaan, pengumuman.instansi Instansi FROM pengumuman, pemenang, pemenang_detail WHERE pemenang.id_lelang = pengumuman.id_lelang AND pemenang.npwp = pemenang_detail.npwp AND pengumuman.id_lelang LIKE '%" + kode_lpse + "'" + ") x";
                            try
                            {
                                conn_check.Open();
                                int result = int.Parse(check.ExecuteScalar().ToString()); //single value
                                conn_check.Close();

                                //No result
                                if (result == 0)
                                {
                                    MessageBox.Show("No data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    searchBox.Text = "";
                                }
                                else
                                {
                                    SaveFileDialog save = new SaveFileDialog();
                                    save.Filter = "PDF|*.pdf|Gephi Graph|*.gexf";
                                    if (save.ShowDialog() == DialogResult.OK)
                                    {
                                        //Temporary string
                                        string tmp2 = @"'\n'";
                                        save.FileName = save.FileName.Replace(@"\", @"\\");

                                        //append path
                                        string source = Program.resource_path;
                                        source += selectedData + ".csv";
                                        source = source.Replace(@"\", @"\\");

                                        //export graph
                                        string command = @"SELECT pemenang.id_lelang ID, pemenang_detail.nama_perusahaan Nama_Perusahaan, pengumuman.instansi Instansi INTO OUTFILE " + '"' + source + '"' + " FIELDS TERMINATED BY ';' OPTIONALLY ENCLOSED BY '" + '"' + "' LINES TERMINATED BY " + tmp2 + " FROM pengumuman, pemenang, pemenang_detail WHERE pemenang.id_lelang = pengumuman.id_lelang AND pemenang.npwp = pemenang_detail.npwp AND pengumuman.id_lelang LIKE '%" + kode_lpse + "'";

                                        using (MySqlConnection conn = new MySqlConnection(connect))
                                        {
                                            MySqlCommand cmd_export = new MySqlCommand(command, conn);
                                            try
                                            {
                                                conn.Open();
                                                cmd_export.ExecuteReader();
                                                conn.Close();

                                                //graph option section
                                                groupBox2.Enabled = false;
                                                groupBox3.Enabled = false;
                                                groupBox4.Enabled = false;
                                                groupBox5.Enabled = false;

                                                graphOpt.Enabled = false;
                                                button3.Enabled = false;
                                                createGraphBtn.Enabled = false;
                                                graphLocBox.Enabled = false;

                                                ProcessStartInfo start = new ProcessStartInfo("java.exe");

                                                //source0, destination1, colorMin2, colorMax3, rankSizeMin4, rankSizeMax5, labelSizeMin6, labelSizeMax7, seconds8, repulsion9
                                                start.Arguments = "-jar " + '"' + Program.resource_path + "LPSEGraph.jar" + '"' + " " + '"' + source + '"' + " " + '"' + save.FileName + '"' + " " + colorMinBox.Text + " " + colorMaxBox.Text + " " + nodeMinBox.Text + " " + nodeMaxBox.Text + " " + labelMinBox.Text + " " + labelMaxBox.Text + " " + timeBox.Text + " " + repulsionBox.Text;

                                                start.UseShellExecute = false;// Do not use OS shell
                                                start.CreateNoWindow = true;//no python window
                                                start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
                                                start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)

                                                Process process = new Process();
                                                process.StartInfo = start;

                                                process.Start();
                                                Console.WriteLine("Creating graph for " + selectedData + "......");

                                                process.BeginOutputReadLine();
                                                process.BeginErrorReadLine();

                                                process.WaitForExit();

                                                //graph option section
                                                groupBox2.Enabled = true;
                                                groupBox3.Enabled = true;
                                                groupBox4.Enabled = true;
                                                groupBox5.Enabled = true;

                                                graphOpt.Enabled = true;
                                                button3.Enabled = true;
                                                createGraphBtn.Enabled = true;
                                                graphLocBox.Enabled = true;
                                                File.Delete(source);
                                                Console.WriteLine("Graph done.");

                                                System.Diagnostics.Process.Start(save.FileName);

                                                // close the process 
                                                process.Close();
                                            }
                                            catch (MySqlException ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }
                                        }
                                    }
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void rldBtn_Click(object sender, EventArgs e)
        {
            getData_Leaderboard(10);
        }

        //reset graph settings
        private void button3_Click(object sender, EventArgs e)
        {
            colorMinBox.Text = "0xFFC0D9";
            colorMaxBox.Text = "0xAAAAFF";
            nodeMinBox.Text = "0.8";
            nodeMaxBox.Text = "3";
            labelMinBox.Text = "0.6";
            labelMaxBox.Text = "3";
            timeBox.Text = "120";
            repulsionBox.Text = "2000";
        }

        private void limitLeaderboardBtn_Click(object sender, EventArgs e)
        {
            int tmp;
            if (!Int32.TryParse(limitLeaderboardBox.Text, out tmp))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = new DataTable();
                string command = "SELECT pemenang_detail.nama_perusahaan Nama_Perusahaan, count(*) Jumlah FROM pemenang,pemenang_detail WHERE pemenang_detail.npwp = pemenang.npwp GROUP BY pemenang_detail.nama_perusahaan ORDER BY count(*) desc limit " + Int32.Parse(limitLeaderboardBox.Text);
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
        }
    }
}
