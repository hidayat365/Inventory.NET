using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biruni.Reports
{
    public partial class frmReportCriteria1 : Biruni.Shared.Templates.frmEntry1
    {
        public frmReportCriteria1()
        {
            InitializeComponent();
            c1DateEdit1.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            c1DateEdit2.Value = DateTime.Today.AddMonths(1).AddDays(-DateTime.Today.Day);
        }

        public DateTime PeriodStart
        {
            get { return (DateTime)c1DateEdit1.Value; }
        }

        public DateTime PeriodEnd
        {
            get { return (DateTime)c1DateEdit2.Value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

