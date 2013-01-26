using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Biruni.Reports;
using Biruni.Shared;
using Biruni.Shared.Logging;
using Biruni.Inventory.Entry;
using C1.Win.C1TrueDBGrid;

namespace Biruni.Inventory.List
{
    public partial class frmInventoryStatus : Biruni.Shared.Templates.frmList
    {
        public frmInventoryStatus()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                dsCore1.EnforceConstraints = false;
                itemInventoriesTableAdapter1.Connection = AppHelper.GetDbConnection();
                itemInventoriesTableAdapter1.ClearBeforeFill = true;
                itemInventoriesTableAdapter1.FillDenormalized(dsCore1.ItemInventories);
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("ERROR Loading Data!\n" + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            int pos = _grid.Bookmark;
            itemInventoriesTableAdapter1.FillDenormalized(dsCore1.ItemInventories);
            _grid.Bookmark = pos;
            Cursor = Cursors.Default;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            Form fx = new frmReportViewer1(ReportHelper1.LoadInventoryStatus());
            fx.WindowState = FormWindowState.Maximized;
            fx.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void _grid_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            if (e.Column.Name == "Progress")
            { 
                // Create a gradient brush
                Point pt1, pt2;
                pt1 = new Point(e.CellRect.X, e.CellRect.Y);
                pt2 = new Point(e.CellRect.Right, e.CellRect.Y);
                SolidBrush solidBrush = new SolidBrush(e.Row % 2 == 0 ? _grid.EvenRowStyle.BackColor : _grid.OddRowStyle.BackColor);
                LinearGradientBrush linGrBrush = new LinearGradientBrush(pt1, pt2, Color.Cyan, Color.DarkBlue);
                RectangleF rt = new RectangleF(e.CellRect.X, e.CellRect.Y, Convert.ToInt32(e.CellRect.Width * .7), e.CellRect.Height);
                // Fill solid brackground
                e.Graphics.FillRectangle(solidBrush, e.CellRect);
                // Fill the cell rectangle with the gradient. 
                e.Graphics.FillRectangle(linGrBrush, e.Row % 2 == 0 ? rt : e.CellRect);
                Brush whiteBR = new SolidBrush(Color.White);
                C1DisplayColumn dispCol = this._grid.Splits[0].DisplayColumns[e.Col];
                // Center the text horizontally. 
                StringFormat sfmt = new StringFormat();
                sfmt.Alignment = StringAlignment.Far;
                // Draw the text. 
                e.Graphics.DrawString(dispCol.DataColumn.CellText(e.Row), dispCol.Style.Font, whiteBR, rt, sfmt);
                whiteBR.Dispose();
                // Let the grid know the event was handled. 
                e.Handled = true;
            }
        }
    }
}

