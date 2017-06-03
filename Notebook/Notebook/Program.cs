using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Notebook.InfoAddForm;

namespace Notebook
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
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
