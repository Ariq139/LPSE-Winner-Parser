﻿using MySql.Data.MySqlClient;
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

namespace LPSE_UGM_Winner_Parser
{
    public partial class crawler : Form
    {
        public string kode_lpse, link_lpse;

        public crawler()
        {
            InitializeComponent();
        }

        private void crawler_Load(object sender, EventArgs e)
        {
            locCombo.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startBox.Text = "1";
            endBox.Text = "8000";
            retryBox.Text = "3";
        }

        //start script python
        private void startScript_Click(object sender, EventArgs e)
        {
            int tmp_parse;

            DialogResult result = MessageBox.Show("This process can take a long time. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                startScript.Enabled = false;
                locCombo.Enabled = false;
                startBox.Enabled = false;
                endBox.Enabled = false;
                retryBox.Enabled = false;
                button2.Enabled = false;

                if (startBox.Text == "" || endBox.Text == "" || retryBox.Text == "")
                {
                    MessageBox.Show("Please fill in the box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(int.TryParse(startBox.Text, out tmp_parse)) || !(int.TryParse(endBox.Text, out tmp_parse)) || !(int.TryParse(retryBox.Text, out tmp_parse)))
                {
                    MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(startBox.Text) > Convert.ToInt32(endBox.Text))
                {
                    MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tmp2 = '"' + locCombo.SelectedItem.ToString() + '"';
                    string command = "SELECT kode_lpse,link_lpse FROM daftar_lpse WHERE nama_lpse = " + tmp2;
                    using (MySqlConnection conn = new MySqlConnection("server=" + Program.server + ";port=" + Program.port + ";user=" + Program.user + ";password=" + Program.pass + ";database=" + Program.db + ";"))
                    {
                        try
                        {
                            conn.Open();

                            MySqlCommand cmd = new MySqlCommand(command, conn);
                            MySqlDataReader read = cmd.ExecuteReader();

                            while (read.Read())
                            {
                                kode_lpse = read.GetString("kode_lpse");
                                link_lpse = read.GetString("link_lpse");
                            }
                            conn.Close();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    ProcessStartInfo start = new ProcessStartInfo("python.exe");
                    start.Arguments = Program.resource_path + "winner_get.py" + " " + startBox.Text + " " + endBox.Text + " " + retryBox.Text + " " + '"' + link_lpse + '"' + " " + kode_lpse + " " + Program.server + " " + Program.port + " " + Program.db + " " + Program.user + " " + Program.pass;
                    start.UseShellExecute = false;// Do not use OS shell
                    start.CreateNoWindow = true;//no python window
                    start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
                    start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)

                    Process process = new Process();
                    process.StartInfo = start;

                    // Set our event handler to asynchronously read the sort output.
                    process.OutputDataReceived += OutputDataReceived;
                    process.ErrorDataReceived += ErrorDataReceived;

                    process.Start();

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();
                    startScript.Enabled = true;
                    locCombo.Enabled = true;
                    startBox.Enabled = true;
                    endBox.Enabled = true;
                    retryBox.Enabled = true;
                    button2.Enabled = true;

                    // close the process 
                    process.Close();
                }
            }
        }

        private void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }

        private void ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }
    }
}
