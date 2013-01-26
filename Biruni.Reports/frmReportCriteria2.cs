using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Shared;

namespace Biruni.Reports
{
    public partial class frmReportCriteria2 : Biruni.Shared.Templates.frmEntry1
    {
        public frmReportCriteria2()
        {
            InitializeComponent();
            dsCore1.EnforceConstraints = false;
            daItems.Connection = AppHelper.GetDbConnection();
            daItems.Fill(dsCore1.Items);
        }

        public int SelectedID
        {
            get { return (int)c1Combo1.SelectedValue; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

