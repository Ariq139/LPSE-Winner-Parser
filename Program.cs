using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPSE_UGM_Winner_Parser
{
    static class Program
    {
        public static string server, port, user, pass, db;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("DON'T CLOSE THIS CONSOLE WINDOW.\nDOING SO WILL CLOSE THE APPLICATION.");
            Console.WriteLine("JANGAN TUTUP JENDELA INI.\nJIKA TETAP DILAKUKAN MAKA APLIKASI AKAN IKUT TERTUTUP.");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new db_login());
        }
    }
}
