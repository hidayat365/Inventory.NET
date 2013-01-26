using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Shared;
using Biruni.Shared.Logging;

namespace Biruni.Security
{
    public partial class frmLoginEx : C1.Win.C1Ribbon.C1RibbonForm
    {
        public bool loginSucceeded = false;
        public bool dbConnectionModified = false;
        const int _showDbSetting = 344;
        const int _hideDbSetting = 230;

        public frmLoginEx()
        {
            InitializeComponent();
            this.Text = Application.ProductName;
            this.label8.Text = "Version: " + Application.ProductVersion;
            this.Height = _hideDbSetting;
            this.c1TextBox3.Text = AppHelper.dbServer;
            this.c1TextBox4.Text = AppHelper.dbName;
            this.c1TextBox6.Text = AppHelper.dbUser;
            this.c1TextBox7.Text = AppHelper.dbPassword;
            this.c1TextBox4.TabStop = (this.Height == _showDbSetting);
            this.c1TextBox6.TabStop = (this.Height == _showDbSetting);
            this.c1TextBox7.TabStop = (this.Height == _showDbSetting);
            AppHelper.ApplyFormStyle(this);
            AppHelper.ApplyVisualStyle(this.Controls);
        }

        protected override void OnShown(EventArgs e)
        {
            c1TextBox1.Focus();
            base.OnShown(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // if database connection modified
            if (c1TextBox3.Text != AppHelper.dbServer || c1TextBox4.Text != AppHelper.dbName
                || c1TextBox6.Text != AppHelper.dbUser || c1TextBox7.Text != AppHelper.dbPassword)
            {
                AppHelper.dbServer = c1TextBox3.Text;
                AppHelper.dbName = c1TextBox4.Text;
                AppHelper.dbUser = c1TextBox6.Text;
                AppHelper.dbPassword = c1TextBox7.Text;
                dbConnectionModified = true;
            }
            // check for empty username and password
            if (c1TextBox1.Text.Trim() == "" || c1TextBox2.Text.Trim() == "")
                RibbonMessageBox.Show("Username and or Password are required",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // try logging in
            else
            {
                loginSucceeded = ValidateUser();
                if (!loginSucceeded)
                    RibbonMessageBox.Show("Username and or Password invalid",
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    Close();
                }
            }
        }

        private bool ValidateUser()
        {
            try
            {
                dsSecurity1.EnforceConstraints = false;
                daUsers.Connection = AppHelper.GetDbConnection();
                daUsers.FillByUserName(dsSecurity1.Users, c1TextBox1.Text);
                if (dsSecurity1.Users.Rows.Count <= 0)
                {
                    Logger.DebugRoutine("Username not found: " + c1TextBox1.Text);
                    return false;
                }
                else if (!c1TextBox2.Text.Equals(SecurityHelper.DecryptText(dsSecurity1.Users[0].Password, c1TextBox1.Text)))
                {
                    Logger.DebugRoutine("Password does not match, entered password: " + c1TextBox2.Text);
                    return false;
                }
                else
                {
                    AppHelper.appUserID = dsSecurity1.Users[0].ID;
                    AppHelper.appUserName = dsSecurity1.Users[0].IsFullNameNull() ? "[USER]" : dsSecurity1.Users[0].FullName;
                    AppHelper.appRoleName = dsSecurity1.Users[0].IsRoleNameNull() ? "[ROLE]" : dsSecurity1.Users[0].RoleName;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                return false;
            }
        }

        private void btnDbSetting_Click(object sender, EventArgs e)
        {
            this.Height = this.Height == _showDbSetting ? _hideDbSetting : _showDbSetting;
            this.c1TextBox4.TabStop = (this.Height == _showDbSetting);
            this.c1TextBox6.TabStop = (this.Height == _showDbSetting);
            this.c1TextBox7.TabStop = (this.Height == _showDbSetting);
        }
    }
}