namespace Biruni.Master.Entry
{
    partial class frmItemEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemEntry));
            this.dsCore1 = new Biruni.Shared.Data.dsCore();
            this.daItems1 = new Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c1TextBox4 = new C1.Win.C1Input.C1TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c1TextBox5 = new C1.Win.C1Input.C1TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.c1TextBox6 = new C1.Win.C1Input.C1TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.c1TextBox7 = new C1.Win.C1Input.C1TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.c1NumericEdit1 = new C1.Win.C1Input.C1NumericEdit();
            this.c1NumericEdit2 = new C1.Win.C1Input.C1NumericEdit();
            this.c1NumericEdit3 = new C1.Win.C1Input.C1NumericEdit();
            this.c1NumericEdit4 = new C1.Win.C1Input.C1NumericEdit();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.c1Combo2 = new C1.Win.C1List.C1Combo();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.daItemCategories1 = new Biruni.Shared.Data.dsCoreTableAdapters.ItemCategoriesTableAdapter();
            this.daUnitMeasures1 = new Biruni.Shared.Data.dsCoreTableAdapters.UnitMeasuresTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.c1NumericEdit5 = new C1.Win.C1Input.C1NumericEdit();
            this.daCompanies1 = new Biruni.Shared.Data.dsCoreTableAdapters.CompaniesTableAdapter();
            this.c1Combo3 = new C1.Win.C1List.C1Combo();
            this.label15 = new System.Windows.Forms.Label();
            this.c1NumericEdit6 = new C1.Win.C1Input.C1NumericEdit();
            this.c1BarCode1 = new C1.Win.C1BarCode.C1BarCode();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Item Code (Barcode)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsCore1, "Items.Active", true));
            this.checkBox1.Location = new System.Drawing.Point(149, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.Name", true));
            this.c1TextBox2.Location = new System.Drawing.Point(149, 111);
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Size = new System.Drawing.Size(456, 19);
            this.c1TextBox2.TabIndex = 10;
            this.c1TextBox2.Tag = null;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.Code", true));
            this.c1TextBox1.Location = new System.Drawing.Point(149, 61);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(150, 19);
            this.c1TextBox1.TabIndex = 5;
            this.c1TextBox1.Tag = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vendor Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Brand Name";
            // 
            // c1TextBox4
            // 
            this.c1TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.BrandName", true));
            this.c1TextBox4.Location = new System.Drawing.Point(149, 162);
            this.c1TextBox4.Name = "c1TextBox4";
            this.c1TextBox4.Size = new System.Drawing.Size(456, 19);
            this.c1TextBox4.TabIndex = 16;
            this.c1TextBox4.Tag = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Brand Type";
            // 
            // c1TextBox5
            // 
            this.c1TextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.BrandType", true));
            this.c1TextBox5.Location = new System.Drawing.Point(149, 186);
            this.c1TextBox5.Name = "c1TextBox5";
            this.c1TextBox5.Size = new System.Drawing.Size(456, 19);
            this.c1TextBox5.TabIndex = 18;
            this.c1TextBox5.Tag = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Specification";
            // 
            // c1TextBox6
            // 
            this.c1TextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.Specification", true));
            this.c1TextBox6.Location = new System.Drawing.Point(149, 210);
            this.c1TextBox6.Multiline = true;
            this.c1TextBox6.Name = "c1TextBox6";
            this.c1TextBox6.Size = new System.Drawing.Size(456, 60);
            this.c1TextBox6.TabIndex = 20;
            this.c1TextBox6.Tag = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dimension";
            // 
            // c1TextBox7
            // 
            this.c1TextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.Dimension", true));
            this.c1TextBox7.Location = new System.Drawing.Point(149, 274);
            this.c1TextBox7.Name = "c1TextBox7";
            this.c1TextBox7.Size = new System.Drawing.Size(456, 19);
            this.c1TextBox7.TabIndex = 22;
            this.c1TextBox7.Tag = null;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsCore1, "Items.Inventoried", true));
            this.checkBox2.Location = new System.Drawing.Point(217, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Inventoried";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1NumericEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1NumericEdit1.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.c1NumericEdit1.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit1.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.BasePrice", true));
            this.c1NumericEdit1.DataType = typeof(double);
            this.c1NumericEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1NumericEdit1.Location = new System.Drawing.Point(149, 297);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Size = new System.Drawing.Size(160, 19);
            this.c1NumericEdit1.TabIndex = 25;
            this.c1NumericEdit1.Tag = null;
            this.c1NumericEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // c1NumericEdit2
            // 
            this.c1NumericEdit2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1NumericEdit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1NumericEdit2.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.c1NumericEdit2.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit2.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.SellingPrice", true));
            this.c1NumericEdit2.DataType = typeof(double);
            this.c1NumericEdit2.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1NumericEdit2.Location = new System.Drawing.Point(445, 297);
            this.c1NumericEdit2.Name = "c1NumericEdit2";
            this.c1NumericEdit2.Size = new System.Drawing.Size(160, 19);
            this.c1NumericEdit2.TabIndex = 26;
            this.c1NumericEdit2.Tag = null;
            this.c1NumericEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // c1NumericEdit3
            // 
            this.c1NumericEdit3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1NumericEdit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1NumericEdit3.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.c1NumericEdit3.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit3.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.QuantityMin", true));
            this.c1NumericEdit3.DataType = typeof(double);
            this.c1NumericEdit3.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1NumericEdit3.Location = new System.Drawing.Point(149, 320);
            this.c1NumericEdit3.Name = "c1NumericEdit3";
            this.c1NumericEdit3.Size = new System.Drawing.Size(160, 19);
            this.c1NumericEdit3.TabIndex = 27;
            this.c1NumericEdit3.Tag = null;
            this.c1NumericEdit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // c1NumericEdit4
            // 
            this.c1NumericEdit4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1NumericEdit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1NumericEdit4.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.c1NumericEdit4.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit4.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.QuantityMax", true));
            this.c1NumericEdit4.DataType = typeof(double);
            this.c1NumericEdit4.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1NumericEdit4.Location = new System.Drawing.Point(446, 320);
            this.c1NumericEdit4.Name = "c1NumericEdit4";
            this.c1NumericEdit4.Size = new System.Drawing.Size(160, 19);
            this.c1NumericEdit4.TabIndex = 28;
            this.c1NumericEdit4.Tag = null;
            this.c1NumericEdit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.c1Combo1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCore1, "Items.MeasureID", true));
            this.c1Combo1.DataMember = "UnitMeasures";
            this.c1Combo1.DataSource = this.dsCore1;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.DisplayMember = "UnitMeasures.Name";
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 16;
            this.c1Combo1.ExtendRightColumn = true;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(149, 366);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(15));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(256, 22);
            this.c1Combo1.TabIndex = 29;
            this.c1Combo1.ValueMember = "UnitMeasures.ID";
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
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
            this.c1Combo2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.c1Combo2.ContentHeight = 16;
            this.c1Combo2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCore1, "Items.CategoryID", true));
            this.c1Combo2.DataMember = "ItemCategories";
            this.c1Combo2.DataSource = this.dsCore1;
            this.c1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo2.DisplayMember = "ItemCategories.Name";
            this.c1Combo2.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo2.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo2.EditorHeight = 16;
            this.c1Combo2.ExtendRightColumn = true;
            this.c1Combo2.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo2.Images"))));
            this.c1Combo2.ItemHeight = 15;
            this.c1Combo2.Location = new System.Drawing.Point(149, 392);
            this.c1Combo2.MatchEntryTimeout = ((long)(2000));
            this.c1Combo2.MaxDropDownItems = ((short)(15));
            this.c1Combo2.MaxLength = 32767;
            this.c1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo2.Name = "c1Combo2";
            this.c1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo2.Size = new System.Drawing.Size(256, 22);
            this.c1Combo2.TabIndex = 30;
            this.c1Combo2.ValueMember = "ItemCategories.ID";
            this.c1Combo2.PropBag = resources.GetString("c1Combo2.PropBag");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Base Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Selling Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Quantity Min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Quantity Max";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Unit of Measure";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Item Category";
            // 
            // daItemCategories1
            // 
            this.daItemCategories1.ClearBeforeFill = true;
            // 
            // daUnitMeasures1
            // 
            this.daUnitMeasures1.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Expiry In Days";
            // 
            // c1NumericEdit5
            // 
            this.c1NumericEdit5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1NumericEdit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1NumericEdit5.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.c1NumericEdit5.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit5.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.ExpiryInDays", true));
            this.c1NumericEdit5.DataType = typeof(int);
            this.c1NumericEdit5.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1NumericEdit5.Location = new System.Drawing.Point(149, 343);
            this.c1NumericEdit5.Name = "c1NumericEdit5";
            this.c1NumericEdit5.Size = new System.Drawing.Size(160, 19);
            this.c1NumericEdit5.TabIndex = 37;
            this.c1NumericEdit5.Tag = null;
            this.c1NumericEdit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // daCompanies1
            // 
            this.daCompanies1.ClearBeforeFill = true;
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
            this.c1Combo3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCore1, "Items.CompanyID", true));
            this.c1Combo3.DataMember = "Companies";
            this.c1Combo3.DataSource = this.dsCore1;
            this.c1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo3.DisplayMember = "Companies.Name";
            this.c1Combo3.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo3.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo3.EditorHeight = 16;
            this.c1Combo3.ExtendRightColumn = true;
            this.c1Combo3.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo3.Images"))));
            this.c1Combo3.ItemHeight = 15;
            this.c1Combo3.Location = new System.Drawing.Point(149, 135);
            this.c1Combo3.MatchEntryTimeout = ((long)(2000));
            this.c1Combo3.MaxDropDownItems = ((short)(15));
            this.c1Combo3.MaxLength = 32767;
            this.c1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo3.Name = "c1Combo3";
            this.c1Combo3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo3.Size = new System.Drawing.Size(456, 22);
            this.c1Combo3.TabIndex = 70;
            this.c1Combo3.ValueMember = "Companies.ID";
            this.c1Combo3.PropBag = resources.GetString("c1Combo3.PropBag");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 72;
            this.label15.Text = "Qty/Carton";
            // 
            // c1NumericEdit6
            // 
            this.c1NumericEdit6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1NumericEdit6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1NumericEdit6.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.c1NumericEdit6.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit6.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1NumericEdit6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Items.QuantityCarton", true));
            this.c1NumericEdit6.DataType = typeof(double);
            this.c1NumericEdit6.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber;
            this.c1NumericEdit6.Location = new System.Drawing.Point(445, 343);
            this.c1NumericEdit6.Name = "c1NumericEdit6";
            this.c1NumericEdit6.Size = new System.Drawing.Size(160, 19);
            this.c1NumericEdit6.TabIndex = 71;
            this.c1NumericEdit6.Tag = null;
            this.c1NumericEdit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // c1BarCode1
            // 
            this.c1BarCode1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCore1, "Items.Code", true));
            this.c1BarCode1.Location = new System.Drawing.Point(407, 61);
            this.c1BarCode1.Name = "c1BarCode1";
            this.c1BarCode1.ShowText = true;
            this.c1BarCode1.Size = new System.Drawing.Size(198, 44);
            this.c1BarCode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.c1BarCode1.TabIndex = 73;
            this.c1BarCode1.Text = "c1BarCode1";
            // 
            // frmItemEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 434);
            this.Controls.Add(this.c1BarCode1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.c1NumericEdit6);
            this.Controls.Add(this.c1Combo3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.c1NumericEdit5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.c1Combo2);
            this.Controls.Add(this.c1Combo1);
            this.Controls.Add(this.c1NumericEdit4);
            this.Controls.Add(this.c1NumericEdit3);
            this.Controls.Add(this.c1NumericEdit2);
            this.Controls.Add(this.c1NumericEdit1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c1TextBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.c1TextBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c1TextBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c1TextBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.c1TextBox2);
            this.Controls.Add(this.c1TextBox1);
            this.Name = "frmItemEntry";
            this.Text = "Item Entry";
            this.Controls.SetChildIndex(this.c1TextBox1, 0);
            this.Controls.SetChildIndex(this.c1TextBox2, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.c1TextBox4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.c1TextBox5, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.c1TextBox6, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.c1TextBox7, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.checkBox2, 0);
            this.Controls.SetChildIndex(this.c1NumericEdit1, 0);
            this.Controls.SetChildIndex(this.c1NumericEdit2, 0);
            this.Controls.SetChildIndex(this.c1NumericEdit3, 0);
            this.Controls.SetChildIndex(this.c1NumericEdit4, 0);
            this.Controls.SetChildIndex(this.c1Combo1, 0);
            this.Controls.SetChildIndex(this.c1Combo2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.c1NumericEdit5, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.c1Combo3, 0);
            this.Controls.SetChildIndex(this.c1NumericEdit6, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.c1BarCode1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Biruni.Shared.Data.dsCore dsCore1;
        private Biruni.Shared.Data.dsCoreTableAdapters.ItemsTableAdapter daItems1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1Input.C1TextBox c1TextBox4;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1Input.C1TextBox c1TextBox5;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Input.C1TextBox c1TextBox6;
        private System.Windows.Forms.Label label7;
        private C1.Win.C1Input.C1TextBox c1TextBox7;
        private System.Windows.Forms.CheckBox checkBox2;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit1;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit2;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit3;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit4;
        private C1.Win.C1List.C1Combo c1Combo1;
        private C1.Win.C1List.C1Combo c1Combo2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Biruni.Shared.Data.dsCoreTableAdapters.ItemCategoriesTableAdapter daItemCategories1;
        private Biruni.Shared.Data.dsCoreTableAdapters.UnitMeasuresTableAdapter daUnitMeasures1;
        private System.Windows.Forms.Label label14;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit5;
        private Biruni.Shared.Data.dsCoreTableAdapters.CompaniesTableAdapter daCompanies1;
        private C1.Win.C1List.C1Combo c1Combo3;
        private System.Windows.Forms.Label label15;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit6;
        private C1.Win.C1BarCode.C1BarCode c1BarCode1;
    }
}
