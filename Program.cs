using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220117
{
    internal static class Program
    {
        public static string ConnectionString => 
            "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=utiroda_2;" +
            "Integrated Security=True;";
        public static DateTime MaiDatum =>
            new DateTime(2015, 10, 11);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
