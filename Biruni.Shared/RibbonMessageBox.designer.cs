namespace Biruni.Shared
{
    partial class RibbonMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonMessageBox));
            this.Message = new System.Windows.Forms.Label();
            this.button1 = new C1.Win.C1Input.C1Button();
            this.button2 = new C1.Win.C1Input.C1Button();
            this.button3 = new C1.Win.C1Input.C1Button();
            this.button4 = new C1.Win.C1Input.C1Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picError = new System.Windows.Forms.PictureBox();
            this.picQuestion = new System.Windows.Forms.PictureBox();
            this.picInformation = new System.Windows.Forms.PictureBox();
            this.picExclamation = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExclamation)).BeginInit();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(68, 16);
            this.Message.MaximumSize = new System.Drawing.Size(400, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(96, 13);
            this.Message.TabIndex = 0;
            this.Message.Text = "messageTextLabel";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(16, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(88, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button3.Location = new System.Drawing.Point(160, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "&Yes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button4.Location = new System.Drawing.Point(232, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "&No";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 42);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picError);
            this.panel1.Controls.Add(this.picQuestion);
            this.panel1.Controls.Add(this.picInformation);
            this.panel1.Controls.Add(this.Message);
            this.panel1.Controls.Add(this.picExclamation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 64);
            this.panel1.TabIndex = 7;
            // 
            // picError
            // 
            this.picError.Image = global::Biruni.Shared.Properties.Resources.error;
            this.picError.Location = new System.Drawing.Point(16, 16);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(32, 32);
            this.picError.TabIndex = 4;
            this.picError.TabStop = false;
            // 
            // picQuestion
            // 
            this.picQuestion.Image = global::Biruni.Shared.Properties.Resources.help;
            this.picQuestion.Location = new System.Drawing.Point(16, 16);
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.Size = new System.Drawing.Size(32, 32);
            this.picQuestion.TabIndex = 2;
            this.picQuestion.TabStop = false;
            // 
            // picInformation
            // 
            this.picInformation.Image = global::Biruni.Shared.Properties.Resources.information;
            this.picInformation.Location = new System.Drawing.Point(16, 16);
            this.picInformation.Name = "picInformation";
            this.picInformation.Size = new System.Drawing.Size(32, 32);
            this.picInformation.TabIndex = 1;
            this.picInformation.TabStop = false;
            // 
            // picExclamation
            // 
            this.picExclamation.Image = global::Biruni.Shared.Properties.Resources.warning;
            this.picExclamation.Location = new System.Drawing.Point(16, 16);
            this.picExclamation.Name = "picExclamation";
            this.picExclamation.Size = new System.Drawing.Size(32, 32);
            this.picExclamation.TabIndex = 3;
            this.picExclamation.TabStop = false;
            // 
            // RibbonMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 106);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 140);
            this.Name = "RibbonMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RibbonMessageBox";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExclamation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private C1.Win.C1Input.C1Button button1;
        private C1.Win.C1Input.C1Button button2;
        private C1.Win.C1Input.C1Button button3;
        private C1.Win.C1Input.C1Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picExclamation;
        private System.Windows.Forms.PictureBox picQuestion;
        private System.Windows.Forms.PictureBox picError;
    
    }
}