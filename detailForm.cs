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

        private void detailForm_Load(object sender, EventArgs e)
        {
            getData_Detail();
        }

        private void getData_Detail()
        {
            DataTable dt = new DataTable();
            string connect = "server=" + Program.server + ";port=" + Program.port + ";user=" + Program.user + ";password=" + Program.pass + ";database=" + Program.db + ";";
            string command = "SELECT pengumuman.id_lelang, pengumuman.nama_lelang, pengumuman.instansi, pemenang_detail.nama_perusahaan FROM pengumuman, pemenang, pemenang_detail WHERE pengumuman.id_lelang = pemenang.id_lelang AND pemenang.npwp = pemenang_detail.npwp AND pemenang_detail.nama_perusahaan IN (SELECT pemenang_detail.nama_perusahaan FROM pemenang,pemenang_detail WHERE pemenang_detail.npwp = pemenang.npwp GROUP BY pemenang_detail.nama_perusahaan ORDER BY count(*) DESC)";
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
                        dataDetail.DataSource = dt;
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
