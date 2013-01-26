using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Shared;

namespace Biruni.Purchasing.Search
{
    public partial class frmPurchaseInvoiceSearch : Biruni.Shared.Templates.frmSearch
    {
        public frmPurchaseInvoiceSearch(int id)
        {
            frmItemSearch_Helper(id);
        }

        public void frmItemSearch_Helper(int id)
        {
            InitializeComponent();
            InitializeForm(id);
        }

        private void InitializeForm(int id)
        {
            dsCore1.EnforceConstraints = false;
            daItems1.ClearBeforeFill = true;
            daItems1.Connection = AppHelper.GetDbConnection();
            daItems1.FillOutstandingPurchaseInvoice(dsCore1.Orders, id);
        }

        protected override void SaveValue()
        {
            sSearchID = Convert.ToInt32(_grid[_grid.Row, "ID"]);
            sSearchCode = _grid[_grid.Row, "OrderNo"].ToString();
            sSearchDesc = _grid[_grid.Row, "OrderNo"].ToString();
            sSearchDate = (DateTime)_grid[_grid.Row, "OrderDate"];
            sSearchValue = (double)_grid[_grid.Row, "OutstandingValue"];
            bSearchOK = true;
        }
    }
}

