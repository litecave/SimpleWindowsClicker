using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWindowsClicker
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public IniFile settingsFile = new IniFile("Settings.ini");
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
