using System;
using FormApplication = System.Windows.Forms.Application;

namespace ParkNow.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormApplication.EnableVisualStyles();
            FormApplication.SetCompatibleTextRenderingDefault(false);
            FormApplication.Run(new MainForm());
        }
    }
}
