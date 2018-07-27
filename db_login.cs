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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Program.server = srvBox.Text;
            Program.port = portBox.Text;
            Program.user = userBox.Text;
            Program.pass = passBox.Text;
            Program.db = dbBox.Text;

            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
    }
}
