using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Shared;
using Biruni.Shared.Data;
using Biruni.Shared.Logging;

namespace Biruni.Master.Entry
{
    public partial class frmWarehouseEntry : Biruni.Shared.Templates.frmEntry1
    {
        public frmWarehouseEntry()
        {
            frmWarehouseEntry_Helper(-1);
        }

        public frmWarehouseEntry(int id)
        {
            frmWarehouseEntry_Helper(id);
        }

        private void frmWarehouseEntry_Helper(int id)
        {
            // required by form designer 
            InitializeComponent();
            // access control id
            ModuleID = "ACC-01013";
            // retrieve data
            daWarehouses1.Connection = AppHelper.GetDbConnection();
            daWarehouses1.ClearBeforeFill = true;
            try
            {
                if (id < 0)
                {
                    this.BindingContext[this.dsCore1,"Warehouses"].AddNew();
                    DataRowView dr = (DataRowView)this.BindingContext[this.dsCore1,"Warehouses"].Current;
                    dr["code"] = DbHelper.GenerateNewWarehouseID();
                    dr["Active"] = 1;
                    txMode = DataEntryModes.Add;
                }
                else
                {
                    daWarehouses1.FillByID(this.dsCore1.Warehouses, id);
                    txMode = DataEntryModes.Edit;
                }
            }
            catch (Exception ex)
            {
                // textfile logging
                Logger.ErrorRoutine(ex);
                // screen logging
                RibbonMessageBox.Show("ERROR Loading Data!\n" + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            c1TextBox1.Focus();
            base.OnShown(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            try
            {
                this.BindingContext[this.dsCore1,"Warehouses"].EndCurrentEdit();
                daWarehouses1.Update(this.dsCore1.Warehouses);
                RibbonMessageBox.Show("Data Changes SUCCESSFULLY Persisted to Database",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dsCore1.AcceptChanges();
                // success, close form
                btnClose.PerformClick();
            }
            catch (SqlException ex)
            {
                // textfile logging
                Logger.ErrorRoutine(ex);
                // screen logging
                if (ex.Number != 2601)
                    RibbonMessageBox.Show("ERROR Saving Data to Database: \n" + ex.Message,
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    RibbonMessageBox.Show("ERROR Saving Data to Database: \n" +
                        "Data with code [" + c1TextBox1.Text + "] already exists in database\n" +
                        "Please change it and try saving it again.",
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                // textfile logging
                Logger.ErrorRoutine(ex);
                // screen logging
                RibbonMessageBox.Show("ERROR Saving Data to Database: " + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Cursor = Cursors.Default;
        }

    }
}

