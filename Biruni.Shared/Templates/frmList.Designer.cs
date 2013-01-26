namespace Biruni.Shared.Templates
{
    partial class frmList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// This variable allows to exclude the window that is
        /// being disposed from the MDI Window List.
        /// </summary>
        public bool BeingDisposed;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            BeingDisposed = true;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new C1.Win.C1Input.C1Button();
            this.btnPrint = new C1.Win.C1Input.C1Button();
            this.btnRefresh = new C1.Win.C1Input.C1Button();
            this.btnDelete = new C1.Win.C1Input.C1Button();
            this.btnEdit = new C1.Win.C1Input.C1Button();
            this.btnAdd = new C1.Win.C1Input.C1Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new C1.Win.C1Input.C1DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBegin = new C1.Win.C1Input.C1DateEdit();
            this._grid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Biruni.Shared.Properties.Resources.application_stop;
            this.btnClose.Location = new System.Drawing.Point(448, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(80, 24);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Biruni.Shared.Properties.Resources.printer;
            this.btnPrint.Location = new System.Drawing.Point(348, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(80, 24);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Biruni.Shared.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(264, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(80, 24);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Biruni.Shared.Properties.Resources.delete2;
            this.btnDelete.Location = new System.Drawing.Point(180, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(80, 24);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Biruni.Shared.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(96, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(80, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Biruni.Shared.Properties.Resources.add2;
            this.btnAdd.Location = new System.Drawing.Point(12, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(80, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.c1Button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpEnd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpBegin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 38);
            this.panel2.TabIndex = 2;
            // 
            // c1Button1
            // 
            this.c1Button1.Image = global::Biruni.Shared.Properties.Resources.find_next;
            this.c1Button1.Location = new System.Drawing.Point(520, 6);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.c1Button1.Size = new System.Drawing.Size(80, 24);
            this.c1Button1.TabIndex = 8;
            this.c1Button1.Text = "&Filter";
            this.c1Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(304, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // dtpEnd
            // 
            this.dtpEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.dtpEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtpEnd.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtpEnd.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtpEnd.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtpEnd.FormatType = C1.Win.C1Input.FormatTypeEnum.LongDate;
            this.dtpEnd.Location = new System.Drawing.Point(328, 8);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(184, 19);
            this.dtpEnd.TabIndex = 2;
            this.dtpEnd.Tag = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show data from";
            // 
            // dtpBegin
            // 
            this.dtpBegin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.dtpBegin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtpBegin.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dtpBegin.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtpBegin.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.dtpBegin.FormatType = C1.Win.C1Input.FormatTypeEnum.LongDate;
            this.dtpBegin.Location = new System.Drawing.Point(116, 8);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(184, 19);
            this.dtpBegin.TabIndex = 0;
            this.dtpBegin.Tag = null;
            // 
            // _grid
            // 
            this._grid.AllowUpdate = false;
            this._grid.AllowUpdateOnBlur = false;
            this._grid.AlternatingRows = true;
            this._grid.CaptionHeight = 17;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.ExtendRightColumn = true;
            this._grid.FilterBar = true;
            this._grid.GroupByCaption = "Drag a column header here to group by that column";
            this._grid.Images.Add(((System.Drawing.Image)(resources.GetObject("_grid.Images"))));
            this._grid.Location = new System.Drawing.Point(0, 40);
            this._grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this._grid.Name = "_grid";
            this._grid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this._grid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this._grid.PreviewInfo.ZoomFactor = 75;
            this._grid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("_grid.PrintInfo.PageSettings")));
            this._grid.RowHeight = 15;
            this._grid.Size = new System.Drawing.Size(632, 288);
            this._grid.TabIndex = 1;
            this._grid.Text = "c1TrueDBGrid1";
            this._grid.PropBag = resources.GetString("_grid.PropBag");
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Controls.Add(this._grid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Template";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected C1.Win.C1Input.C1Button btnClose;
        protected C1.Win.C1Input.C1Button btnPrint;
        protected C1.Win.C1Input.C1Button btnRefresh;
        protected C1.Win.C1Input.C1Button btnDelete;
        protected C1.Win.C1Input.C1Button btnEdit;
        protected C1.Win.C1Input.C1Button btnAdd;
        protected C1.Win.C1TrueDBGrid.C1TrueDBGrid _grid;
        protected C1.Win.C1Input.C1Button c1Button1;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label label1;
        protected C1.Win.C1Input.C1DateEdit dtpBegin;
        protected System.Windows.Forms.Label label2;
        protected C1.Win.C1Input.C1DateEdit dtpEnd;

    }
}