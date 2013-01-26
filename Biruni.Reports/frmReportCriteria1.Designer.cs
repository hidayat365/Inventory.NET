namespace Biruni.Reports
{
    partial class frmReportCriteria1
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
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.c1DateEdit2 = new C1.Win.C1Input.C1DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(426, 39);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(128, 8);
            this.btnClose.Text = "&Cancel";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::Biruni.Reports.Properties.Resources.printer;
            this.btnSave.Size = new System.Drawing.Size(104, 24);
            this.btnSave.Text = "&Preview";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1DateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1DateEdit1.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateEdit1.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1DateEdit1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1DateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.LongDate;
            this.c1DateEdit1.Location = new System.Drawing.Point(108, 68);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(268, 19);
            this.c1DateEdit1.TabIndex = 41;
            this.c1DateEdit1.Tag = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Period Start";
            // 
            // c1DateEdit2
            // 
            this.c1DateEdit2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1DateEdit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1DateEdit2.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateEdit2.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1DateEdit2.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1DateEdit2.FormatType = C1.Win.C1Input.FormatTypeEnum.LongDate;
            this.c1DateEdit2.Location = new System.Drawing.Point(108, 92);
            this.c1DateEdit2.Name = "c1DateEdit2";
            this.c1DateEdit2.Size = new System.Drawing.Size(268, 19);
            this.c1DateEdit2.TabIndex = 43;
            this.c1DateEdit2.Tag = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Period End";
            // 
            // frmReportCriteria1
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(426, 143);
            this.Controls.Add(this.c1DateEdit2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1DateEdit1);
            this.Controls.Add(this.label3);
            this.Name = "frmReportCriteria1";
            this.Text = "Report Criteria";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.c1DateEdit1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.c1DateEdit2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1Input.C1DateEdit c1DateEdit2;
        private System.Windows.Forms.Label label1;
    }
}
