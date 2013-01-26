namespace Biruni.Sales.Search
{
    partial class frmSalesInvoiceSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesInvoiceSearch));
            this.dsCore1 = new Biruni.Shared.Data.dsCore();
            this.daItems1 = new Biruni.Shared.Data.dsCoreTableAdapters.OrdersTableAdapter();
            this.gbBottomSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBottomSearch
            // 
            this.gbBottomSearch.Location = new System.Drawing.Point(0, 405);
            this.gbBottomSearch.Size = new System.Drawing.Size(890, 42);
            // 
            // _grid
            // 
            this._grid.Caption = "Sales Invoice List";
            this._grid.DataMember = "Orders";
            this._grid.DataSource = this.dsCore1;
            this._grid.Images.Add(((System.Drawing.Image)(resources.GetObject("_grid.Images"))));
            this._grid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this._grid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this._grid.PreviewInfo.ZoomFactor = 75;
            this._grid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("_grid.PrintInfo.PageSettings")));
            this._grid.Size = new System.Drawing.Size(890, 405);
            this._grid.PropBag = resources.GetString("_grid.PropBag");
            // 
            // btCloseSearch
            // 
            this.btCloseSearch.Location = new System.Drawing.Point(799, 12);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(892, 449);
            // 
            // dsCore1
            // 
            this.dsCore1.DataSetName = "dsCore";
            this.dsCore1.Locale = new System.Globalization.CultureInfo("id-ID");
            this.dsCore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daItems1
            // 
            this.daItems1.ClearBeforeFill = true;
            // 
            // frmSalesInvoiceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(892, 449);
            this.Name = "frmSalesInvoiceSearch";
            this.Text = "Sales Invoice Search";
            this.gbBottomSearch.ResumeLayout(false);
            this.gbBottomSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Biruni.Shared.Data.dsCore dsCore1;
        private Biruni.Shared.Data.dsCoreTableAdapters.OrdersTableAdapter daItems1;
    }
}
