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
    public partial class frmItemEntry : Biruni.Shared.Templates.frmEntry1
    {
        public frmItemEntry()
        {
            frmItemEntry_Helper(-1);
        }

        public frmItemEntry(int id)
        {
            frmItemEntry_Helper(id);
        }

        private void frmItemEntry_Helper(int id)
        {
            // required by form designer 
            InitializeComponent();
            // access control id
            ModuleID = "ACC-01013";
            // retrieve support data
            daItemCategories1.Connection = AppHelper.GetDbConnection();
            daItemCategories1.ClearBeforeFill = true;
            daItemCategories1.FillActive(dsCore1.ItemCategories);
            daUnitMeasures1.Connection = AppHelper.GetDbConnection();
            daUnitMeasures1.ClearBeforeFill = true;
            daUnitMeasures1.FillActive(dsCore1.UnitMeasures);
            daCompanies1.Connection = AppHelper.GetDbConnection();
            daCompanies1.ClearBeforeFill = true;
            daCompanies1.FillVendor(dsCore1.Companies);
            // retrieve main data
            daItems1.Connection = AppHelper.GetDbConnection();
            daItems1.ClearBeforeFill = true;
            try
            {
                if (id < 0)
                {
                    this.BindingContext[this.dsCore1, "Items"].AddNew();
                    DataRowView dr = (DataRowView)this.BindingContext[this.dsCore1, "Items"].Current;
                    dr["code"] = DbHelper.GenerateNewItemID();
                    dr["Active"] = 1;
                    dr["Inventoried"] = 1;
                    dr["BasePrice"] = 0;
                    dr["SellingPrice"] = 0;
                    dr["QuantityMin"] = 0;
                    dr["QuantityMax"] = 0;
                    dr["ExpiryInDays"] = 0;
                    txMode = DataEntryModes.Add;
                }
                else
                {
                    daItems1.FillByID(this.dsCore1.Items, id);
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
            // qunatity min max checking
            if (!QuantityMinMaxChecking())
            {
                RibbonMessageBox.Show("Base Price, Selling Price, Quantity Minimum and Maximum must be greater than or equal to 0 (zero). " +
                    "Additionally, Quantity Maximum must be greater than or equal to Quantity Minimum",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // persist changes
            try
            {
                this.BindingContext[this.dsCore1, "Items"].EndCurrentEdit();
                daItems1.Update(this.dsCore1.Items);
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

        private bool QuantityMinMaxChecking()
        {
            if (!c1NumericEdit1.ValueIsDbNull)
                if ((double)c1NumericEdit1.Value < 0) return false;
            if (!c1NumericEdit2.ValueIsDbNull)
                if ((double)c1NumericEdit2.Value < 0) return false;
            if (!c1NumericEdit3.ValueIsDbNull)
                if ((double)c1NumericEdit3.Value < 0) return false;
            if (!c1NumericEdit4.ValueIsDbNull)
                if ((double)c1NumericEdit4.Value < 0) return false;
            if (!c1NumericEdit3.ValueIsDbNull && !c1NumericEdit4.ValueIsDbNull)
                if ((double)c1NumericEdit4.Value < (double)c1NumericEdit3.Value) return false;
            return true;
        }

    }
}

