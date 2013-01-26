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
using Biruni.Shared;
using Biruni.Shared.Data;
using Biruni.Shared.Logging;
using Biruni.Master.Search;
using Biruni.Reports;

namespace Biruni.Purchasing.Entry
{
    public partial class frmPurchaseOrderEntry : Biruni.Shared.Templates.frmEntry2
    {
        int InvoiceID = -1;
        int PaymentID = -1;
        string InvoiceNum = String.Empty;
        string PaymentNum = String.Empty;

        public frmPurchaseOrderEntry()
        {
            frmPurchaseOrderEntry_Helper(-1);
        }

        public frmPurchaseOrderEntry(int id)
        {
            frmPurchaseOrderEntry_Helper(id);
        }

        public void frmPurchaseOrderEntry_Helper(int id)
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
                // set database connection
                dsCore1.EnforceConstraints = false;
                daCurrencies1.Connection = AppHelper.GetDbConnection();
                daCompanies1.Connection = AppHelper.GetDbConnection();
                daItems1.Connection = AppHelper.GetDbConnection();
                daOrders1.Connection = AppHelper.GetDbConnection();
                daOrderDetails1.Connection = AppHelper.GetDbConnection();
                // lookup table
                daCompanies1.FillVendorActive(dsCore1.Companies);
                daCurrencies1.FillActive(dsCore1.Currencies);
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
            ModulePrefix = TransactionTypes.TX_PURCHASE_ORDER;
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
                            _grid.SetData(e.Row, "UnitPrice", data[0].IsBasePriceNull() ? 0 : data[0].BasePrice);
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
                            _grid.SetData(e.Row, "UnitPrice", data[0].IsBasePriceNull() ? 0 : data[0].BasePrice);
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
                        _grid.SetData(e.Row, "UnitPrice", data[0].IsBasePriceNull() ? 0 : data[0].BasePrice);
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

                    // only generate invoice 
                    GenerateInvoice(dsChanges);

                    // generate payment record for cash payment
                    if (radioButton1.Checked || Convert.ToDouble(c1NumericEdit1.Value) > 0)
                        GeneratePayment(dsChanges);

                    // inform user, successful
                    DialogResult dr = RibbonMessageBox.Show("Data SUCCESFULLY saved to database\n" +
                        (InvoiceID < 0 ? "" : "New Invoice Voucher [" + InvoiceNum + "] created automatically\n") +
                        (PaymentID < 0 ? "" : "New Payment Voucher [" + PaymentNum + "] created automatically\n") +
                        "Do you want to print this document?\n",
                        Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // ask user for voucher print
                    if (dr == DialogResult.Yes)
                    {
                        Cursor = Cursors.AppStarting;
                        Form fx = new frmReportViewer1(ReportHelper1.LoadPurchaseOrderForm(c1TextBox1.Text));
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

        private void GeneratePayment(dsCore ds)
        {
            dsCore dt = new dsCore();
            dt.EnforceConstraints = false;

            // copy master record
            dt.Orders.Rows.Add(ds.Orders[0].ItemArray);
            // ubah jenis transaksi
            dt.Orders[0].ParentID = ds.Orders[0].ID;
            dt.Orders[0].OrderNo = DbHelper.GenerateNewOrderID(TransactionTypes.TX_PURCHASE_PAYMENT, dt.Orders[0].OrderDate.Year);
            dt.Orders[0].OrderType = TransactionTypes.TX_PURCHASE_PAYMENT;
            dt.Orders[0].OrderValue = Convert.ToDouble(c1NumericEdit1.Value);
            // detail payment
            dsCore.OrderDetailsRow row = dt.OrderDetails.NewOrderDetailsRow();
            row.OrderID = dt.Orders[0].ID;
            row.ReferenceID = InvoiceID;
            row.UnitPrice = Convert.ToDouble(c1NumericEdit1.Value);
            row.Quantity = 1;
            row.TaxPct = 0;
            if (!dt.Orders[0].IsRemarksNull())
                row.Remarks = ds.Orders[0].Remarks;
            dt.OrderDetails.AddOrderDetailsRow(row);

            // persist changes to database
            daOrders1.Update(dt.Orders);
            daOrderDetails1.Update(dt.OrderDetails);

            // remember result
            PaymentID = dt.Orders[0].ID;
            PaymentNum = dt.Orders[0].OrderNo;
        }

        private void GenerateInvoice(dsCore ds)
        {
            dsCore dt = new dsCore();
            dt.EnforceConstraints = false;

            // copy master record
            dt.Orders.Rows.Add(ds.Orders[0].ItemArray);
            // copy juga detail record dari main dataset
            for (int i = 0; i < ds.OrderDetails.Rows.Count; i++)
                dt.OrderDetails.Rows.Add(ds.OrderDetails.Rows[i].ItemArray);
            // ubah jenis transaksi
            dt.Orders[0].ParentID = ds.Orders[0].ID;
            dt.Orders[0].OrderNo = DbHelper.GenerateNewOrderID(TransactionTypes.TX_PURCHASE_INVOICE, dt.Orders[0].OrderDate.Year);
            dt.Orders[0].OrderType = TransactionTypes.TX_PURCHASE_INVOICE;
            dt.Orders[0].OrderValue = ds.Orders[0].OrderValue;
            // persist changes to database
            daOrders1.Update(dt.Orders);
            daOrderDetails1.Update(dt.OrderDetails);
            // remember result
            InvoiceID = dt.Orders[0].ID;
            InvoiceNum = dt.Orders[0].OrderNo;
        }

        private bool ValidateUserInput()
        {
            if (c1Combo1.SelectedValue == null || c1Combo3.SelectedValue == null)
            {
                RibbonMessageBox.Show("Please select Vendor and set Currency Type before saving data",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (radioButton1.Checked && Convert.ToDouble(c1Label1.Value) != Convert.ToDouble(c1NumericEdit1.Value))
            {
                RibbonMessageBox.Show("Payment Value must be equals to Purchase Order value \n",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            // otherwise, successful
            return true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            Form fx = new frmReportViewer1(ReportHelper1.LoadPurchaseOrderForm(c1TextBox1.Text));
            fx.WindowState = FormWindowState.Maximized;
            fx.ShowDialog();
            Cursor = Cursors.Default;
        }
 
    }
}

