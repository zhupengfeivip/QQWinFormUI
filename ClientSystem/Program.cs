using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClientSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main f = new Main();
            CRD.WinUI.Shared.MainForm = f;
            Application.Run(f);
        }
    }
}
