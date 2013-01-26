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
    public partial class frmCompanyEntry : Biruni.Shared.Templates.frmEntry1
    {
        CompanyTypes type;

        public frmCompanyEntry(CompanyTypes type)
        {
            frmCompanyEntry_Helper(type, -1);
        }

        public frmCompanyEntry(CompanyTypes type, int id)
        {
            frmCompanyEntry_Helper(type, id);
        }

        public void frmCompanyEntry_Helper(CompanyTypes type, int id)
        {
            InitializeComponent();
            InitializeForm(type);
            // access control id
            ModuleID = "ACC-01013";
            // retrieve data
            daCompanies1.Connection = AppHelper.GetDbConnection();
            daCompanies1.ClearBeforeFill = true;
            try
            {
                if (id < 0)
                {
                    this.BindingContext[this.dsCore1, "Companies"].AddNew();
                    DataRowView dr = (DataRowView)this.BindingContext[this.dsCore1, "Companies"].Current;
                    txMode = DataEntryModes.Add;
                    // default field value
                    dr["Active"] = 1;
                    if (type == CompanyTypes.Customer)
                    {
                        dr["Type"] = "C";
                        dr["Code"] = DbHelper.GenerateNewCompanyID("CI");
                    }
                    else
                    {
                        dr["Type"] = "S";
                        dr["Code"] = DbHelper.GenerateNewCompanyID("VI");
                    }
                }
                else
                {
                    daCompanies1.FillByID(this.dsCore1.Companies, id);
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

        private void InitializeForm(CompanyTypes type)
        {
            this.type = type;
            if (type == CompanyTypes.Customer)
            {
                this.Text = "Customer Entry";
                this.label1.Text = "Customer Code";
                this.label2.Text = "Customer Name";
            }
            else
            {
                this.Text = "Vendor Entry";
                this.label1.Text = "Vendor Code";
                this.label2.Text = "Vendor Name";
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
                this.BindingContext[this.dsCore1, "Companies"].EndCurrentEdit();
                daCompanies1.Update(this.dsCore1.Companies);
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

