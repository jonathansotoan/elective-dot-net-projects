using System;
using FormApplication = System.Windows.Forms.Application;

namespace ParkNow.UI
{
    /// <summary>
    /// Starting point of the app.
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
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
