namespace Biruni.Master.List
{
    partial class frmItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemList));
            this.dsCore1 = new Biruni.Shared.Data.dsCore();
            this.daItems1 = new Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // _grid
            // 
            this._grid.Caption = "Item Master List";
            this._grid.DataMember = "Items";
            this._grid.DataSource = this.dsCore1;
            this._grid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this._grid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this._grid.PreviewInfo.ZoomFactor = 75D;
            this._grid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("_grid.PrintInfo.PageSettings")));
            this._grid.Size = new System.Drawing.Size(632, 288);
            this._grid.PropBag = resources.GetString("_grid.PropBag");
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Size = new System.Drawing.Size(632, 38);
            this.panel2.Visible = false;
            // 
            // dtpBegin
            // 
            // 
            // 
            // 
            this.dtpBegin.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtpBegin.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtpBegin.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // dtpEnd
            // 
            // 
            // 
            // 
            this.dtpEnd.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtpEnd.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtpEnd.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
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
            // frmItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmItemList";
            this.Text = "Item Master List";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Biruni.Shared.Data.dsCore dsCore1;
        private Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter daItems1;
    }
}
