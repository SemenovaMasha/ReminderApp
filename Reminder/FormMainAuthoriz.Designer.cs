namespace Reminder_desktop_application
{
    partial class FormMainAuthoriz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));

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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(117, 128);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(118, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseSelectable = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // passwordTbx
            // 
            // 
            // 
            // 
            this.passwordTbx.CustomButton.Image = null;
            this.passwordTbx.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.passwordTbx.CustomButton.Name = "";
            this.passwordTbx.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.passwordTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTbx.CustomButton.TabIndex = 1;
            this.passwordTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTbx.CustomButton.UseSelectable = true;
            this.passwordTbx.CustomButton.Visible = false;
            this.passwordTbx.Lines = new string[0];
            this.passwordTbx.Location = new System.Drawing.Point(122, 90);
            this.passwordTbx.MaxLength = 32767;
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.PasswordChar = '*';
            this.passwordTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTbx.SelectedText = "";
            this.passwordTbx.SelectionLength = 0;
            this.passwordTbx.SelectionStart = 0;
            this.passwordTbx.ShortcutsEnabled = true;
            this.passwordTbx.Size = new System.Drawing.Size(159, 23);
            this.passwordTbx.TabIndex = 1;
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
            this.loginTbx.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.loginTbx.CustomButton.Name = "";
            this.loginTbx.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.loginTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginTbx.CustomButton.TabIndex = 1;
            this.loginTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginTbx.CustomButton.UseSelectable = true;
            this.loginTbx.CustomButton.Visible = false;
            this.loginTbx.Lines = new string[0];
            this.loginTbx.Location = new System.Drawing.Point(122, 62);
            this.loginTbx.MaxLength = 32767;
            this.loginTbx.Name = "loginTbx";
            this.loginTbx.PasswordChar = '\0';
            this.loginTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTbx.SelectedText = "";
            this.loginTbx.SelectionLength = 0;
            this.loginTbx.SelectionStart = 0;
            this.loginTbx.ShortcutsEnabled = true;
            this.loginTbx.Size = new System.Drawing.Size(159, 23);
            this.loginTbx.TabIndex = 0;
            this.loginTbx.UseSelectable = true;
            this.loginTbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginTbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(117, 157);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Я забыл(а) данные";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Логин:";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(224, 30);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(118, 23);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "Свободный вход";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Visible = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // FormMainAuthoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 196);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.loginTbx);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(349, 196);
            this.MinimumSize = new System.Drawing.Size(349, 196);
            this.Name = "FormMainAuthoriz";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormMainAuthoriz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton okBtn;
        private MetroFramework.Controls.MetroTextBox passwordTbx;
        private MetroFramework.Controls.MetroTextBox loginTbx;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}