using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Biruni.Shared;

namespace Biruni.Shared.Templates
{
    public partial class frmEntry1 : C1RibbonForm
    {
        protected string ModuleID = "ACC-00000";
        protected DataEntryModes txMode = DataEntryModes.Add;

        public frmEntry1()
        {
            InitializeComponent();
            AppHelper.ApplyFormStyle(this);
            AppHelper.ApplyVisualStyle(this.Controls);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}