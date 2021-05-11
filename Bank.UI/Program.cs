using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Lib.Core;


namespace Bank.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalConfig.AddInstance();
            var CustRepo = GlobalConfig.CustRepo;
            var ActRepo = GlobalConfig.ActRepo;
            var TRepo = GlobalConfig.TRepo;
            var Savings = GlobalConfig.Savings;
            var Current = GlobalConfig.Current;
            var Auth = GlobalConfig.AuthRepo;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OpenAcctLogin_Window(CustRepo,ActRepo,TRepo,Savings,Current,Auth));
        }
    }
}
