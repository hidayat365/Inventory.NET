using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Biruni.Reports;
using Biruni.Shared;
using Biruni.Shared.Data;
using Biruni.Shared.Data.dsCoreTableAdapters;
using Biruni.Shared.Logging;
using Biruni.Master.Search;

namespace Biruni.Purchasing.Entry
{
    public partial class frmPurchaseInvoiceEntry : Biruni.Shared.Templates.frmEntry2
    {
        public frmPurchaseInvoiceEntry()
        {
            frmPurchaseInvoiceEntry_Helper(-1);
        }
        public frmPurchaseInvoiceEntry(int id)
        {
            frmPurchaseInvoiceEntry_Helper(id);
        }

        public void frmPurchaseInvoiceEntry_Helper(int id)
        {
            InitializeComponent();
            InitializeForm();
            InitializeData(id);
        }

        protected override void OnShown(EventArgs e)
        {
            c1TextBox1.Focus();
            btnPrint.Visible = (txMode == DataEntryModes.Edit);
            base.OnShown(e);
        }

        private void InitializeData(int id)
        {
            // main data
            try
            {
                dsCore1.EnforceConstraints = false;
                dsCore2.EnforceConstraints = false;
                // set database connection
                daCurrencies1.Connection = AppHelper.GetDbConnection();
                daCompanies1.Connection = AppHelper.GetDbConnection();
                daItems1.Connection = AppHelper.GetDbConnection();
                daOrders1.Connection = AppHelper.GetDbConnection();
                daOrderDetails1.Connection = AppHelper.GetDbConnection();
                // lookup table
                daCompanies1.FillVendorActive(dsCore1.Companies);
                daCurrencies1.FillActive(dsCore1.Currencies);
                daOrders1.FillPurchaseOrdersAll(dsCore2.Orders);
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
                }
                else
                {
                    // mode
                    txMode = DataEntryModes.Edit;
                    // get data
                    daOrders1.ClearBeforeFill = true;
                    daOrders1.FillByID(dsCore1.Orders, id);
                    // get details
                    daOrderDetails1.ClearBeforeFill = true;
                    daOrderDetails1.FillByOrderID(dsCore1.OrderDetails, id);
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("ERROR Loading Data: " + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InitializeForm()
        {
            AppHelper.ApplyVisualStyle(this.Controls);
            // transaction type
            ModulePrefix = TransactionTypes.TX_PURCHASE_INVOICE;
            // grid event handlers
            _grid.Enter += new EventHandler(_grid_Enter);
            _grid.AfterEdit += new RowColEventHandler(_grid_AfterEdit);
            _grid.GetUnboundValue += new UnboundValueEventHandler(_grid_GetUnboundValue);
            _grid.AfterAddRow += new RowColEventHandler(_grid_AfterAddRow);
            _grid.KeyDownEdit += new KeyEditEventHandler(_grid_KeyDownEdit);
            _grid.CellButtonClick += new RowColEventHandler(_grid_CellButtonClick);
            // grid column setting
            try
            {
                // column headers
                _grid.Cols["ID"].Caption = "ID";
                _grid.Cols["OrderID"].Caption = "Order ID";
                _grid.Cols["ItemID"].Caption = "Item ID";
                _grid.Cols["ItemCode"].Caption = "Item Code";
                _grid.Cols["ItemName"].Caption = "Item Name";
                _grid.Cols["Quantity"].Caption = "Quantity";
                _grid.Cols["MeasureCode"].Caption = "UoM";
                _grid.Cols["MeasureName"].Caption = "Measure Name";
                _grid.Cols["UnitPrice"].Caption = "Unit Price";
                _grid.Cols["TrxType"].Caption = "Trx Type";
                _grid.Cols["TaxPct"].Caption = "Tax (%)";
                // read only columns
                _grid.Cols["ID"].AllowEditing = false;
                _grid.Cols["OrderID"].AllowEditing = false;
                _grid.Cols["ItemID"].AllowEditing = false;
                _grid.Cols["ItemName"].AllowEditing = false;
                _grid.Cols["MeasureCode"].AllowEditing = false;
                _grid.Cols["MeasureName"].AllowEditing = false;
                // hide columns
                _grid.Cols["ID"].Visible = false;
                _grid.Cols["ItemID"].Visible = false;
                _grid.Cols["OrderID"].Visible = false;
                _grid.Cols["MeasureName"].Visible = false;
                _grid.Cols["UnitPrice"].Visible = true;
                _grid.Cols["TaxPct"].Visible = true;
                _grid.Cols["TrxType"].Visible = true;
                _grid.Cols["ReferenceID"].Visible = false;
                _grid.Cols["ReferenceNo"].Visible = false;
                _grid.Cols["ReferenceDate"].Visible = false;
                _grid.Cols["ReferenceValue"].Visible = false;
                // number format
                _grid.Cols["ID"].Format = "N2";
                _grid.Cols["OrderID"].Format = "N2";
                _grid.Cols["ItemID"].Format = "N2";
                _grid.Cols["Quantity"].Format = "N2";
                _grid.Cols["UnitPrice"].Format = "N2";
                _grid.Cols["TaxPct"].Format = "N2";
                // COmbo option
                _grid.Cols["ItemCode"].ComboList = "|...";
                // column width
                _grid.Cols["ID"].Width = -1;
                _grid.Cols["OrderID"].Width = -1;
                _grid.Cols["ItemID"].Width = -1;
                _grid.Cols["ItemCode"].Width = 120;
                _grid.Cols["ItemName"].Width = 150;
                _grid.Cols["Quantity"].Width = 70;
                _grid.Cols["MeasureCode"].Width = 50;
                _grid.Cols["MeasureName"].Width = -1;
                _grid.Cols["UnitPrice"].Width = 80;
                _grid.Cols["TrxType"].Width = 70;
                _grid.Cols["TaxPct"].Width = 50;
                // transaction type
                _grid.Cols["TrxType"].DataMap = AppHelper.TransactionTypeDataMap();
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("ERROR Loading Data!\n" + ex.Message);
            }
        }

        #region FlexGrid Events

        private void _grid_CellButtonClick(object sender, RowColEventArgs e)
        {
            Cursor = Cursors.AppStarting;
            try
            {
                // open item list form
                if (e.Col == _grid.Cols["ItemCode"].SafeIndex)
                {
                    frmItemSearch fx;
                    if (_grid[e.Row, "ItemCode"] == DBNull.Value)
                        fx = new frmItemSearch();
                    else
                        fx = new frmItemSearch((int)_grid[e.Row, "ItemID"]);
                    fx.ShowDialog();

                    if (fx.SelectedOK)
                    {
                        dsCore.ItemsDataTable data = daItems1.GetDataByID(fx.SelectedID);
                        // item info
                        if (data.Rows.Count > 0)
                        {
                            _grid.SetData(e.Row, "ItemID", data[0].ID);
                            _grid.SetData(e.Row, "ItemCode", data[0].Code);
                            _grid.SetData(e.Row, "ItemName", data[0].Name);
                            _grid.SetData(e.Row, "MeasureCode", data[0].IsMeasureCodeNull() ? "" : data[0].MeasureCode);
                            _grid.SetData(e.Row, "UnitPrice", data[0].IsSellingPriceNull() ? 0 : data[0].SellingPrice);
                            _grid.SetData(e.Row, "TaxPct", 0);
                            _grid.SetData(e.Row, "TrxType", 0);
                            _grid.SetData(e.Row, "Quantity", 1);
                            // display default remark
                            _grid.SetData(e.Row, "Remarks", c1TextBox2.Text);
                        }
                    }
                }
                // Auto counting for kredit each time
                c1Label1.Value = CountDetails();
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("ERROR Adding Detail Items: " + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor = Cursors.Default;
        }

        private void _grid_KeyDownEdit(object sender, KeyEditEventArgs e)
        {
            // get editor which contains user input
            Control ctl = _grid.Editor;

            // handle manual user input for department code
            if (e.Col == _grid.Cols["ItemCode"].SafeIndex)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (String.IsNullOrEmpty(ctl.Text.Trim()))
                    {
                        _grid.SetData(e.Row, "ItemID", DBNull.Value);
                        _grid.SetData(e.Row, "ItemCode", DBNull.Value);
                        _grid.SetData(e.Row, "ItemName", DBNull.Value);
                        _grid.SetData(e.Row, "MeasureCode", DBNull.Value);
                        _grid.SetData(e.Row, "UnitPrice", 0);
                        _grid.SetData(e.Row, "TaxPct", 0);
                        _grid.SetData(e.Row, "TrxType", 0);
                        _grid.SetData(e.Row, "Quantity", 1);
                        // display default remark
                        _grid.SetData(e.Row, "Remarks", DBNull.Value);
                    }
                    else
                    {
                        dsCore.ItemsDataTable data = daItems1.GetDataByCode(ctl.Text);
                        if (data.Rows.Count > 0)
                        {
                            _grid.SetData(e.Row, "ItemID", data[0].ID);
                            _grid.SetData(e.Row, "ItemCode", data[0].Code);
                            _grid.SetData(e.Row, "ItemName", data[0].Name);
                            _grid.SetData(e.Row, "MeasureCode", data[0].IsMeasureCodeNull() ? "" : data[0].MeasureCode);
                            _grid.SetData(e.Row, "UnitPrice", data[0].IsSellingPriceNull() ? 0 : data[0].SellingPrice);
                            _grid.SetData(e.Row, "TaxPct", 0);
                            _grid.SetData(e.Row, "TrxType", 0);
                            _grid.SetData(e.Row, "Quantity", 1);
                            // display default remark
                            _grid.SetData(e.Row, "Remarks", c1TextBox2.Text);
                        }
                        else
                            _grid_CellButtonClick(sender, new RowColEventArgs(e.Row, e.Col));
                    }
                    // Auto counting for kredit each time
                    c1Label1.Value = CountDetails();
                }
            }

        }

        private void _grid_AfterAddRow(object sender, RowColEventArgs e)
        {
            if (dsCore1.Orders.Rows.Count > 0)
                _grid.SetData(e.Row, "OrderID", (int)dsCore1.Orders[0].ID);
        }

        private void _grid_Enter(object sender, EventArgs e)
        {
            if (!c1TextBox1.ValueIsDbNull)
            {
                BindingContext[dsCore1, "Orders"].EndCurrentEdit();
                if (txMode == DataEntryModes.Add)
                    dsCore1.Orders.AcceptChanges();
            }
        }

        private void _grid_GetUnboundValue(object sender, UnboundValueEventArgs e)
        {
            /*
             * ******************
            try
            {
                if (e.Col == _grid.Cols["ItemCode"].SafeIndex)
                    if (_grid.GetData(e.Row, "ItemID") != DBNull.Value)
                        if (_grid.GetData(e.Row, "ItemID").ToString().Trim() != "")
                            e.Value = dsCore1.ACCOUNTS.FindByItemID((int)_grid.GetData(e.Row, "ItemID")).ItemCode;
                if (e.Col == _grid.Cols["ItemName"].SafeIndex)
                    if (_grid.GetData(e.Row, "ItemID") != DBNull.Value)
                        if (_grid.GetData(e.Row, "ItemID").ToString().Trim() != "")
                            e.Value = dsCore1.ACCOUNTS.FindByItemID((int)_grid.GetData(e.Row, "ItemID")).DESCRIPTION;
                if (e.Col == _grid.Cols["ItemCode"].SafeIndex)
                    if (_grid.GetData(e.Row, "ItemID") != DBNull.Value)
                        e.Value = Departments.GetDepartmentCode((int)_grid.GetData(e.Row, "ItemID"));
                if (e.Col == _grid.Cols["PROJECT_CODE"].SafeIndex)
                    if (_grid.GetData(e.Row, "PROJECT_ID") != DBNull.Value)
                        e.Value = Projects.GetProjectCode((int)_grid.GetData(e.Row, "PROJECT_ID"));
            }
            catch
            {
                e.Value = "n/a";
            }
             * *******************/
        }

        private void _grid_AfterEdit(object sender, RowColEventArgs e)
        {
            NumberFormatInfo nfi = Application.CurrentCulture.NumberFormat;

            if (e.Col == _grid.Cols["ItemID"].SafeIndex || e.Col == _grid.Cols["ItemCode"].SafeIndex)
            {
                if (_grid.GetData(e.Row, "ItemCode") != DBNull.Value &&
                    _grid.GetData(e.Row, "ItemCode").ToString().Trim() != "")
                {
                    // read data
                    string code = _grid.GetData(e.Row, "ItemCode").ToString().Trim();
                    dsCore.ItemsDataTable data = daItems1.GetDataByCode(code);
                    if (data.Rows.Count > 0)
                    {
                        // display data
                        _grid.SetData(e.Row, "ItemID", data[0].ID);
                        _grid.SetData(e.Row, "ItemCode", data[0].Code);
                        _grid.SetData(e.Row, "ItemName", data[0].Name);
                        _grid.SetData(e.Row, "MeasureCode", data[0].IsMeasureCodeNull() ? "" : data[0].MeasureCode);
                        _grid.SetData(e.Row, "UnitPrice", data[0].IsSellingPriceNull() ? 0 : data[0].SellingPrice);
                        _grid.SetData(e.Row, "TaxPct", 0);
                        _grid.SetData(e.Row, "TrxType", 0);
                        _grid.SetData(e.Row, "Quantity", 1);
                        // display default remark
                        _grid.SetData(e.Row, "Remarks", c1TextBox2.Text);
                    }
                }
            }

            // update converted credit column value
            if (e.Col == _grid.Cols["Quantity"].SafeIndex)
            {
                if (_grid.GetData(e.Row, "Quantity") != DBNull.Value &&
                    _grid.GetData(e.Row, "Quantity").ToString() != "")
                {
                    //_grid.SetData(e.Row, "ExtendedPrice", (double)_grid.GetData(e.Row, "Quantity") * (double)_grid.GetData(e.Row, "UnitPrice"));
                }
            }

            // Auto counting for kredit each time
            c1Label1.Value = CountDetails();
        }

        private double CountDetails()
        {
            double _iTemp = 0;
            try
            {
                for (int i = 1; i < _grid.Rows.Count - 1; i++)
                    _iTemp += Convert.ToDouble(_grid.GetData(i, "UnitPrice")) * Convert.ToDouble(_grid.GetData(i, "Quantity"));
                return _iTemp;
            }
            catch
            {
                return _iTemp;
            }
        }

        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            Form fx = new frmReportViewer1(ReportHelper1.LoadPurchaseInvoiceForm(c1TextBox1.Text));
            fx.WindowState = FormWindowState.Maximized;
            fx.ShowDialog();
            Cursor = Cursors.Default;
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

                    // copy juga detail record dari main dataset
                    for (int i = 0; i < dsCore1.OrderDetails.Rows.Count; i++)
                        dsChanges.OrderDetails.Rows.Add(dsCore1.OrderDetails.Rows[i].ItemArray);

                    // persist changes to database
                    daOrders1.Update(dsChanges.Orders);
                    daOrderDetails1.Update(dsChanges.OrderDetails);

                    // inform user for successful update
                    DialogResult dr = RibbonMessageBox.Show("Data SUCCESFULLY saved to database\n" +
                        "Do you want to print this document?\n",
                        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // ask user for voucher print
                    if (dr == DialogResult.Yes)
                    {
                        Cursor = Cursors.AppStarting;
                        Form fx = new frmReportViewer1(ReportHelper1.LoadPurchaseInvoiceForm(c1TextBox1.Text));
                        fx.WindowState = FormWindowState.Maximized;
                        fx.ShowDialog();
                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    // persist changes to database
                    daOrders1.Update(dsCore1.Orders);
                    daOrderDetails1.Update(dsCore1.OrderDetails);

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

        private void c1Combo2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txMode == DataEntryModes.Add)
            {
                try
                {
                    // get data
                    dsCore ds = new dsCore();
                    OrdersTableAdapter od = new OrdersTableAdapter();
                    OrderDetailsTableAdapter ta = new OrderDetailsTableAdapter();
                    ds.EnforceConstraints = false;
                    od.Connection = AppHelper.GetDbConnection();
                    od.FillByID(ds.Orders, (int)c1Combo2.SelectedValue);
                    ta.Connection = AppHelper.GetDbConnection();
                    ta.FillNotCompleted(ds.OrderDetails, (int)c1Combo2.SelectedValue);
                    // clear grid
                    dsCore1.OrderDetails.Clear();
                    // fill grid with new data
                    _grid.Redraw = false;
                    DataRowView dv = (DataRowView)this.BindingContext[dsCore1, "Orders"].Current;
                    dv["CompanyID"] = ds.Orders[0].CompanyID;
                    dv["CurrencyID"] = ds.Orders[0].CurrencyID;
                    if (!ds.Orders[0].IsCompanyIDNull())
                        c1Combo1.SelectedValue = ds.Orders[0].CompanyID;
                    if (!ds.Orders[0].IsCurrencyIDNull())
                        c1Combo3.SelectedValue = ds.Orders[0].CurrencyID;
                    foreach (dsCore.OrderDetailsRow src in ds.OrderDetails.Rows)
                    {
                        dsCore.OrderDetailsRow row = dsCore1.OrderDetails.NewOrderDetailsRow();
                        row.OrderID = (int)dv["ID"];
                        row.ItemID = src.ItemID;
                        row.ItemCode = src.ItemCode;
                        row.ItemName = src.ItemName;
                        row.Quantity = src.Quantity;
                        row.UnitPrice = src.UnitPrice;
                        row.TaxPct = src.TaxPct;
                        row.Remarks = src.Remarks;
                        row.MeasureCode = src.MeasureCode;
                        dsCore1.OrderDetails.AddOrderDetailsRow(row);
                    }
                    // redraw grid
                    _grid.Redraw = true;
                    _grid.Refresh();
                    // recalculate order value
                    c1Label1.Value = CountDetails();
                }
                catch (Exception ex)
                {
                    // textfile logging
                    Logger.ErrorRoutine(ex);
                    // screen logging
                    RibbonMessageBox.Show("ERROR Retrieving Detail Data: \n" + ex.Message,
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}

