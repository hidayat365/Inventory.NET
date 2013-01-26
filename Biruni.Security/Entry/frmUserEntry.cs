using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using C1.Win.C1FlexGrid;
using Biruni.Shared;
using Biruni.Shared.Data;
namespace Biruni.Security.Entry
{
    public partial class frmUserEntry : Biruni.Shared.Templates.frmEntry1
    {
        /// <summary>
        /// contructor for add new account class
        /// </summary>
        public frmUserEntry()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            InitializeForm();
            // mode
            txMode = DataEntryModes.Add;
            // Prepare Database
            try
            {
                daUsers.Connection = AppHelper.GetDbConnection();
                daRoles.Connection = AppHelper.GetDbConnection();
                daRoles.FillActive(dsSecurity1.Roles);
                this.BindingContext[dsSecurity1, "Users"].AddNew();
                DataRowView dr = (DataRowView)this.BindingContext[this.dsSecurity1, "Users"].Current;
                dr["Active"] = 1;
            }
            catch (Exception ex)
            {
                RibbonMessageBox.Show("ERROR Initializing Form\n" + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// contructor for editing existing account class
        /// </summary>
        public frmUserEntry(int key)
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            InitializeForm();
            // mode
            txMode = DataEntryModes.Edit;
            // Prepare Database
            try
            {
                daUsers.Connection = AppHelper.GetDbConnection();
                daRoles.Connection = AppHelper.GetDbConnection();
                daRoles.FillActive(dsSecurity1.Roles);
                daUsers.FillByID(dsSecurity1.Users, key);
                // password
                DataRowView dr = (DataRowView)this.BindingContext[this.dsSecurity1, "Users"].Current;
                c1TextBox2.Text = SecurityHelper.DecryptText((string)dr["Password"], (string)dr["UserName"]);
                c1TextBox3.Text = SecurityHelper.DecryptText((string)dr["Password"], (string)dr["UserName"]);
            }
            catch (Exception ex)
            {
                RibbonMessageBox.Show("ERROR Initializing Form\n" + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InitializeForm()
        {
            // ModuleID
            ModuleID = "ACC-02003";
            // form visual style
            AppHelper.ApplyFormStyle(this);
            AppHelper.ApplyVisualStyle(this.Controls);
        }

        protected override void OnShown(EventArgs e)
        {
            c1TextBox1.Focus();
            base.OnShown(e);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;

            // verify password
            if (c1TextBox2.Text != c1TextBox3.Text)
            {
                RibbonMessageBox.Show("Confirm Password not equal, please retype your password.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                c1TextBox2.Focus();
                return;
            }

            // store user data to database
            try
            {
                this.BindingContext[this.dsSecurity1, "Users"].EndCurrentEdit();
                DataRowView dr = (DataRowView)this.BindingContext[this.dsSecurity1, "Users"].Current;
                dr["Password"] = SecurityHelper.EncryptText(c1TextBox2.Text, c1TextBox1.Text);
                dr["Active"] = 1;
                // update user
                daUsers.Update(this.dsSecurity1);
                // inform user
                RibbonMessageBox.Show("Data SUCCESSFULLY saved to database",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                RibbonMessageBox.Show("ERROR while saving data to database: " + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.dsSecurity1.AcceptChanges();
            this.Cursor = Cursors.Default;
            this.Close();
        }
    }
}

