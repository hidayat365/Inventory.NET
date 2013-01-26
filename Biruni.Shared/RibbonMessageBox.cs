using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biruni.Shared
{
    public partial class RibbonMessageBox : C1.Win.C1Ribbon.C1RibbonForm
    {
        public RibbonMessageBox()
        {
            InitializeComponent();
            AppHelper.ApplyFormStyle(this);
            AppHelper.ApplyVisualStyle(this.Controls);
        }

        public static DialogResult Show(string text)
        {
            return Show(text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Show(string text, string caption)
        {
            return Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return Show(text, caption, buttons, MessageBoxIcon.Information);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            RibbonMessageBox form = new RibbonMessageBox();
            form.Message.Text = text;
            form.Text = caption;
            form.Width = form.Message.Width + 120;
            form.Height = form.Message.Height + 100;
            if (form.Message.Height < form.picQuestion.Height)
                form.Message.Top = form.picQuestion.Top + (form.picQuestion.Height - form.Message.Height) / 2;
            form.LayoutIcon(icon);
            form.LayoutButtons(buttons);
            DialogResult dr = form.ShowDialog();
            form.Dispose();
            return dr;
        }

        public void LayoutIcon(MessageBoxIcon icon)
        {
            picError.Visible = false;
            picExclamation.Visible = false;
            picQuestion.Visible = false;
            picInformation.Visible = false;
            switch (icon)
            {
                case MessageBoxIcon.Error:
                    picError.Visible = true;
                    break;
                case MessageBoxIcon.Exclamation:
                    picExclamation.Visible = true;
                    break;
                case MessageBoxIcon.Question:
                    picQuestion.Visible = true;
                    break;
                case MessageBoxIcon.Information:
                    picInformation.Visible = true;
                    break;
                default:
                    picInformation.Visible = true;
                    break;
            }
        }

        public void LayoutButtons(MessageBoxButtons buttons)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    button1.Visible = true;
                    button1.Left = (ClientSize.Width - button1.Width) / 2;
                    break;
                case MessageBoxButtons.OKCancel:
                    button1.Visible = true;
                    button2.Visible = true;
                    button1.Left = (ClientSize.Width - button1.Width - button2.Width - 4) / 2;
                    button2.Left = button1.Left + button2.Width + 4;
                    break;
                case MessageBoxButtons.YesNo:
                    button3.Visible = true;
                    button4.Visible = true;
                    button3.Left = (ClientSize.Width - button3.Width - button4.Width - 4) / 2;
                    button4.Left = button3.Left + button4.Width + 4;
                    break;
                default:
                    button1.Visible = true;
                    button1.Left = (ClientSize.Width - button1.Width) / 2;
                    break;
            }
        }

    }
}