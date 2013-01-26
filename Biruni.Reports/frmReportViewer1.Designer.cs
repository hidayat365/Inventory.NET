namespace Biruni.Reports
{
    partial class frmReportViewer1
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
            this._viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Visible = false;
            // 
            // _viewer
            // 
            this._viewer.ActiveViewIndex = -1;
            this._viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._viewer.DisplayGroupTree = false;
            this._viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._viewer.Location = new System.Drawing.Point(0, 39);
            this._viewer.Name = "_viewer";
            this._viewer.SelectionFormula = "";
            this._viewer.Size = new System.Drawing.Size(632, 327);
            this._viewer.TabIndex = 3;
            this._viewer.ViewTimeSelectionFormula = "";
            // 
            // frmReportViewer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Controls.Add(this._viewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "frmReportViewer1";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this._viewer, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _viewer;

    }
}
