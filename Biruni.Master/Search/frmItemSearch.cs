using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biruni.Shared;

namespace Biruni.Master.Search
{
    public partial class frmItemSearch : Biruni.Shared.Templates.frmSearch
    {
        public frmItemSearch()
        {
            frmItemSearch_Helper(-1);
        }

        public frmItemSearch(int id)
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
            sSearchID = id;
            dsCore1.EnforceConstraints = false;
            daItems1.ClearBeforeFill = true;
            daItems1.Connection = AppHelper.GetDbConnection();
            daItems1.FillActive(dsCore1.Items);
        }

        protected override void OnShown(EventArgs e)
        {
            // point selection to specified id
            if (sSearchID > 0)
                for (int i = 1; i <= _grid.RowCount - 1; i++)
                {
                    if ((int)_grid[i, "ID"] == sSearchID)
                    {
                        _grid.Row = i;
                        break;
                    }
                }
            // call base function
            base.OnShown(e);
        }

        protected override void SaveValue()
        {
            sSearchID = Convert.ToInt32(_grid[_grid.Row, "ID"]);
            sSearchCode = _grid[_grid.Row, "Code"].ToString();
            sSearchDesc = _grid[_grid.Row, "Name"].ToString();
            bSearchOK = true;
        }
    }
}

