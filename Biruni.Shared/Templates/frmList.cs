using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;

namespace Biruni.Shared.Templates
{
    public partial class frmList : C1RibbonForm
    {
        public frmList()
        {
            InitializeComponent();
            InitializeUserInterface();
        }

        private void InitializeUserInterface()
        {
            dtpBegin.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            dtpEnd.Value = DateTime.Today.AddMonths(1).AddDays(-DateTime.Today.Day);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            this.btnRefresh.PerformClick();
        }
    }
}