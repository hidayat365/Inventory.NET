using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Shared;
using Biruni.Shared.Logging;
using Biruni.Security.Entry;

namespace Biruni.Security.List
{
    public partial class frmRoleList : Biruni.Shared.Templates.frmList
    {
        public frmRoleList()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                dsSecurity1.EnforceConstraints = false;
                daRoles1.Connection = AppHelper.GetDbConnection();
                daRoles1.ClearBeforeFill = true;
                daRoles1.Fill(dsSecurity1.Roles);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            Form fx = new frmRoleEntry();
            fx.ShowDialog();
            btnRefresh.PerformClick();
            Cursor = Cursors.Default;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            try
            {
                Form fx = new frmRoleEntry((int)_grid.Columns["id"].Value);
                fx.ShowDialog();
                btnRefresh.PerformClick();
            }
            catch
            {
                RibbonMessageBox.Show("No data selected for editing\n",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            DialogResult dr;
            try
            {
                string deleted = "[" + this._grid.Columns["code"].Text + "] " + this._grid.Columns["name"].Text;
                try
                {
                    dr = RibbonMessageBox.Show("Do you really want to delete data " + deleted,
                        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        this.BindingContext[this.dsSecurity1, "Roles"].RemoveAt(this.BindingContext[this.dsSecurity1, "Roles"].Position);
                        this.daRoles1.Update(this.dsSecurity1.Roles);
                        this.dsSecurity1.AcceptChanges();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        RibbonMessageBox.Show("Data " + deleted + " can't be deleted because it's already used as reference",
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        RibbonMessageBox.Show("Error deleting data\nDetails: " + ex.Message,
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dsSecurity1.RejectChanges();
                    btnRefresh.PerformClick();
                }
                catch (System.Exception ex)
                {
                    RibbonMessageBox.Show("Error deleting data\n" + ex.Message,
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dsSecurity1.RejectChanges();
                    btnRefresh.PerformClick();
                }
            }
            catch
            {
                RibbonMessageBox.Show("No data selected for deletion\n",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor = Cursors.Default;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            int pos = _grid.Bookmark;
            daRoles1.Fill(dsSecurity1.Roles);
            _grid.Bookmark = pos;
            Cursor = Cursors.Default;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;

            // hide unecessary column
            /*** none ***/

            // page setting
            this._grid.PrintInfo.PageHeader = this.Text;
            this._grid.PrintInfo.PageFooter = Reports.ReportHelper1.GenerateFooter();
            this._grid.PrintInfo.PageSettings.Landscape = false;
            this._grid.PrintInfo.PageSettings.Margins.Top = 30;
            this._grid.PrintInfo.PageSettings.Margins.Left = 30;
            this._grid.PrintInfo.PageSettings.Margins.Bottom = 30;
            this._grid.PrintInfo.PageSettings.Margins.Right = 30;
            this._grid.PreviewInfo.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            // Column headers will be on every page.
            this._grid.PrintInfo.RepeatColumnHeaders = true;

            // Display page numbers (centered).
            this._grid.PrintInfo.PageFooter = @"Page: \p";

            // Invoke print preview.
            this._grid.PrintInfo.UseGridColors = false;
            this._grid.PrintInfo.PrintPreview();

            // unhide unecessary column
            /*** none ***/

            Cursor = Cursors.Default;
        }
    }
}

