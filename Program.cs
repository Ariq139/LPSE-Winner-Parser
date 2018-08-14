using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPSE_UGM_Winner_Parser
{
    static class Program
    {
        public static string server, port, user, pass, db;
        public static string resource_path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory) + @"\Resources\\";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("DON'T CLOSE THIS CONSOLE WINDOW. DOING SO WILL CLOSE THE APPLICATION.\n");
            Console.WriteLine("JANGAN TUTUP JENDELA KONSOL INI.JIKA DILAKUKAN MAKA APLIKASI AKAN IKUT TERTUTUP.\n");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new db_login());
        }
    }
}
