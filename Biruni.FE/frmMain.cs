using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Biruni.Master.List;
using Biruni.Master.Entry;
using Biruni.Sales.List;
using Biruni.Purchasing.List;
using Biruni.Inventory.List;
using Biruni.Security.List;
using Biruni.Security.Entry;
using Biruni.Reports;
using Biruni.Shared;
using Biruni.Shared.Data;
using Biruni.Shared.Logging;
using Biruni.Shared.Templates;
using Biruni.FE.Properties;

namespace Biruni.FE
{
    public partial class frmMain : C1RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeForm();
            InitializeRibbonStyleMenu();
            InitializeMenu();
            InitializeStatusBar();
        }

        private void InitializeForm()
        {
            this.Text = Application.ProductName;
            this.StartPosition = FormStartPosition.Manual;
            this.Top = 0;
            this.Left = 0;
            this.Width = 800;
            this.Height = 480;
            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.ribbonLabel3.Text = "User: " + AppHelper.appUserName + " - Logged As: " + AppHelper.appRoleName;
            this.ribbonLabel1.Text = "Connected to: " + AppHelper.dbServer + " (" + AppHelper.dbName + ")";
            this.ribbonLabel4.Text = Application.ProductName + " (Version: " + Application.ProductVersion + ")";
            AppHelper.ApplyFormStyle(this);
            AppHelper.ApplyVisualStyle(this.Controls);
        }

        private void InitializeMenu()
        {
            HideAllMenus();
            ShowAllowedMenus();
            // redisplay default menu
            tabApplication.Visible = true;
            grpApplication.Visible = true;
            grpWindow.Visible = true;
            switchWindowsMenu.Visible = true;
            switchWindowsToggleGroup.Visible = true;
            ribbonToggleGroup1.Visible = true;
            btnHelp.Visible = true;
            btnAppExit.Visible = true;
            btnStyles.Visible = true;
            tabTransactions.Selected = true;
        }

        private void InitializeStatusBar()
        {
            timer1.Enabled = true;
            timer1.Start();
            ribbonLabel2.Text = DateTime.Now.ToString("dd MMMM yyyy - HH:mm:ss");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult res;

            res = RibbonMessageBox.Show("Do you want to quit " + Application.ProductName + "?",
                Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

            if (!e.Cancel)
                Logger.DebugRoutine("Application Closed.\n=====================================\n\n");

            base.OnClosing(e);
        }

        #region Application Menu Initialization

        /// <summary>
        /// This function will read from database based on current user
        /// and then will display all aplication menu button allowed for that user
        /// </summary>
        private void ShowAllowedMenus()
        {
            try
            {
                dsSecurity1.EnforceConstraints = false;
                daApplicationRoles.Connection = AppHelper.GetDbConnection();
                daApplicationRoles.FillByUserID(dsSecurity1.ApplicationRoles, AppHelper.appUserID);
                foreach (dsSecurity.ApplicationRolesRow row in dsSecurity1.ApplicationRoles.Rows)
                    if (row.AllowRead) ShowMenu(row.ApplicationCode);
            }
            catch (Exception ex)
            {
                Logger.ErrorRoutine(ex);
                RibbonMessageBox.Show("Kesalahan terjadi saat inisialisasi menu aplikasi: " + ex.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ShowMenu(string appCode)
        {
            switch (appCode)
            {
                case "IMS-01001":  // Sales Quotations
                    btnSalesQuotations.Visible = true;
                    grpSales.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-01002":  // Sales Orders
                    btnSalesOrders.Visible = true;
                    grpSales.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-01003":  // Delivery Orders
                    btnDeliveryOrders.Visible = true;
                    grpSales.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-01004":  // Sales Invoices
                    ribbonSeparator4.Visible = true;
                    btnSalesInvoice.Visible = true;
                    grpSales.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-01005":  // Customer Payment
                    ribbonSeparator4.Visible = true;
                    btnSalesPayment.Visible = true;
                    grpSales.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-02001":  // Purchase Quotations
                    break;
                case "IMS-02002":  // Supplier Selection
                    break;
                case "IMS-02003":  // Purchase Orders
                    btnPurchaseOrders.Visible = true;
                    grpPurchasing.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-02004":  // Receiving Reports
                    btnReceivingReports.Visible = true;
                    grpPurchasing.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-02005":  // Purchase Invoices
                    ribbonSeparator5.Visible = true;
                    btnPurchaseInvoice.Visible = true;
                    grpPurchasing.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-02006":  // Vendor Payments
                    ribbonSeparator5.Visible = true;
                    btnPurchasePayment.Visible = true;
                    grpPurchasing.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-03001":  // Company Information
                    btnCompanyInfo.Visible = true;
                    grpAdmin.Visible = true;
                    tabApplication.Visible = true;
                    break;
                case "IMS-03002":  // Customer Information
                    btnCustomerInfo.Visible = true;
                    grpMasterTrx.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-03003":  // Vendor Information
                    btnVendorInfo.Visible = true;
                    grpMasterTrx.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-03004":  // Currency Types
                    btnCurrencyTypes.Visible = true;
                    grpMasterTrx.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-03005":  // Item Information
                    btnItemInfo.Visible = true;
                    grpMasterInv.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-03006":  // Item Categories
                    btnItemCategories.Visible = true;
                    grpMasterInv.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-03007":  // Warehouses
                    btnWarehouses.Visible = true;
                    grpMasterInv.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-03101":  // Opeinng Balance Customer
                    btnBalanceCustomer.Visible = true;
                    grpMasterBalance.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-03102":  // Opeinng Balance Vendor
                    btnBalanceVendor.Visible = true;
                    grpMasterBalance.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-04002":  // Inventory Adjustment
                    btnInventoryAdjustment.Visible = true;
                    grpInventory.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-04001":  // Inventory Status
                    btnInventoryStatus.Visible = true;
                    grpInventory.Visible = true;
                    tabTransactions.Visible = true;
                    break;
                case "IMS-03008":  // Unit of Measures
                    btnUnitMeasures.Visible = true;
                    grpMasterInv.Visible = true;
                    tabMaster.Visible = true;
                    break;
                case "IMS-91001":  // Application Roles
                    btnAppRoles.Visible = true;
                    grpAdmin.Visible = true;
                    tabApplication.Visible = true;
                    break;
                case "IMS-91002":  // Application Users
                    btnAppUsers.Visible = true;
                    grpAdmin.Visible = true;
                    tabApplication.Visible = true;
                    break;
                case "IMS-91003":  // Change Password
                    btnAppChangePwd.Visible = true;
                    grpAdmin.Visible = true;
                    tabApplication.Visible = true;
                    break;
                case "IMS-93001":  // Sales by Customers
                    btnReportsSales.Visible = true;
                    grpReportSales.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-93002":  // Sales By Products
                    btnReportsSales1.Visible = true;
                    grpReportSales.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-93003":  // Sales Back Orders
                    btnReportsSales2.Visible = true;
                    grpReportSales.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-93004":  // Purchase by Vendors
                    btnReportsPurchase.Visible = true;
                    grpReportPurchase.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-93005":  // Purchase by Products
                    btnReportsPurchase1.Visible = true;
                    grpReportPurchase.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-93006":  // Purchase Outstanding Orders
                    btnReportsPurchase2.Visible = true;
                    grpReportPurchase.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-93007":  // Inventory Status
                    btnReportsInventory1.Visible = true;
                    grpReportInventory.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-93008":  // Inventory Mutation
                    btnReportsInventory2.Visible = true;
                    grpReportInventory.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-94011":  // outstanding salesinvoice
                    btnReportsInvoiceSales.Visible = true;
                    grpReportInvoicing.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-94012":  // payments by customers
                    btnReportsPaymentCustomer.Visible = true;
                    grpReportInvoicing.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-94021":  // outstanding purchaseinvoice
                    ribbonSeparator6.Visible = true;
                    btnReportsInvoiceVendor.Visible = true;
                    grpReportInvoicing.Visible = true;
                    tabReporting.Visible = true;
                    break;
                case "IMS-94022":  // payments by vendor
                    ribbonSeparator6.Visible = true;
                    btnReportsPaymentVendor.Visible = true;
                    grpReportInvoicing.Visible = true;
                    tabReporting.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void stub()
        {
            RibbonMessageBox.Show("The method or operation is not implemented.",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// This function will hide all application menu except 
        /// for exit button, style changer button and help button
        /// </summary>
        private void HideAllMenus()
        {
            foreach (RibbonTab ctl in c1Ribbon1.Tabs)
            {
                ctl.Visible = false;
                foreach (RibbonGroup grp in ctl.Groups)
                {
                    grp.Visible = false;
                    foreach (RibbonItem rbitem in grp.Items)
                    {
                        string typeItem = rbitem.GetType().ToString().Trim();
                        rbitem.Visible = false;
                    }
                }
            }

        }
        #endregion

        #region MDI Window List

        private bool _windowSwitching;

        private void switchWindowsToggleGroup_PressedButtonChanged(object sender, EventArgs e)
        {
            RibbonToggleButton tb = switchWindowsToggleGroup.PressedButton;
            if (tb != null)
            {
                Form f = (Form)tb.Tag;
                _windowSwitching = true;
                while (!object.ReferenceEquals(ActiveMdiChild, f))
                    ActivateMdiChild(f);
                _windowSwitching = false;
            }
        }

        protected override void OnMdiChildActivate(EventArgs e)
        {
            if (!_windowSwitching)
                RefreshMdiWindowList();
            base.OnMdiChildActivate(e);
        }

        private void RefreshMdiWindowList()
        {
            RibbonItemCollection items = switchWindowsToggleGroup.Items;
            for (int i = 0; i < items.Count; i++)
                items[i].Dispose();
            items.Clear();
            Form[] forms = MdiChildren;
            Form activeChild = ActiveMdiChild;
            for (int i = 0; i < forms.Length; i++)
            {
                frmList f = forms[i] as frmList;
                if (f != null && !f.BeingDisposed)
                {
                    RibbonToggleButton tb = new RibbonToggleButton();
                    tb.Pressed = object.ReferenceEquals(f, activeChild);
                    tb.Text = f.Text;
                    tb.Tag = f;
                    items.Add(tb);
                }
            }
            switchWindowsMenu.Enabled = items.Count > 0;
        }

        #endregion

        #region Other Event Handlers

        private void timer1_Tick(object sender, EventArgs e)
        {
            ribbonLabel2.Text = DateTime.Now.ToString("dd MMMM yyyy - HH:mm:ss");
        }

        #endregion

        #region Ribbon Style Menu

        private void InitializeRibbonStyleMenu()
        {
            this.UpdateRibbonStyleMenuCheckMark();
            this.c1Ribbon1.VisualStyleChanged += delegate { this.UpdateRibbonStyleMenuCheckMark(); };

            this.ribbonToggleButton1.Click += delegate
            {
                AppHelper.visualStyle = VisualStyles.VISUAL_STYLE_BLUE;
                Settings set = Properties.Settings.Default;
                set.visualStyle = VisualStyles.VISUAL_STYLE_BLUE;
                set.Save();
                this.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Blue;
            };
            this.ribbonToggleButton2.Click += delegate
            {
                AppHelper.visualStyle = VisualStyles.VISUAL_STYLE_SILVER;
                Settings set = Properties.Settings.Default;
                set.visualStyle = VisualStyles.VISUAL_STYLE_SILVER;
                set.Save();
                this.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Silver;
            };
            this.ribbonToggleButton3.Click += delegate
            {
                AppHelper.visualStyle = VisualStyles.VISUAL_STYLE_BLACK;
                Settings set = Properties.Settings.Default;
                set.visualStyle = VisualStyles.VISUAL_STYLE_BLACK;
                set.Save();
                this.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Black;
            };
            this.ribbonToggleButton4.Click += delegate
            {
                AppHelper.visualStyle = VisualStyles.VISUAL_STYLE_BLUE10;
                Settings set = Properties.Settings.Default;
                set.visualStyle = VisualStyles.VISUAL_STYLE_BLUE10;
                set.Save();
                this.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
            };
            this.ribbonToggleButton5.Click += delegate
            {
                AppHelper.visualStyle = VisualStyles.VISUAL_STYLE_SILVER10;
                Settings set = Properties.Settings.Default;
                set.visualStyle = VisualStyles.VISUAL_STYLE_SILVER10;
                set.Save();
                this.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Silver;
            };
            this.ribbonToggleButton6.Click += delegate
            {
                AppHelper.visualStyle = VisualStyles.VISUAL_STYLE_BLACK10;
                Settings set = Properties.Settings.Default;
                set.visualStyle = VisualStyles.VISUAL_STYLE_BLACK10;
                set.Save();
                this.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Black;
            };
            this.ribbonToggleButton7.Click += delegate
            {
                AppHelper.visualStyle = VisualStyles.VISUAL_STYLE_WINDOWS7;
                Settings set = Settings.Default;
                set.visualStyle = VisualStyles.VISUAL_STYLE_WINDOWS7;
                set.Save();
                this.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Windows7;
            };
        }

        private void UpdateRibbonStyleMenuCheckMark()
        {
            // apply ribbon visual style
            switch (this.VisualStyle)
            {
                case VisualStyle.Office2007Blue:
                    this.ribbonToggleButton1.Pressed = true;
                    break;
                case VisualStyle.Office2007Silver:
                    this.ribbonToggleButton2.Pressed = true;
                    break;
                case VisualStyle.Office2007Black:
                    this.ribbonToggleButton3.Pressed = true;
                    break;
                case VisualStyle.Office2010Blue:
                    this.ribbonToggleButton4.Pressed = true;
                    break;
                case VisualStyle.Office2010Silver:
                    this.ribbonToggleButton5.Pressed = true;
                    break;
                case VisualStyle.Office2010Black:
                    this.ribbonToggleButton6.Pressed = true;
                    break;
                case VisualStyle.Windows7:
                    this.ribbonToggleButton7.Pressed = true;
                    break;
                default:
                    this.ribbonToggleButton1.Pressed = true;
                    break;
            }
            // apply visual style for other controls
            AppHelper.ApplyVisualStyle(this.Controls);
        }

        #endregion

        #region Menu Event Handlers

        private void btnInventoryStatus_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmInventoryStatus();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnInventoryAdjustment_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmInventoryAdjustmentList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmCompanyList(CompanyTypes.Customer);
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnVendorInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmCompanyList(CompanyTypes.Vendor);
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnCurrencyTypes_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmCurrencyList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnItemInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmItemList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnItemCategories_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmItemCategoryList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmWarehouseList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnUnitMeasures_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmUnitMeasureList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Application Menu Event Handler

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmAbout();
            fx.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void btnAppRoles_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmRoleList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnAppUsers_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmUserList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnAppChangePwd_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            Form fx = new frmUserEntry(AppHelper.appUserID);
            fx.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void btnAppExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            Form fx = new frmOwnerEntry();
            fx.ShowDialog();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Reporting Menu Handler

        private void btnReportsSales_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadSalesByCustomer(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnReportsSales1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadSalesByProduct(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnReportsPurchase_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadPurchaseByVendor(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnReportsPurchase1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadPurchaseByProduct(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnReportsInventory1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmReportViewer1(ReportHelper1.LoadInventoryStatus());
            fx.MdiParent = this;
            fx.WindowState = FormWindowState.Maximized;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnReportsSales2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadSalesOutstanding(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnReportsPurchase2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadPurchaseOutstanding(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnReportsInventory_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria2 fc = new frmReportCriteria2();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadInventoryMutation(fc.SelectedID));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        #endregion

        #region Sales Menu Event Handler

        private void btnSalesQuotations_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmSalesQuotationList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnSalesOrders_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmSalesOrderList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnDeliveryOrders_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmDeliveryOrderList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnSalesInvoice_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmSalesInvoiceList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnSalesPayment_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmSalesPaymentList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Purchasing Menu Event Handler

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmPurchaseOrderList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnReceivingReports_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmReceivingReportList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnPurchaseInvoice_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmPurchaseInvoiceList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnPurchasePayment_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmPurchasePaymentList();
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        #endregion

        private void btnReportsInvoiceSales_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadSalesInvoiceOutstanding(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnReportsPaymentCustomer_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadSalesPaymentByCustomer(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;

        }

        private void btnReportsInvoiceVendor_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadPurchaseInvoiceOutstanding(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnReportsPaymentVendor_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmReportCriteria1 fc = new frmReportCriteria1();
            DialogResult res = fc.ShowDialog();
            if (res == DialogResult.OK)
            {
                Form fx = new frmReportViewer1(ReportHelper1.LoadPurchasePaymentByVendor(fc.PeriodStart, fc.PeriodEnd));
                fx.MdiParent = this;
                fx.WindowState = FormWindowState.Maximized;
                fx.Show();
            }
            Cursor = Cursors.Default;

        }

        private void btnBalanceCustomer_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmCompanyBalanceList(CompanyTypes.Customer);
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

        private void btnBalanceVendor_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form fx = new frmCompanyBalanceList(CompanyTypes.Vendor);
            fx.MdiParent = this;
            fx.Show();
            Cursor = Cursors.Default;
        }

    }
}