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
    public partial class frmCompanyBalanceEntry : Biruni.Shared.Templates.frmEntry1
    {
        CompanyTypes type;
        string ModulePrefix;

        public frmCompanyBalanceEntry(CompanyTypes type)
        {
            frmCompanyBalanceEntry_Helper(type, -1);
        }
        public frmCompanyBalanceEntry(CompanyTypes type, int id)
        {
            frmCompanyBalanceEntry_Helper(type, id);
        }
        public void frmCompanyBalanceEntry_Helper(CompanyTypes type, int id)
        {
            InitializeComponent();
            InitializeForm(type);
            InitializeData(type, id);
        }

        private void InitializeForm(CompanyTypes type)
        {
            this.type = type;
            AppHelper.ApplyVisualStyle(this.Controls);
            if (type == CompanyTypes.Customer)
            {
                this.Text = "Customer Opening Balance Entry";
                this.label4.Text = "Customer Name";
                ModulePrefix = TransactionTypes.TX_BEGINBALANCE_CUSTOMER;
            }
            else
            {
                this.Text = "Vendor Opening Balance Entry";
                this.label4.Text = "Vendor Name";
                ModulePrefix = TransactionTypes.TX_BEGINBALANCE_VENDOR;
            }
        }

        private void InitializeData(CompanyTypes type, int id)
        {
            // main data
            try
            {
                dsCore1.EnforceConstraints = false;
                // set database connection
                daCurrencies1.Connection = AppHelper.GetDbConnection();
                daCompanies1.Connection = AppHelper.GetDbConnection();
                daOrders1.Connection = AppHelper.GetDbConnection();
                // lookup table
                daCurrencies1.FillActive(dsCore1.Currencies);
                if (type == CompanyTypes.Customer)
                    daCompanies1.FillCustomerActive(dsCore1.Companies);
                else
                    daCompanies1.FillVendorActive(dsCore1.Companies);
                // get data
                if (id < 0)
                {
                    // mode
                    txMode = DataEntryModes.Add;
                    // add new row to master table
                    BindingContext[dsCore1, "Orders"].AddNew();
                    // default values for master table
                    DataRowView dr = (DataRowView)this.BindingContext[dsCore1, "Orders"].Current;
                    dr["OrderNo"] = DbHelper.GenerateNewOrderID(ModulePrefix, DateTime.Today.Year);
                    dr["OrderValue"] = 0;
                    dr["OrderType"] = ModulePrefix;
                    dr["OrderDate"] = DateTime.Today;
                    dr["RequiredDate"] = DateTime.Today.AddDays(30);
                    dr["PaymentValue"] = 0;
                    dr["PaymentType"] = 1;  // credit payment
                }
                else
                {
                    // mode
                    txMode = DataEntryModes.Edit;
                    // get data
                    daOrders1.ClearBeforeFill = true;
                    daOrders1.FillByID(dsCore1.Orders, id);
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("ERROR Loading Data: " + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private dsCore dsChanges;
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate all required field(s)
            if (!ValidateUserInput()) return;

            // if you get here, it means that all user input has been validated
            Cursor = Cursors.AppStarting;

            try
            {
                // End editing
                BindingContext[dsCore1, "Orders"].EndCurrentEdit();
                BindingContext[dsCore1, "OrderDetails"].EndCurrentEdit();

                // There are changes that need to be made, so attempt to update the datasource by
                // calling the update method and passing the dataset and any parameters.
                if (txMode == DataEntryModes.Add)
                {
                    // copy master record dari main dataset
                    // harus dilakukan krena main dataset sebelumnya sudah 
                    // AcceptChanges padahal belum diupdate ke database 
                    dsChanges = new dsCore();
                    dsChanges.EnforceConstraints = false;
                    dsChanges.Orders.Rows.Add(((DataRowView)this.BindingContext[dsCore1, "Orders"].Current).Row.ItemArray);
                    // persist changes to database
                    daOrders1.Update(dsChanges.Orders);
                    // inform user, successful
                    RibbonMessageBox.Show("Data SUCCESFULLY saved to database",
                        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    // persist changes to database
                    daOrders1.Update(dsCore1.Orders);
                    // inform user for successful update
                    RibbonMessageBox.Show("Changes SUCCESFULLY saved to database",
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // success, close form
                btnClose.PerformClick();
            }
            catch (SqlException ex)
            {
                // textfile logging
                Logger.ErrorRoutine(ex);

                // screen logging
                if (ex.Number != 2601)
                    RibbonMessageBox.Show("ERROR Saving Data: \n" + ex.Message,
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    RibbonMessageBox.Show("ERROR Saving Data:\n" +
                        "Document number [" + c1TextBox1.Text + "]already existed in database\n" +
                        "Please change this document number and try saving again.",
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                // textfile logging
                Logger.ErrorRoutine(ex);

                // screen logging
                RibbonMessageBox.Show("ERROR Saving Data: \n" + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Cursor = Cursors.Default;
        }

        private bool ValidateUserInput()
        {
            // otherwise, successful
            return true;
        }

    }
}
