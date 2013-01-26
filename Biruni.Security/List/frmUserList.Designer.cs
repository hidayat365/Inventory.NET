namespace Biruni.Security.List
{
    partial class frmUserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserList));
            this.dsSecurity1 = new Biruni.Shared.Data.dsSecurity();
            this.daUsers1 = new Biruni.Shared.Data.dsSecurityTableAdapters.UsersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecurity1)).BeginInit();
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
            this._grid.Caption = "User Account List";
            this._grid.DataMember = "Users";
            this._grid.DataSource = this.dsSecurity1;
            this._grid.Images.Add(((System.Drawing.Image)(resources.GetObject("_grid.Images"))));
            this._grid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this._grid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this._grid.PreviewInfo.ZoomFactor = 75;
            this._grid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("_grid.PrintInfo.PageSettings")));
            this._grid.PropBag = resources.GetString("_grid.PropBag");
            // 
            // panel2
            // 
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
            // dsSecurity1
            // 
            this.dsSecurity1.DataSetName = "dsSecurity";
            this.dsSecurity1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daUsers1
            // 
            this.daUsers1.ClearBeforeFill = true;
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmUserList";
            this.Text = "Application User List";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecurity1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Biruni.Shared.Data.dsSecurity dsSecurity1;
        private Biruni.Shared.Data.dsSecurityTableAdapters.UsersTableAdapter daUsers1;
    }
}
