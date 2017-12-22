using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismMangement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// CON STRING "Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True"
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Register());
        }
    }
}
