namespace Biruni.Sales.Entry
{
    partial class frmSalesOrderEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderEntry));
            this.dsCore1 = new Biruni.Shared.Data.dsCore();
            this.daOrders1 = new Biruni.Shared.Data.dsCoreTableAdapters.OrdersTableAdapter();
            this.daOrderDetails1 = new Biruni.Shared.Data.dsCoreTableAdapters.OrderDetailsTableAdapter();
            this.c1DateEdit2 = new C1.Win.C1Input.C1DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.c1Combo2 = new C1.Win.C1List.C1Combo();
            this.dsCore2 = new Biruni.Shared.Data.dsCore();
            this.daCompanies1 = new Biruni.Shared.Data.dsCoreTableAdapters.CompaniesTableAdapter();
            this.daItems1 = new Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter();
            this.daCurrencies1 = new Biruni.Shared.Data.dsCoreTableAdapters.CurrenciesTableAdapter();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1Combo3 = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.c1NumericEdit1 = new C1.Win.C1Input.C1NumericEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this._grid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarCode = new C1.Win.C1Input.C1TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
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
            this.panel2.Controls.Add(this.c1Combo1);
            this.panel2.Controls.Add(this.c1NumericEdit1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.c1Label1);
            this.panel2.Controls.Add(this.c1Combo3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.c1TextBox2);
            this.panel2.Controls.Add(this.c1Combo2);
            this.panel2.Controls.Add(this.c1DateEdit2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.c1DateEdit1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.c1TextBox1);
            this.panel2.Size = new System.Drawing.Size(792, 187);
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
            this.c1DateEdit2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.RequiredDate", true));
            this.c1DateEdit2.FormatType = C1.Win.C1Input.FormatTypeEnum.LongDate;
            this.c1DateEdit2.Location = new System.Drawing.Point(128, 62);
            this.c1DateEdit2.Name = "c1DateEdit2";
            this.c1DateEdit2.Size = new System.Drawing.Size(268, 19);
            this.c1DateEdit2.TabIndex = 59;
            this.c1DateEdit2.Tag = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Required Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Sales Quotation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 53;
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
            this.c1DateEdit1.Location = new System.Drawing.Point(128, 39);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(268, 19);
            this.c1DateEdit1.TabIndex = 52;
            this.c1DateEdit1.Tag = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Order Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Order Number";
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.OrderNo", true));
            this.c1TextBox1.Location = new System.Drawing.Point(128, 16);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(268, 19);
            this.c1TextBox1.TabIndex = 47;
            this.c1TextBox1.Tag = null;
            // 
            // c1Combo2
            // 
            this.c1Combo2.AddItemSeparator = ';';
            this.c1Combo2.AlternatingRows = true;
            this.c1Combo2.Caption = "";
            this.c1Combo2.CaptionHeight = 17;
            this.c1Combo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo2.ColumnCaptionHeight = 17;
            this.c1Combo2.ColumnFooterHeight = 17;
            this.c1Combo2.ContentHeight = 16;
            this.c1Combo2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCore1, "Orders.ParentID", true));
            this.c1Combo2.DataMember = "Orders";
            this.c1Combo2.DataSource = this.dsCore2;
            this.c1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo2.DisplayMember = "Orders.OrderNo";
            this.c1Combo2.DropDownWidth = 360;
            this.c1Combo2.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo2.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo2.EditorHeight = 16;
            this.c1Combo2.ExtendRightColumn = true;
            this.c1Combo2.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo2.Images"))));
            this.c1Combo2.ItemHeight = 15;
            this.c1Combo2.Location = new System.Drawing.Point(128, 85);
            this.c1Combo2.MatchEntryTimeout = ((long)(2000));
            this.c1Combo2.MaxDropDownItems = ((short)(15));
            this.c1Combo2.MaxLength = 32767;
            this.c1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo2.Name = "c1Combo2";
            this.c1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo2.Size = new System.Drawing.Size(268, 22);
            this.c1Combo2.TabIndex = 60;
            this.c1Combo2.ValueMember = "Orders.ID";
            this.c1Combo2.SelectedValueChanged += new System.EventHandler(this.c1Combo2_SelectedValueChanged);
            this.c1Combo2.PropBag = resources.GetString("c1Combo2.PropBag");
            // 
            // dsCore2
            // 
            this.dsCore2.DataSetName = "dsCore";
            this.dsCore2.Locale = new System.Globalization.CultureInfo("id-ID");
            this.dsCore2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daCompanies1
            // 
            this.daCompanies1.ClearBeforeFill = true;
            // 
            // daItems1
            // 
            this.daItems1.ClearBeforeFill = true;
            // 
            // daCurrencies1
            // 
            this.daCurrencies1.ClearBeforeFill = true;
            // 
            // c1Label1
            // 
            this.c1Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1Label1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.OrderValue", true));
            this.c1Label1.DataType = typeof(double);
            this.c1Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label1.ForeColor = System.Drawing.Color.Black;
            this.c1Label1.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1Label1.Location = new System.Drawing.Point(628, 66);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(136, 22);
            this.c1Label1.TabIndex = 80;
            this.c1Label1.Tag = null;
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.c1Combo3.Location = new System.Drawing.Point(496, 66);
            this.c1Combo3.MatchEntryTimeout = ((long)(2000));
            this.c1Combo3.MaxDropDownItems = ((short)(15));
            this.c1Combo3.MaxLength = 32767;
            this.c1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo3.Name = "c1Combo3";
            this.c1Combo3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo3.Size = new System.Drawing.Size(128, 22);
            this.c1Combo3.TabIndex = 79;
            this.c1Combo3.ValueMember = "Currencies.ID";
            this.c1Combo3.PropBag = resources.GetString("c1Combo3.PropBag");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Currency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Remarks";
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.Remarks", true));
            this.c1TextBox2.Location = new System.Drawing.Point(496, 16);
            this.c1TextBox2.Multiline = true;
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.c1TextBox2.Size = new System.Drawing.Size(268, 47);
            this.c1TextBox2.TabIndex = 76;
            this.c1TextBox2.Tag = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "Payment Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsCore1, "Orders.PaymentType", true));
            this.radioButton2.Location = new System.Drawing.Point(620, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 116;
            this.radioButton2.Text = "Credit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(549, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 115;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Orders.PaymentValue", true));
            this.c1NumericEdit1.DataType = typeof(double);
            this.c1NumericEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1NumericEdit1.Location = new System.Drawing.Point(549, 112);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Size = new System.Drawing.Size(215, 21);
            this.c1NumericEdit1.TabIndex = 119;
            this.c1NumericEdit1.Tag = null;
            this.c1NumericEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 118;
            this.label9.Text = "Payment Amount";
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
            this.c1Combo1.DropDownWidth = 320;
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 16;
            this.c1Combo1.ExtendRightColumn = true;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(128, 111);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(15));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(268, 22);
            this.c1Combo1.TabIndex = 120;
            this.c1Combo1.ValueMember = "Companies.ID";
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
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
            this._grid.Location = new System.Drawing.Point(0, 226);
            this._grid.Name = "_grid";
            this._grid.NewRowWatermark = "New Data";
            this._grid.Rows.Count = 1;
            this._grid.Rows.DefaultSize = 20;
            this._grid.ShowErrors = true;
            this._grid.Size = new System.Drawing.Size(792, 220);
            this._grid.StyleInfo = resources.GetString("_grid.StyleInfo");
            this._grid.TabIndex = 7;
            this._grid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtBarCode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 46);
            this.panel3.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Barcode Here";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(127, 7);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(347, 28);
            this.txtBarCode.TabIndex = 0;
            this.txtBarCode.Tag = null;
            this.txtBarCode.TextDetached = true;
            this.txtBarCode.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // frmSalesOrderEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this._grid);
            this.Name = "frmSalesOrderEntry";
            this.Text = "Sales Order Entry";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this._grid, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Biruni.Shared.Data.dsCore dsCore1;
        private Biruni.Shared.Data.dsCoreTableAdapters.OrdersTableAdapter daOrders1;
        private Biruni.Shared.Data.dsCoreTableAdapters.OrderDetailsTableAdapter daOrderDetails1;
        private C1.Win.C1Input.C1DateEdit c1DateEdit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1List.C1Combo c1Combo2;
        private Biruni.Shared.Data.dsCoreTableAdapters.CompaniesTableAdapter daCompanies1;
        private Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter daItems1;
        private Biruni.Shared.Data.dsCoreTableAdapters.CurrenciesTableAdapter daCurrencies1;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1List.C1Combo c1Combo3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private Biruni.Shared.Data.dsCore dsCore2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit1;
        private System.Windows.Forms.Label label9;
        private C1.Win.C1List.C1Combo c1Combo1;
        protected C1.Win.C1FlexGrid.C1FlexGrid _grid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private C1.Win.C1Input.C1TextBox txtBarCode;
    }
}
