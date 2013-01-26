namespace Biruni.Reports
{
    partial class frmReportCriteria2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportCriteria2));
            this.label3 = new System.Windows.Forms.Label();
            this.daItems = new Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter();
            this.dsCore1 = new Biruni.Shared.Data.dsCore();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Select Item/Product";
            // 
            // daItems
            // 
            this.daItems.ClearBeforeFill = true;
            // 
            // dsCore1
            // 
            this.dsCore1.DataSetName = "dsCore";
            this.dsCore1.Locale = new System.Globalization.CultureInfo("id-ID");
            this.dsCore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 17;
            this.c1Combo1.ColumnFooterHeight = 17;
            this.c1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.c1Combo1.ContentHeight = 16;
            this.c1Combo1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCore1, "Items.ID", true));
            this.c1Combo1.DataMember = "Items";
            this.c1Combo1.DataSource = this.dsCore1;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.DisplayMember = "Items.Name";
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 16;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(136, 68);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(248, 22);
            this.c1Combo1.TabIndex = 41;
            this.c1Combo1.ValueMember = "Items.ID";
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // frmReportCriteria2
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(426, 143);
            this.Controls.Add(this.c1Combo1);
            this.Controls.Add(this.label3);
            this.Name = "frmReportCriteria2";
            this.Text = "Report Criteria";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.c1Combo1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter daItems;
        private Biruni.Shared.Data.dsCore dsCore1;
        private C1.Win.C1List.C1Combo c1Combo1;
    }
}
