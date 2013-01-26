using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Shared;

namespace Biruni.Security.Entry
{
    public partial class frmDbSetting : Biruni.Shared.Templates.frmEntry1
    {
        public frmDbSetting()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            c1TextBox1.Text = AppHelper.dbServer;
            c1TextBox2.Text = AppHelper.dbName;
            c1TextBox3.Text = AppHelper.dbUser;
            c1TextBox4.Text = AppHelper.dbPassword;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppHelper.dbServer = c1TextBox1.Text;
            AppHelper.dbName = c1TextBox2.Text;
            AppHelper.dbUser = c1TextBox3.Text;
            AppHelper.dbPassword = c1TextBox4.Text;
        }
    }
}

