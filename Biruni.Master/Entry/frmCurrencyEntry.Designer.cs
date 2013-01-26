namespace Biruni.Master.Entry
{
    partial class frmCurrencyEntry
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
            this.dsCore1 = new Biruni.Shared.Data.dsCore();
            this.daCurrencies1 = new Biruni.Shared.Data.dsCoreTableAdapters.CurrenciesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(419, 39);
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
            // daCurrencies1
            // 
            this.daCurrencies1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Currency Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Currency Code";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsCore1, "Currencies.Active", true));
            this.checkBox1.Location = new System.Drawing.Point(244, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Currencies.Name", true));
            this.c1TextBox2.Location = new System.Drawing.Point(132, 84);
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Size = new System.Drawing.Size(256, 19);
            this.c1TextBox2.TabIndex = 12;
            this.c1TextBox2.Tag = null;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCore1, "Currencies.Code", true));
            this.c1TextBox1.Location = new System.Drawing.Point(132, 60);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(100, 19);
            this.c1TextBox1.TabIndex = 9;
            this.c1TextBox1.Tag = null;
            // 
            // frmCurrencyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(419, 124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.c1TextBox2);
            this.Controls.Add(this.c1TextBox1);
            this.Name = "frmCurrencyEntry";
            this.Text = "Currency Entry";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.c1TextBox1, 0);
            this.Controls.SetChildIndex(this.c1TextBox2, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Biruni.Shared.Data.dsCore dsCore1;
        private Biruni.Shared.Data.dsCoreTableAdapters.CurrenciesTableAdapter daCurrencies1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
    }
}
