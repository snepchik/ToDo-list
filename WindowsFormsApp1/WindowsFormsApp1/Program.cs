using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    internal static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        [STAThread]
        static void Main()
        {
            AllocConsole();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
