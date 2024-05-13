using Hi_Tech_Order_Managment.GUI.Login;
using System;
using System.Windows.Forms;

namespace Hi_Tech_Order_Managment
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
            Application.Run(new MainLogin());
        }
    }
}
