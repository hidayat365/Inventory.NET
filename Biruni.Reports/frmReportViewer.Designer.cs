namespace Biruni.Reports
{
    partial class frmReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewer));
            this._preview = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._preview.PreviewPane)).BeginInit();
            this._preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Visible = false;
            // 
            // _preview
            // 
            this._preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this._preview.ImageSet = C1.Win.C1Preview.ImageSetEnum.XP3;
            this._preview.Location = new System.Drawing.Point(0, 39);
            this._preview.Name = "_preview";
            // 
            // _preview.OutlineView
            // 
            this._preview.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._preview.PreviewOutlineView.Location = new System.Drawing.Point(0, 0);
            this._preview.PreviewOutlineView.Name = "OutlineView";
            this._preview.PreviewOutlineView.Size = new System.Drawing.Size(165, 427);
            this._preview.PreviewOutlineView.TabIndex = 0;
            // 
            // _preview.PreviewPane
            // 
            this._preview.PreviewPane.IntegrateExternalTools = true;
            this._preview.PreviewPane.TabIndex = 0;
            // 
            // _preview.PreviewTextSearchPanel
            // 
            this._preview.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._preview.PreviewTextSearchPanel.Location = new System.Drawing.Point(530, 0);
            this._preview.PreviewTextSearchPanel.MinimumSize = new System.Drawing.Size(200, 240);
            this._preview.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel";
            this._preview.PreviewTextSearchPanel.Size = new System.Drawing.Size(200, 453);
            this._preview.PreviewTextSearchPanel.TabIndex = 0;
            this._preview.PreviewTextSearchPanel.Visible = false;
            // 
            // _preview.ThumbnailView
            // 
            this._preview.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._preview.PreviewThumbnailView.Location = new System.Drawing.Point(0, 0);
            this._preview.PreviewThumbnailView.Name = "ThumbnailView";
            this._preview.PreviewThumbnailView.Size = new System.Drawing.Size(165, 254);
            this._preview.PreviewThumbnailView.TabIndex = 0;
            this._preview.PreviewThumbnailView.UseImageAsThumbnail = false;
            this._preview.Size = new System.Drawing.Size(632, 327);
            this._preview.TabIndex = 3;
            this._preview.Text = "c1PrintPreviewControl1";
            // 
            // 
            // 
            this._preview.ToolBars.File.Open.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Open.Image")));
            this._preview.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.File.Open.Name = "btnFileOpen";
            this._preview.ToolBars.File.Open.Size = new System.Drawing.Size(32, 22);
            this._preview.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen";
            this._preview.ToolBars.File.Open.ToolTipText = "Open File";
            // 
            // 
            // 
            this._preview.ToolBars.File.PageSetup.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.PageSetup.Image")));
            this._preview.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.File.PageSetup.Name = "btnPageSetup";
            this._preview.ToolBars.File.PageSetup.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup";
            this._preview.ToolBars.File.PageSetup.ToolTipText = "Page Setup";
            // 
            // 
            // 
            this._preview.ToolBars.File.Print.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Print.Image")));
            this._preview.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.File.Print.Name = "btnPrint";
            this._preview.ToolBars.File.Print.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print";
            this._preview.ToolBars.File.Print.ToolTipText = "Print";
            // 
            // 
            // 
            this._preview.ToolBars.File.Reflow.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Reflow.Image")));
            this._preview.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.File.Reflow.Name = "btnReflow";
            this._preview.ToolBars.File.Reflow.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow";
            this._preview.ToolBars.File.Reflow.ToolTipText = "Reflow";
            // 
            // 
            // 
            this._preview.ToolBars.File.Save.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Save.Image")));
            this._preview.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.File.Save.Name = "btnFileSave";
            this._preview.ToolBars.File.Save.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave";
            this._preview.ToolBars.File.Save.ToolTipText = "Save File";
            // 
            // 
            // 
            this._preview.ToolBars.Navigation.GoFirst.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image")));
            this._preview.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Navigation.GoFirst.Name = "btnGoFirst";
            this._preview.ToolBars.Navigation.GoFirst.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst";
            this._preview.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page";
            // 
            // 
            // 
            this._preview.ToolBars.Navigation.GoLast.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image")));
            this._preview.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Navigation.GoLast.Name = "btnGoLast";
            this._preview.ToolBars.Navigation.GoLast.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast";
            this._preview.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page";
            // 
            // 
            // 
            this._preview.ToolBars.Navigation.GoNext.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image")));
            this._preview.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Navigation.GoNext.Name = "btnGoNext";
            this._preview.ToolBars.Navigation.GoNext.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext";
            this._preview.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page";
            // 
            // 
            // 
            this._preview.ToolBars.Navigation.GoPrev.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image")));
            this._preview.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Navigation.GoPrev.Name = "btnGoPrev";
            this._preview.ToolBars.Navigation.GoPrev.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev";
            this._preview.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page";
            // 
            // 
            // 
            this._preview.ToolBars.Navigation.HistoryNext.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image")));
            this._preview.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext";
            this._preview.ToolBars.Navigation.HistoryNext.Size = new System.Drawing.Size(32, 20);
            this._preview.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext";
            this._preview.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View";
            // 
            // 
            // 
            this._preview.ToolBars.Navigation.HistoryPrev.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image")));
            this._preview.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev";
            this._preview.ToolBars.Navigation.HistoryPrev.Size = new System.Drawing.Size(32, 22);
            this._preview.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev";
            this._preview.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View";
            // 
            // 
            // 
            this._preview.ToolBars.Navigation.LblOfPages.Name = "lblOfPages";
            this._preview.ToolBars.Navigation.LblOfPages.Size = new System.Drawing.Size(26, 22);
            this._preview.ToolBars.Navigation.LblOfPages.Tag = "C1PreviewActionEnum.GoPageCount";
            this._preview.ToolBars.Navigation.LblOfPages.Text = "of 0";
            // 
            // 
            // 
            this._preview.ToolBars.Navigation.LblPage.Name = "lblPage";
            this._preview.ToolBars.Navigation.LblPage.Size = new System.Drawing.Size(31, 22);
            this._preview.ToolBars.Navigation.LblPage.Tag = "C1PreviewActionEnum.GoPageLabel";
            this._preview.ToolBars.Navigation.LblPage.Text = "Page";
            this._preview.ToolBars.Navigation.ToolTipPageNo = null;
            // 
            // 
            // 
            this._preview.ToolBars.Page.Continuous.Checked = true;
            this._preview.ToolBars.Page.Continuous.CheckState = System.Windows.Forms.CheckState.Checked;
            this._preview.ToolBars.Page.Continuous.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Page.Continuous.Image")));
            this._preview.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Page.Continuous.Name = "btnPageContinuous";
            this._preview.ToolBars.Page.Continuous.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous";
            this._preview.ToolBars.Page.Continuous.ToolTipText = "Continuous View";
            // 
            // 
            // 
            this._preview.ToolBars.Page.Facing.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Page.Facing.Image")));
            this._preview.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Page.Facing.Name = "btnPageFacing";
            this._preview.ToolBars.Page.Facing.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing";
            this._preview.ToolBars.Page.Facing.ToolTipText = "Pages Facing View";
            // 
            // 
            // 
            this._preview.ToolBars.Page.FacingContinuous.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image")));
            this._preview.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous";
            this._preview.ToolBars.Page.FacingContinuous.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous";
            this._preview.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View";
            // 
            // 
            // 
            this._preview.ToolBars.Page.Single.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Page.Single.Image")));
            this._preview.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Page.Single.Name = "btnPageSingle";
            this._preview.ToolBars.Page.Single.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle";
            this._preview.ToolBars.Page.Single.ToolTipText = "Single Page View";
            // 
            // 
            // 
            this._preview.ToolBars.Text.Find.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.Find.Image")));
            this._preview.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Text.Find.Name = "btnFind";
            this._preview.ToolBars.Text.Find.Size = new System.Drawing.Size(23, 20);
            this._preview.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find";
            this._preview.ToolBars.Text.Find.ToolTipText = "Find Text";
            // 
            // 
            // 
            this._preview.ToolBars.Text.Hand.Checked = true;
            this._preview.ToolBars.Text.Hand.CheckState = System.Windows.Forms.CheckState.Checked;
            this._preview.ToolBars.Text.Hand.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.Hand.Image")));
            this._preview.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Text.Hand.Name = "btnHandTool";
            this._preview.ToolBars.Text.Hand.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool";
            this._preview.ToolBars.Text.Hand.ToolTipText = "Hand Tool";
            // 
            // 
            // 
            this._preview.ToolBars.Text.SelectText.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.SelectText.Image")));
            this._preview.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Text.SelectText.Name = "btnSelectTextTool";
            this._preview.ToolBars.Text.SelectText.Size = new System.Drawing.Size(23, 20);
            this._preview.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool";
            this._preview.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool";
            // 
            // 
            // 
            this._preview.ToolBars.Zoom.DropZoomFactor.Name = "dropZoomFactor";
            this._preview.ToolBars.Zoom.DropZoomFactor.Size = new System.Drawing.Size(13, 22);
            this._preview.ToolBars.Zoom.DropZoomFactor.Tag = "C1PreviewActionEnum.ZoomFactor";
            this._preview.ToolBars.Zoom.ToolTipZoomFactor = null;
            // 
            // 
            // 
            this._preview.ToolBars.Zoom.ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image")));
            this._preview.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn";
            this._preview.ToolBars.Zoom.ZoomIn.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn";
            this._preview.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In";
            // 
            // 
            // 
            this._preview.ToolBars.Zoom.ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image")));
            this._preview.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut";
            this._preview.ToolBars.Zoom.ZoomOut.Size = new System.Drawing.Size(23, 22);
            this._preview.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut";
            this._preview.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out";
            // 
            // 
            // 
            this._preview.ToolBars.Zoom.ZoomTool.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image")));
            this._preview.ToolBars.Zoom.ZoomTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._preview.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool";
            this._preview.ToolBars.Zoom.ZoomTool.Size = new System.Drawing.Size(32, 22);
            this._preview.ToolBars.Zoom.ZoomTool.Tag = "C1PreviewActionEnum.ZoomInTool";
            this._preview.ToolBars.Zoom.ZoomTool.ToolTipText = "Zoom In Tool";
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Controls.Add(this._preview);
            this.Name = "frmReportViewer";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this._preview, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._preview.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._preview)).EndInit();
            this._preview.ResumeLayout(false);
            this._preview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl _preview;
    }
}
