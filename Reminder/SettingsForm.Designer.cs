namespace Reminder_desktop_application
{
    partial class SettingsForm
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
            this.mailNotificationChbx = new MetroFramework.Controls.MetroCheckBox();
            this.mailLoginTbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.vkNotificationChbx = new MetroFramework.Controls.MetroCheckBox();
            this.connectVKBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.fontSizeBx = new System.Windows.Forms.NumericUpDown();
            this.okBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.keyWordTbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBx)).BeginInit();
            this.SuspendLayout();
            // 
            // mailNotificationChbx
            // 
            this.mailNotificationChbx.AutoSize = true;
            this.mailNotificationChbx.Location = new System.Drawing.Point(24, 64);
            this.mailNotificationChbx.Name = "mailNotificationChbx";
            this.mailNotificationChbx.Size = new System.Drawing.Size(140, 15);
            this.mailNotificationChbx.TabIndex = 0;
            this.mailNotificationChbx.Text = "Уведомлять по почте";
            this.mailNotificationChbx.UseSelectable = true;
            // 
            // mailLoginTbx
            // 
            // 
            // 
            // 
            this.mailLoginTbx.CustomButton.Image = null;
            this.mailLoginTbx.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.mailLoginTbx.CustomButton.Name = "";
            this.mailLoginTbx.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mailLoginTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mailLoginTbx.CustomButton.TabIndex = 1;
            this.mailLoginTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mailLoginTbx.CustomButton.UseSelectable = true;
            this.mailLoginTbx.CustomButton.Visible = false;
            this.mailLoginTbx.Lines = new string[0];
            this.mailLoginTbx.Location = new System.Drawing.Point(81, 85);
            this.mailLoginTbx.MaxLength = 32767;
            this.mailLoginTbx.Name = "mailLoginTbx";
            this.mailLoginTbx.PasswordChar = '\0';
            this.mailLoginTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailLoginTbx.SelectedText = "";
            this.mailLoginTbx.SelectionLength = 0;
            this.mailLoginTbx.SelectionStart = 0;
            this.mailLoginTbx.ShortcutsEnabled = true;
            this.mailLoginTbx.Size = new System.Drawing.Size(159, 23);
            this.mailLoginTbx.TabIndex = 1;
            this.mailLoginTbx.UseSelectable = true;
            this.mailLoginTbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mailLoginTbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "E-mail:";
            // 
            // vkNotificationChbx
            // 
            this.vkNotificationChbx.AutoSize = true;
            this.vkNotificationChbx.Location = new System.Drawing.Point(25, 126);
            this.vkNotificationChbx.Name = "vkNotificationChbx";
            this.vkNotificationChbx.Size = new System.Drawing.Size(114, 15);
            this.vkNotificationChbx.TabIndex = 3;
            this.vkNotificationChbx.Text = "Уведомлять в ВК";
            this.vkNotificationChbx.UseSelectable = true;
            // 
            // connectVKBtn
            // 
            this.connectVKBtn.Location = new System.Drawing.Point(25, 152);
            this.connectVKBtn.Name = "connectVKBtn";
            this.connectVKBtn.Size = new System.Drawing.Size(215, 28);
            this.connectVKBtn.TabIndex = 4;
            this.connectVKBtn.Text = "Подключить ВК";
            this.connectVKBtn.UseSelectable = true;
            this.connectVKBtn.Click += new System.EventHandler(this.connectVKBtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 291);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Размер шрифта:";
            // 
            // fontSizeBx
            // 
            this.fontSizeBx.Location = new System.Drawing.Point(146, 292);
            this.fontSizeBx.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.fontSizeBx.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fontSizeBx.Name = "fontSizeBx";
            this.fontSizeBx.Size = new System.Drawing.Size(59, 20);
            this.fontSizeBx.TabIndex = 6;
            this.fontSizeBx.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // okBtn
            // 
            this.okBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.okBtn.Location = new System.Drawing.Point(88, 341);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(83, 31);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "OK";
            this.okBtn.UseSelectable = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(69, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(151, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Ключевая фраза/слово";
            // 
            // keyWordTbx
            // 
            // 
            // 
            // 
            this.keyWordTbx.CustomButton.Image = null;
            this.keyWordTbx.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.keyWordTbx.CustomButton.Name = "";
            this.keyWordTbx.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.keyWordTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyWordTbx.CustomButton.TabIndex = 1;
            this.keyWordTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyWordTbx.CustomButton.UseSelectable = true;
            this.keyWordTbx.CustomButton.Visible = false;
            this.keyWordTbx.Lines = new string[] {
        "список"};
            this.keyWordTbx.Location = new System.Drawing.Point(23, 232);
            this.keyWordTbx.MaxLength = 32767;
            this.keyWordTbx.Name = "keyWordTbx";
            this.keyWordTbx.PasswordChar = '\0';
            this.keyWordTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyWordTbx.SelectedText = "";
            this.keyWordTbx.SelectionLength = 0;
            this.keyWordTbx.SelectionStart = 0;
            this.keyWordTbx.ShortcutsEnabled = true;
            this.keyWordTbx.Size = new System.Drawing.Size(194, 23);
            this.keyWordTbx.TabIndex = 8;
            this.keyWordTbx.Text = "список";
            this.keyWordTbx.UseSelectable = true;
            this.keyWordTbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyWordTbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(218, 234);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(17, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "#";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 382);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.keyWordTbx);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.fontSizeBx);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.connectVKBtn);
            this.Controls.Add(this.vkNotificationChbx);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mailLoginTbx);
            this.Controls.Add(this.mailNotificationChbx);
            this.MaximumSize = new System.Drawing.Size(268, 382);
            this.MinimumSize = new System.Drawing.Size(268, 382);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox mailNotificationChbx;
        private MetroFramework.Controls.MetroTextBox mailLoginTbx;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox vkNotificationChbx;
        private MetroFramework.Controls.MetroButton connectVKBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown fontSizeBx;
        private MetroFramework.Controls.MetroButton okBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox keyWordTbx;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}