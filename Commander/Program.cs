using Commander.view;
using System;
using System.Windows.Forms;

namespace Commander
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Template t = new Template();
            t.Hide();
            Application.Run();            
        }
    }
}
