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
            var CustomerService = GlobalConfig.CustomerService;
            var AccountsService = GlobalConfig.AccountService;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OpenAcctLogin_Window(CustomerService,AccountsService));
        }
    }
}
