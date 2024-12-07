using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker_v2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SignUp());
            //Application.Run(new LoadingScreen());

            // Show the loading screen
            using (LoadingScreen loadingScreen = new LoadingScreen())
            {
                loadingScreen.ShowDialog();
            }

            // Show the login form
            Application.Run(new MainForm());
        }
    }
}

