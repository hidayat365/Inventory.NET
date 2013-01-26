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
using Biruni.Shared.Logging;
using Biruni.Shared.Data;

namespace Biruni.Security.Entry
{
    public partial class frmRoleEntry : Biruni.Shared.Templates.frmEntry1
    {
        int mRoleID = -1;

        public frmRoleEntry()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeForm();
            // Prepare Database
            try
            {
                // mode
                txMode = DataEntryModes.Add;
                // add new row to dataset
                BindingContext[dsSecurity1, "Roles"].AddNew();
                DataRowView dr = (DataRowView)this.BindingContext[this.dsSecurity1, "Roles"].Current;
                dr["Active"] = 1;
                // database connection
                daRoles.Connection = AppHelper.GetDbConnection();
                daApplications.Connection = AppHelper.GetDbConnection();
                daApplicationRoles.Connection = AppHelper.GetDbConnection();
                // fill flexgrid data
                daApplications.FillActive(dsSecurity1.Applications);
                this.BindingContext[dsSecurity1, "Roles"].EndCurrentEdit();
                foreach (dsSecurity.ApplicationsRow src in dsSecurity1.Applications)
                {
                    dsSecurity.ApplicationRolesRow row = dsSecurity1.ApplicationRoles.NewApplicationRolesRow();
                    row.RoleID = (int)dr["ID"];
                    row.ApplicationID = src.ID;
                    row.ApplicationCode = src.Code;
                    row.ApplicationName = src.Name;
                    row.AllowRead = true;
                    row.AllowCreate = true;
                    row.AllowUpdate = true;
                    row.AllowDelete = true;
                    dsSecurity1.ApplicationRoles.AddApplicationRolesRow(row);
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("Creating new Role\n" + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public frmRoleEntry(int key)
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeForm();

            try
            {
                // mode
                txMode = DataEntryModes.Edit;
                // database connection
                daRoles.Connection = AppHelper.GetDbConnection();
                daApplications.Connection = AppHelper.GetDbConnection();
                daApplicationRoles.Connection = AppHelper.GetDbConnection();
                // display roles
                mRoleID = key;
                daRoles.FillByID(dsSecurity1.Roles, key);
                daApplications.FillActive(dsSecurity1.Applications);
                daApplicationRoles.FillByRoleID(dsSecurity1.ApplicationRoles, mRoleID);
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("Edit existing Role\n" + ex.Message,
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

        private void InitializeEventHandlers()
        {
            c1FlexGrid1.AfterEdit += new RowColEventHandler(c1FlexGrid1_AfterEdit);
        }

        protected override void OnShown(EventArgs e)
        {
            c1TextBox1.Focus();
            base.OnShown(e);
        }

        void c1FlexGrid1_AfterEdit(object sender, RowColEventArgs e)
        {
            if (e.Col == c1FlexGrid1.Cols["AllowRead"].SafeIndex)
            {
                c1FlexGrid1.SetData(e.Row, "AllowCreate", c1FlexGrid1.GetData(e.Row, e.Col));
                c1FlexGrid1.SetData(e.Row, "AllowUpdate", c1FlexGrid1.GetData(e.Row, e.Col));
                c1FlexGrid1.SetData(e.Row, "AllowDelete", c1FlexGrid1.GetData(e.Row, e.Col));
            }
        }

        private void StyleFlexGrid(int fg)
        {
            c1FlexGrid1.Cols[1].AllowEditing = false;
            c1FlexGrid1.Cols[2].AllowEditing = false;
            // style for grid administrator role
            if (fg == 1) // admin role
            {
                c1FlexGrid1.Cols[2].AllowEditing = false;
                c1FlexGrid1.Cols[3].AllowEditing = false;
                c1FlexGrid1.Cols[4].AllowEditing = false;
                c1FlexGrid1.Cols[5].AllowEditing = false;
                c1FlexGrid1.Cols[6].AllowEditing = false;
            }

            // caption on header collumn
            c1FlexGrid1.Cols[1].Caption = "App. COde";
            c1FlexGrid1.Cols[2].Caption = "Application Name";
            c1FlexGrid1.Cols[3].Caption = "Read";
            c1FlexGrid1.Cols[4].Caption = "Create";
            c1FlexGrid1.Cols[5].Caption = "Update";
            c1FlexGrid1.Cols[6].Caption = "Delete";
            c1FlexGrid1.Cols[1].Width = 80;
            c1FlexGrid1.Cols[2].Width = 250;
            c1FlexGrid1.Cols[3].Width = 70;
            c1FlexGrid1.Cols[4].Width = 70;
            c1FlexGrid1.Cols[5].Width = 70;
            c1FlexGrid1.Cols[6].Width = 60;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;

            // save data role update or insert
            SaveFlexGrid();

            // clean up
            this.Cursor = Cursors.Default;
            this.Close();
        }

        private void SaveFlexGrid()
        {
            try
            {
                // delete existing role-application data
                if (mRoleID != -1) // edit existing role-application data
                {
                    this.BindingContext[dsSecurity1, "Roles"].EndCurrentEdit();
                    this.BindingContext[dsSecurity1, "ApplicationRoles"].EndCurrentEdit();
                    // update database
                    daRoles.Update(dsSecurity1.Roles);
                    daApplicationRoles.Update(dsSecurity1.ApplicationRoles);
                    // inform user
                    RibbonMessageBox.Show("Changes SUCCESSFULLY saved to database. New Role setting will affect new session. You need to restart this application for changes to take affect", 
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // save NEW Role data
                {
                    if (c1TextBox1.Text.Trim() == "")
                    {
                        RibbonMessageBox.Show("Please provide Role Name", 
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.BindingContext[dsSecurity1, "Roles"].EndCurrentEdit();
                        this.BindingContext[dsSecurity1, "ApplicationRoles"].EndCurrentEdit();
                        // set code
                        DataRowView dr = (DataRowView)this.BindingContext[this.dsSecurity1, "Roles"].Current;
                        dr["Code"] = dr["Name"];
                        // copy master record dari main dataset
                        // harus dilakukan krena main dataset sebelumnya sudah 
                        // AcceptChanges padahal belum diupdate ke database 
                        dsSecurity dsChanges = new dsSecurity();
                        dsChanges.EnforceConstraints = false;
                        dsChanges.Roles.Rows.Add(((DataRowView)this.BindingContext[dsSecurity1, "Roles"].Current).Row.ItemArray);
                        // copy juga detail record dari main dataset
                        for (int i = 0; i < dsSecurity1.ApplicationRoles.Rows.Count; i++)
                            dsChanges.ApplicationRoles.Rows.Add(dsSecurity1.ApplicationRoles.Rows[i].ItemArray);
                        // update master table
                        daRoles.Update(dsChanges.Roles);
                        // get new id
                        dsSecurity ds = new dsSecurity();
                        daRoles.FillByCode(ds.Roles, c1TextBox1.Text);
                        foreach (dsSecurity.ApplicationRolesRow row in dsChanges.ApplicationRoles.Rows)
                            row.RoleID = ds.Roles[0].ID;
                        // update detail table
                        daApplicationRoles.Update(dsChanges.ApplicationRoles);
                        // inform user
                        RibbonMessageBox.Show("Data SUCCESSFULLY saved to database", 
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("ERROR saving Role to database, probably duplicate Role Name: " + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // clean up
            this.Cursor = Cursors.Default;
            this.Close();
        }

        private void chkRead_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
                c1FlexGrid1.Rows[i]["AllowRead"] = chkRead.Checked;
        }

        private void chkCreate_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
                c1FlexGrid1.Rows[i]["AllowCreate"] = chkCreate.Checked;
        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
                c1FlexGrid1.Rows[i]["AllowUpdate"] = chkUpdate.Checked;
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
                c1FlexGrid1.Rows[i]["AllowDelete"] = chkDelete.Checked;
        }

    }
}

