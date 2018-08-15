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

            MySqlConnection conn = new MySqlConnection("server=" + srvBox.Text + ";port=" + portBox.Text + ";user=" + userBox.Text + ";password=" + passBox.Text + ";");
            try
            {
                string command_db = "CREATE DATABASE IF NOT EXISTS " + dbBox.Text + ";";
                MySqlCommand cmd_db = new MySqlCommand(command_db, conn);
                conn.Open();
                cmd_db.ExecuteNonQuery();
                conn.Close();

                using (MySqlConnection conn_init = new MySqlConnection("server=" + srvBox.Text + ";port=" + portBox.Text + ";user=" + userBox.Text + ";password=" + passBox.Text + ";database=" + dbBox.Text + ";"))
                {
                    try
                    {
                        conn_init.Open();

                        //tabel daftar_lpse
                        string command_table1 = "CREATE TABLE `daftar_lpse` (`kode_lpse` varchar(8) NOT NULL, `nama_lpse` varchar(255) NOT NULL, `link_lpse` varchar(255) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ";
                        MySqlCommand cmd_table1 = new MySqlCommand(command_table1, conn_init);
                        cmd_table1.ExecuteNonQuery();

                        //insert ke tabel daftar_lpse
                        string command_inserttable1 = "INSERT INTO `daftar_lpse` (`kode_lpse`, `nama_lpse`, `link_lpse`) VALUES ('013', 'LPSE Provinsi Daerah Istimewa Yogyakarta', 'https://lpse.jogjaprov.go.id'), ('021', 'LPSE Kota Yogyakarta', 'https://lpse.jogjakota.go.id'), ('054', 'LPSE Kabupaten Sleman', 'https://lpse.slemankab.go.id'), ('285', 'LPSE Kabupaten Bantul', 'http://lpse.bantulkab.go.id'), ('303', 'LPSE Universitas Gadjah Mada', 'https://lpse.ugm.ac.id'), ('367', 'LPSE Kabupaten Kulon Progo', 'http://lpse.kulonprogokab.go.id'), ('621', 'LPSE Kabupaten Gunung Kidul', 'http://lpse.gunungkidulkab.go.id'); ";
                        MySqlCommand cmd_inserttable1 = new MySqlCommand(command_inserttable1, conn_init);
                        cmd_inserttable1.ExecuteNonQuery();

                        //tabel evaluasi
                        string command_table15 = "CREATE TABLE `evaluasi` (`id_lelang` varchar(16) NOT NULL, `npwp` varchar(24) NOT NULL, `K` tinyint(1) DEFAULT NULL, `A` tinyint(1) DEFAULT NULL, `T` tinyint(1) DEFAULT NULL, `penawaran` varchar(32) DEFAULT NULL, `penawaran_terkoreksi` varchar(32) DEFAULT NULL, `H` tinyint(1) DEFAULT NULL, `P` tinyint(1) DEFAULT NULL, `PK` tinyint(1) DEFAULT NULL, `alasan` varchar(255) DEFAULT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ";
                        MySqlCommand cmd_table15 = new MySqlCommand(command_table15, conn_init);
                        cmd_table15.ExecuteNonQuery();

                        //tabel pemenang
                        string command_table2 = "CREATE TABLE `pemenang` (`id_lelang` varchar(16) NOT NULL, `npwp` varchar(24) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ";
                        MySqlCommand cmd_table2 = new MySqlCommand(command_table2, conn_init);
                        cmd_table2.ExecuteNonQuery();

                        //tabel pemenang_detail
                        string command_table3 = "CREATE TABLE `pemenang_detail` (`npwp` varchar(24) NOT NULL, `nama_perusahaan` varchar(255) NOT NULL, `alamat_perusahaan` varchar(255) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ";
                        MySqlCommand cmd_table3 = new MySqlCommand(command_table3, conn_init);
                        cmd_table3.ExecuteNonQuery();

                        //tabel pengumuman
                        string command_table4 = "CREATE TABLE `pengumuman` (`id_lelang` varchar(16) NOT NULL, `nama_lelang` varchar(255) NOT NULL, `tgl_buat` varchar(64) NOT NULL, `tahap` varchar(64) NOT NULL, `instansi` varchar(128) DEFAULT NULL, `satker` varchar(128) NOT NULL, `kategori` varchar(128) NOT NULL, `thn_anggaran` varchar(16) NOT NULL, `pagu` varchar(32) DEFAULT NULL, `hps` varchar(32) DEFAULT NULL, `jml_peserta` int(3) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ";
                        MySqlCommand cmd_table4 = new MySqlCommand(command_table4, conn_init);
                        cmd_table4.ExecuteNonQuery();

                        //tabel peserta
                        string command_table5 = "CREATE TABLE `peserta` (`id_lelang` varchar(16) NOT NULL, `nama_perusahaan` varchar(128) NOT NULL, `npwp` varchar(24) NOT NULL, `penawaran` varchar(32) DEFAULT NULL, `penawaran_terkoreksi` varchar(32) DEFAULT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ";
                        MySqlCommand cmd_table5 = new MySqlCommand(command_table5, conn_init);
                        cmd_table5.ExecuteNonQuery();

                        //tabel tahap
                        string command_table6 = "CREATE TABLE `tahap` (`id_lelang` varchar(16) NOT NULL, `nama_tahap` varchar(128) NOT NULL, `mulai` varchar(64) NOT NULL, `sampai` varchar(64) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ";
                        MySqlCommand cmd_table6 = new MySqlCommand(command_table6, conn_init);
                        cmd_table6.ExecuteNonQuery();


                        //primary key daftar_lpse
                        string command_pk1 = "ALTER TABLE `daftar_lpse` ADD PRIMARY KEY(`kode_lpse`); ";
                        MySqlCommand cmd_pk1 = new MySqlCommand(command_pk1, conn_init);
                        cmd_pk1.ExecuteNonQuery();


                        //primary key evaluasi
                        string command_pk15 = "ALTER TABLE `evaluasi` ADD PRIMARY KEY(`id_lelang`,`npwp`); ";
                        MySqlCommand cmd_pk15 = new MySqlCommand(command_pk15, conn_init);
                        cmd_pk15.ExecuteNonQuery();
                        //

                        //primary key pemenang
                        string command_pk2 = "ALTER TABLE `pemenang` ADD PRIMARY KEY(`id_lelang`,`npwp`); ";
                        MySqlCommand cmd_pk2 = new MySqlCommand(command_pk2, conn_init);
                        cmd_pk2.ExecuteNonQuery();

                        //primary key pemenang_detail
                        string command_pk3 = "ALTER TABLE `pemenang_detail` ADD PRIMARY KEY(`npwp`); ";
                        MySqlCommand cmd_pk3 = new MySqlCommand(command_pk3, conn_init);
                        cmd_pk3.ExecuteNonQuery();

                        //primary key pengumuman
                        string command_pk4 = "ALTER TABLE `pengumuman` ADD PRIMARY KEY(`id_lelang`); ";
                        MySqlCommand cmd_pk4 = new MySqlCommand(command_pk4, conn_init);
                        cmd_pk4.ExecuteNonQuery();

                        //primary key peserta
                        string command_pk5 = "ALTER TABLE `peserta` ADD PRIMARY KEY(`id_lelang`,`npwp`); ";
                        MySqlCommand cmd_pk5 = new MySqlCommand(command_pk5, conn_init);
                        cmd_pk5.ExecuteNonQuery();

                        //primary key peserta
                        string command_pk6 = "ALTER TABLE `tahap` ADD PRIMARY KEY(`id_lelang`,`nama_tahap`); ";
                        MySqlCommand cmd_pk6 = new MySqlCommand(command_pk6, conn_init);
                        cmd_pk6.ExecuteNonQuery();

                        Program.server = srvBox.Text;
                        Program.port = portBox.Text;
                        Program.user = userBox.Text;
                        Program.pass = passBox.Text;
                        Program.db = dbBox.Text;

                        conn_init.Close();
                        this.Hide();
                        new Form1().ShowDialog();
                        this.Close();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message + " test");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " test 2");
            }
        }

        //Reset value
        private void button1_Click(object sender, EventArgs e)
        {
            srvBox.Text = "localhost";
            portBox.Text = "3306";
            userBox.Text = "root";
            passBox.Text = "";
        }

        //login to existing db
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (srvBox.Text == "" || portBox.Text == "" || userBox.Text == "" || dbBox.Text == "")
            {
                MessageBox.Show("Please fill in the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                        MessageBox.Show(ex.Message + "test");
                    }
                }
            }
        }
    }
}
