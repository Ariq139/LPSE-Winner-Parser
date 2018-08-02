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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void detailForm_Load(object sender, EventArgs e)
        {
            getData_Detail();
        }

        private void getData_Detail()
        {
            DataTable dt = new DataTable();
            string connect = "server=localhost;user=root;password=;database=pkl;";
            string command = "select * from (SELECT * FROM pkl.bantul b UNION ALL SELECT * FROM pkl.gunungkidul gk UNION ALL SELECT * FROM pkl.jogjakota jk UNION ALL SELECT * FROM pkl.jogjaprov jp UNION ALL SELECT * FROM pkl.kulonprogo kp UNION ALL SELECT * FROM pkl.sleman s UNION ALL SELECT * FROM pkl.ugm u) x where pemenang in (select pemenang from (select pemenang, count(*) from (SELECT * FROM pkl.bantul b UNION ALL SELECT * FROM pkl.gunungkidul gk UNION ALL SELECT * FROM pkl.jogjakota jk UNION ALL SELECT * FROM pkl.jogjaprov jp UNION ALL SELECT * FROM pkl.kulonprogo kp UNION ALL SELECT * FROM pkl.sleman s UNION ALL SELECT * FROM pkl.ugm u) x group by pemenang order by count(*) desc limit 10) x)";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                dt.Load(read);

                if (dt.Rows.Count > 0)
                {
                    dataDetail.DataSource = dt;
                }

                conn.Close();
            }
        }
    }
}
