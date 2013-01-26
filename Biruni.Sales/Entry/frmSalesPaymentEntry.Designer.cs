namespace Biruni.Sales.Entry
{
    partial class frmSalesPaymentEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesPaymentEntry));
            this.dsCore1 = new Biruni.Shared.Data.dsCore();
            this.daOrders1 = new Biruni.Shared.Data.dsCoreTableAdapters.OrdersTableAdapter();
            this.daOrderDetails1 = new Biruni.Shared.Data.dsCoreTableAdapters.OrderDetailsTableAdapter();
            this.daCompanies1 = new Biruni.Shared.Data.dsCoreTableAdapters.CompaniesTableAdapter();
            this.daCurrencies1 = new Biruni.Shared.Data.dsCoreTableAdapters.CurrenciesTableAdapter();
            this.daItems1 = new Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter();
            this.c1Combo3 = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.dsCore2 = new Biruni.Shared.Data.dsCore();
            this.label4 = new System.Windows.Forms.Label();
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this._grid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1NumericEdit1 = new C1.Win.C1Input.C1NumericEdit();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarCode = new C1.Win.C1Input.C1TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.c1NumericEdit1);
            this.panel2.Controls.Add(this.c1Combo3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.c1TextBox2);
            this.panel2.Controls.Add(this.c1Combo1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.c1DateEdit1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.c1TextBox1);
            this.panel2.Controls.Add(this.c1Label1);
            this.panel2.Size = new System.Drawing.Size(792, 139);
            // 
            // btnPrint
            // 
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dsCore1
            // 
            this.dsCore1.DataSetName = "dsCore";
            this.dsCore1.Locale = new System.Globalization.CultureInfo("id-ID");
            this.dsCore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daOrders1
            // 
            this.daOrders1.ClearBeforeFill = true;
            // 
            // daOrderDetails1
            // 
            this.daOrderDetails1.ClearBeforeFill = true;
            // 
            // daCompanies1
            // 
            this.daCompanies1.ClearBeforeFill = true;
            // 
            // daCurrencies1
            // 
            this.daCurrencies1.ClearBeforeFill = true;
            // 
            // daItems1
            // 
            this.daItems1.ClearBeforeFill = true;
            // 
            // c1Combo3
            // 
            this.c1Combo3.AddItemSeparator = ';';
            this.c1Combo3.AlternatingRows = true;
            this.c1Combo3.Caption = "";
            this.c1Combo3.CaptionHeight = 17;
            this.c1Combo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo3.ColumnCaptionHeight = 17;
            this.c1Combo3.ColumnFooterHeight = 17;
            this.c1Combo3.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.c1Combo3.ContentHeight = 16;
            this.c1Combo3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCore1, "Orders.CurrencyID", true));
            this.c1Combo3.DataMember = "Currencies";
            this.c1Combo3.DataSource = this.dsCore1;
            this.c1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo3.DisplayMember = "Currencies.Name";
            this.c1Combo3.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo3.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo3.EditorHeight = 16;
            this.c1Combo3.ExtendRightColumn = true;
            this.c1Combo3.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo3.Images"))));
            this.c1Combo3.ItemHeight = 15;
            this.c1Combo3.Location = new System.Drawing.Point(487, 64);
            this.c1Combo3.MatchEntryTimeout = ((long)(2000));
            this.c1Combo3.MaxDropDownItems = ((short)(15));
            this.c1Combo3.MaxLength = 32767;
            this.c1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo3.Name = "c1Combo3";
            this.c1Combo3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo3.Size = new System.Drawing.Size(128, 22);
            this.c1Combo3.TabIndex = 94;
            this.c1Combo3.ValueMember = "Currencies.ID";
            this.c1Combo3.PropBag = resources.GetString("c1Combo3.PropBag");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Currency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Remarks";
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.Remarks", true));
            this.c1TextBox2.Location = new System.Drawing.Point(487, 18);
            this.c1TextBox2.Multiline = true;
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.c1TextBox2.Size = new System.Drawing.Size(268, 42);
            this.c1TextBox2.TabIndex = 91;
            this.c1TextBox2.Tag = null;
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.AlternatingRows = true;
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 17;
            this.c1Combo1.ColumnFooterHeight = 17;
            this.c1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.c1Combo1.ContentHeight = 16;
            this.c1Combo1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCore1, "Orders.CompanyID", true));
            this.c1Combo1.DataMember = "Companies";
            this.c1Combo1.DataSource = this.dsCore1;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.DisplayMember = "Companies.Name";
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 16;
            this.c1Combo1.ExtendRightColumn = true;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(119, 64);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(15));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(268, 22);
            this.c1Combo1.TabIndex = 90;
            this.c1Combo1.ValueMember = "Companies.ID";
            this.c1Combo1.SelectedValueChanged += new System.EventHandler(this.c1Combo1_SelectedValueChanged);
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // dsCore2
            // 
            this.dsCore2.DataSetName = "dsCore";
            this.dsCore2.Locale = new System.Globalization.CultureInfo("id-ID");
            this.dsCore2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Customer Name";
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
            this.c1DateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.OrderDate", true));
            this.c1DateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.LongDate;
            this.c1DateEdit1.Location = new System.Drawing.Point(119, 41);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(268, 19);
            this.c1DateEdit1.TabIndex = 84;
            this.c1DateEdit1.Tag = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Payment Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Payment Number";
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.OrderNo", true));
            this.c1TextBox1.Location = new System.Drawing.Point(119, 18);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(268, 19);
            this.c1TextBox1.TabIndex = 81;
            this.c1TextBox1.Tag = null;
            // 
            // _grid
            // 
            this._grid.AllowAddNew = true;
            this._grid.AllowDelete = true;
            this._grid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this._grid.ColumnInfo = resources.GetString("_grid.ColumnInfo");
            this._grid.DataMember = "Orders.FK_OrderDetails_Orders";
            this._grid.DataSource = this.dsCore1;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.ExtendLastCol = true;
            this._grid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this._grid.Location = new System.Drawing.Point(0, 178);
            this._grid.Name = "_grid";
            this._grid.NewRowWatermark = "New Data";
            this._grid.Rows.Count = 1;
            this._grid.Rows.DefaultSize = 20;
            this._grid.ShowErrors = true;
            this._grid.Size = new System.Drawing.Size(792, 268);
            this._grid.StyleInfo = resources.GetString("_grid.StyleInfo");
            this._grid.TabIndex = 8;
            this._grid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            // 
            // c1NumericEdit1
            // 
            // 
            // 
            // 
            this.c1NumericEdit1.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.c1NumericEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.OrderValue", true));
            this.c1NumericEdit1.DataType = typeof(double);
            this.c1NumericEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1NumericEdit1.Location = new System.Drawing.Point(621, 64);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Size = new System.Drawing.Size(133, 21);
            this.c1NumericEdit1.TabIndex = 95;
            this.c1NumericEdit1.Tag = null;
            // 
            // c1Label1
            // 
            this.c1Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1Label1.DataType = typeof(double);
            this.c1Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label1.ForeColor = System.Drawing.Color.Black;
            this.c1Label1.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1Label1.Location = new System.Drawing.Point(580, 22);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(136, 22);
            this.c1Label1.TabIndex = 96;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "c1Label1";
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.c1Label1.TextDetached = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtBarCode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 46);
            this.panel3.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Barcode Here";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(118, 7);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(347, 28);
            this.txtBarCode.TabIndex = 0;
            this.txtBarCode.Tag = null;
            this.txtBarCode.TextDetached = true;
            this.txtBarCode.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // frmSalesPaymentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this._grid);
            this.Name = "frmSalesPaymentEntry";
            this.Text = "Sales Payment Entry";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this._grid, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Biruni.Shared.Data.dsCore dsCore1;
        private Biruni.Shared.Data.dsCoreTableAdapters.OrdersTableAdapter daOrders1;
        private Biruni.Shared.Data.dsCoreTableAdapters.OrderDetailsTableAdapter daOrderDetails1;
        private Biruni.Shared.Data.dsCoreTableAdapters.CompaniesTableAdapter daCompanies1;
        private Biruni.Shared.Data.dsCoreTableAdapters.CurrenciesTableAdapter daCurrencies1;
        private Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter daItems1;
        private C1.Win.C1List.C1Combo c1Combo3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private C1.Win.C1List.C1Combo c1Combo1;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private Biruni.Shared.Data.dsCore dsCore2;
        protected C1.Win.C1FlexGrid.C1FlexGrid _grid;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit1;
        private C1.Win.C1Input.C1Label c1Label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Input.C1TextBox txtBarCode;
    }
}
