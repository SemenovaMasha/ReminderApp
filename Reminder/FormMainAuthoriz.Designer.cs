namespace Reminder
{
    partial class FormMainAuthoriz
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
            this.okBtn = new MetroFramework.Controls.MetroButton();
            this.passwordTbx = new MetroFramework.Controls.MetroTextBox();
            this.loginTbx = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(104, 149);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 11;
            this.okBtn.Text = "OK";
            this.okBtn.UseSelectable = true;
            // 
            // passwordTbx
            // 
            // 
            // 
            // 
            this.passwordTbx.CustomButton.Image = null;
            this.passwordTbx.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.passwordTbx.CustomButton.Name = "";
            this.passwordTbx.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.passwordTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTbx.CustomButton.TabIndex = 1;
            this.passwordTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTbx.CustomButton.UseSelectable = true;
            this.passwordTbx.CustomButton.Visible = false;
            this.passwordTbx.Lines = new string[0];
            this.passwordTbx.Location = new System.Drawing.Point(121, 93);
            this.passwordTbx.MaxLength = 32767;
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.PasswordChar = '*';
            this.passwordTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTbx.SelectedText = "";
            this.passwordTbx.SelectionLength = 0;
            this.passwordTbx.SelectionStart = 0;
            this.passwordTbx.ShortcutsEnabled = true;
            this.passwordTbx.Size = new System.Drawing.Size(148, 23);
            this.passwordTbx.TabIndex = 10;
            this.passwordTbx.UseSelectable = true;
            this.passwordTbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginTbx
            // 
            // 
            // 
            // 
            this.loginTbx.CustomButton.Image = null;
            this.loginTbx.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.loginTbx.CustomButton.Name = "";
            this.loginTbx.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.loginTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginTbx.CustomButton.TabIndex = 1;
            this.loginTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginTbx.CustomButton.UseSelectable = true;
            this.loginTbx.CustomButton.Visible = false;
            this.loginTbx.Lines = new string[0];
            this.loginTbx.Location = new System.Drawing.Point(121, 65);
            this.loginTbx.MaxLength = 32767;
            this.loginTbx.Name = "loginTbx";
            this.loginTbx.PasswordChar = '\0';
            this.loginTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTbx.SelectedText = "";
            this.loginTbx.SelectionLength = 0;
            this.loginTbx.SelectionStart = 0;
            this.loginTbx.ShortcutsEnabled = true;
            this.loginTbx.Size = new System.Drawing.Size(148, 23);
            this.loginTbx.TabIndex = 9;
            this.loginTbx.UseSelectable = true;
            this.loginTbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginTbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormMainAuthoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(280, 191);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.loginTbx);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMainAuthoriz";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton okBtn;
        private MetroFramework.Controls.MetroTextBox passwordTbx;
        private MetroFramework.Controls.MetroTextBox loginTbx;
    }
}