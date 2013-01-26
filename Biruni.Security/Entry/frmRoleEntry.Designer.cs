namespace Biruni.Security.Entry
{
    partial class frmRoleEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoleEntry));
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkCreate = new System.Windows.Forms.CheckBox();
            this.chkRead = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.dsSecurity1 = new Biruni.Shared.Data.dsSecurity();
            this.daRoles = new Biruni.Shared.Data.dsSecurityTableAdapters.RolesTableAdapter();
            this.daApplications = new Biruni.Shared.Data.dsSecurityTableAdapters.ApplicationsTableAdapter();
            this.daApplicationRoles = new Biruni.Shared.Data.dsSecurityTableAdapters.ApplicationRolesTableAdapter();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecurity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(681, 39);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(604, 56);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(71, 17);
            this.chkDelete.TabIndex = 16;
            this.chkDelete.Text = "&Delete All";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Location = new System.Drawing.Point(524, 56);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(75, 17);
            this.chkUpdate.TabIndex = 15;
            this.chkUpdate.Text = "&Update All";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // chkCreate
            // 
            this.chkCreate.AutoSize = true;
            this.chkCreate.Location = new System.Drawing.Point(444, 56);
            this.chkCreate.Name = "chkCreate";
            this.chkCreate.Size = new System.Drawing.Size(73, 17);
            this.chkCreate.TabIndex = 14;
            this.chkCreate.Text = "&Create All";
            this.chkCreate.UseVisualStyleBackColor = true;
            this.chkCreate.CheckedChanged += new System.EventHandler(this.chkCreate_CheckedChanged);
            // 
            // chkRead
            // 
            this.chkRead.AutoSize = true;
            this.chkRead.Location = new System.Drawing.Point(372, 56);
            this.chkRead.Name = "chkRead";
            this.chkRead.Size = new System.Drawing.Size(65, 17);
            this.chkRead.TabIndex = 13;
            this.chkRead.Text = "&Read All";
            this.chkRead.UseVisualStyleBackColor = true;
            this.chkRead.CheckedChanged += new System.EventHandler(this.chkRead_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Role Name";
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSecurity1, "Roles.Name", true));
            this.c1TextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TextBox1.Location = new System.Drawing.Point(76, 52);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(200, 19);
            this.c1TextBox1.TabIndex = 10;
            this.c1TextBox1.Tag = null;
            this.c1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // dsSecurity1
            // 
            this.dsSecurity1.DataSetName = "dsSecurity";
            this.dsSecurity1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daRoles
            // 
            this.daRoles.ClearBeforeFill = true;
            // 
            // daApplications
            // 
            this.daApplications.ClearBeforeFill = true;
            // 
            // daApplicationRoles
            // 
            this.daApplicationRoles.ClearBeforeFill = true;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataMember = "Roles.FK_ApplicationRoles_Applications";
            this.c1FlexGrid1.DataSource = this.dsSecurity1;
            this.c1FlexGrid1.ExtendLastCol = true;
            this.c1FlexGrid1.Location = new System.Drawing.Point(10, 80);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 20;
            this.c1FlexGrid1.Size = new System.Drawing.Size(662, 326);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 12;
            this.c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSecurity1, "Roles.Active", true));
            this.checkBox1.Location = new System.Drawing.Point(280, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmRoleEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 418);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.chkUpdate);
            this.Controls.Add(this.chkCreate);
            this.Controls.Add(this.chkRead);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1TextBox1);
            this.Name = "frmRoleEntry";
            this.Text = "Application Role Entry";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.c1TextBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.c1FlexGrid1, 0);
            this.Controls.SetChildIndex(this.chkRead, 0);
            this.Controls.SetChildIndex(this.chkCreate, 0);
            this.Controls.SetChildIndex(this.chkUpdate, 0);
            this.Controls.SetChildIndex(this.chkDelete, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecurity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.CheckBox chkCreate;
        private System.Windows.Forms.CheckBox chkRead;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private Biruni.Shared.Data.dsSecurity dsSecurity1;
        private Biruni.Shared.Data.dsSecurityTableAdapters.RolesTableAdapter daRoles;
        private Biruni.Shared.Data.dsSecurityTableAdapters.ApplicationsTableAdapter daApplications;
        private Biruni.Shared.Data.dsSecurityTableAdapters.ApplicationRolesTableAdapter daApplicationRoles;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
