using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biruni.Shared;
using Biruni.FE.Properties;
using Biruni.Security;

namespace Biruni.FE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // set database access variables
            Settings set = Settings.Default;
            AppHelper.dbServer = set.dbServer;
            AppHelper.dbName = set.dbName;
            AppHelper.dbUser = set.dbUser;
            AppHelper.dbPassword = SecurityHelper.DecryptText(set.dbPassword, set.dbUser);
            // visualstyle
            AppHelper.visualStyle = set.visualStyle;

            // display login form
            frmLoginEx fx = new frmLoginEx();
            fx.ShowDialog();

            // modify connection setting if necessary
            if (fx.dbConnectionModified)
            {
                set.dbServer = AppHelper.dbServer;
                set.dbName = AppHelper.dbName;
                set.dbUser = AppHelper.dbUser;
                set.dbPassword = SecurityHelper.EncryptText(AppHelper.dbPassword, AppHelper.dbUser);
                set.Save();
                set.Reload();
            }

            // run application
            if (fx.loginSucceeded)
                Application.Run(new frmMain());
        }
    }
}