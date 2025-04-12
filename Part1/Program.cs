using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
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

            var loggedInAccount = AccountRepository.GetLoggedInAccount();

            if (loggedInAccount != null)
            {
                Application.Run(new Input_Form());
            }
            else
            {
                Application.Run(new SignIn_Form());
            }
        }
    }
}
