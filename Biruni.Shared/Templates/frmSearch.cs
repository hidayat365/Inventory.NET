using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using C1.Win.C1TrueDBGrid;
using C1.Win.C1Input;
using Biruni.Shared;

namespace Biruni.Shared.Templates
{
    public class frmSearch : C1RibbonForm
    {
        protected GroupBox gbBottomSearch;
        protected C1TrueDBGrid _grid;
        protected C1Button btCloseSearch;
        protected string ModuleID = "ACC-00000";
        protected Panel panel1;
        protected Label label1;

        protected int sSearchID = -1;
        protected bool bSearchOK = false;
        protected bool bChecking = false;
        protected string sSearchCode = String.Empty;
        protected string sSearchDesc = String.Empty;
        protected DateTime sSearchDate = DateTime.Today;
        protected double sSearchValue = 0;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public frmSearch()
        {
            frmSearch_Helper(-1);
        }

        public frmSearch(int id)
        {
            frmSearch_Helper(id);
        }

        private void frmSearch_Helper(int id)
        {
            InitializeComponent();
            AppHelper.ApplyFormStyle(this);
            AppHelper.ApplyVisualStyle(this.Controls);
        }

        protected virtual void SaveValue()
        {
            sSearchID = -1;
            sSearchCode = String.Empty;
            sSearchDesc = String.Empty;
            bSearchOK = false;
        }

        private void _grid_DoubleClick(object sender, EventArgs e)
        {
            SaveValue();
            Close();
        }

        private void _grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                bSearchOK = false;
                Close();
            }

            if (e.KeyChar == (char)Keys.Return)
            {
                SaveValue();
                Close();
            }
        }

        public int SelectedID
        {
            get { return sSearchID; }
        }

        public string SelectedCode
        {
            get { return sSearchCode; }
        }

        public string SelectedDesc
        {
            get { return sSearchDesc; }
        }

        public DateTime SelectedDate
        {
            get { return sSearchDate; }
        }

        public double SelectedValue
        {
            get { return sSearchValue; }
        }

        public bool SelectedOK
        {
            get { return bSearchOK; }
        }

        /// <summary>
        /// Clean up any resources being used
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this._grid = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.gbBottomSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCloseSearch = new C1.Win.C1Input.C1Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.gbBottomSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _grid
            // 
            this._grid.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this._grid.AllowUpdate = false;
            this._grid.AllowUpdateOnBlur = false;
            this._grid.AlternatingRows = true;
            this._grid.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._grid.Caption = "Daftar XXXXXX";
            this._grid.CaptionHeight = 17;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.ExpandColor = System.Drawing.Color.MediumBlue;
            this._grid.ExtendRightColumn = true;
            this._grid.FilterBar = true;
            this._grid.GroupByCaption = "Drag a column header here to group by that column";
            this._grid.Images.Add(((System.Drawing.Image)(resources.GetObject("_grid.Images"))));
            this._grid.Location = new System.Drawing.Point(0, 0);
            this._grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this._grid.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this._grid.Name = "_grid";
            this._grid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this._grid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this._grid.PreviewInfo.ZoomFactor = 75;
            this._grid.RecordSelectors = false;
            this._grid.RowHeight = 15;
            this._grid.Size = new System.Drawing.Size(590, 402);
            this._grid.TabIndex = 0;
            this._grid.Text = "c1TrueDBGrid1";
            this._grid.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this._grid.DoubleClick += new System.EventHandler(this._grid_DoubleClick);
            this._grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._grid_KeyPress);
            this._grid.PropBag = resources.GetString("_grid.PropBag");
            // 
            // gbBottomSearch
            // 
            this.gbBottomSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.gbBottomSearch.Controls.Add(this.label1);
            this.gbBottomSearch.Controls.Add(this.btCloseSearch);
            this.gbBottomSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbBottomSearch.Location = new System.Drawing.Point(0, 402);
            this.gbBottomSearch.Name = "gbBottomSearch";
            this.gbBottomSearch.Size = new System.Drawing.Size(590, 42);
            this.gbBottomSearch.TabIndex = 1;
            this.gbBottomSearch.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "*) Double click an itemto make your selection";
            // 
            // btCloseSearch
            // 
            this.btCloseSearch.Location = new System.Drawing.Point(496, 12);
            this.btCloseSearch.Name = "btCloseSearch";
            this.btCloseSearch.Size = new System.Drawing.Size(80, 24);
            this.btCloseSearch.TabIndex = 2;
            this.btCloseSearch.Text = "&Close";
            this.btCloseSearch.UseVisualStyleBackColor = true;
            this.btCloseSearch.Click += new System.EventHandler(this.btCloseSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._grid);
            this.panel1.Controls.Add(this.gbBottomSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 446);
            this.panel1.TabIndex = 0;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template Search";
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.gbBottomSearch.ResumeLayout(false);
            this.gbBottomSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btCloseSearch_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}