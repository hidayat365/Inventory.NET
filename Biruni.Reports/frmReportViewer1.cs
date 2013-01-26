using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Biruni.Reports
{
    public partial class frmReportViewer1 : Biruni.Shared.Templates.frmEntry1
    {
        public frmReportViewer1()
        {
            frmReportViewer1_Helper(null);
        }

        public frmReportViewer1(ReportDocument rpt)
        {
            frmReportViewer1_Helper(rpt);
        }

        private void frmReportViewer1_Helper(ReportDocument rpt)
        {
            InitializeComponent();
            if (rpt != null) _viewer.ReportSource = rpt;
            _viewer.Zoom(1);
        }


    }
}

