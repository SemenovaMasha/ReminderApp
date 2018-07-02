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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.mailNotificationChbx = new MetroFramework.Controls.MetroCheckBox();
            this.mailLoginTbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.vkNotificationChbx = new MetroFramework.Controls.MetroCheckBox();
            this.connectVKBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.fontSizeBx = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.keyWordTbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.loadBtn = new MetroFramework.Controls.MetroLink();
            this.okBtn = new MetroFramework.Controls.MetroLink();
            this.cancelLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBx)).BeginInit();
            this.SuspendLayout();
            // 
            // mailNotificationChbx
            // 
            this.mailNotificationChbx.AutoSize = true;
            this.mailNotificationChbx.Location = new System.Drawing.Point(32, 69);
            this.mailNotificationChbx.Margin = new System.Windows.Forms.Padding(4);
            this.mailNotificationChbx.Name = "mailNotificationChbx";
            this.mailNotificationChbx.Size = new System.Drawing.Size(152, 17);
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
            this.mailLoginTbx.CustomButton.Location = new System.Drawing.Point(186, 2);
            this.mailLoginTbx.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mailLoginTbx.CustomButton.Name = "";
            this.mailLoginTbx.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mailLoginTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mailLoginTbx.CustomButton.TabIndex = 1;
            this.mailLoginTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mailLoginTbx.CustomButton.UseSelectable = true;
            this.mailLoginTbx.CustomButton.Visible = false;
            this.mailLoginTbx.Lines = new string[0];
            this.mailLoginTbx.Location = new System.Drawing.Point(108, 95);
            this.mailLoginTbx.Margin = new System.Windows.Forms.Padding(4);
            this.mailLoginTbx.MaxLength = 32767;
            this.mailLoginTbx.Name = "mailLoginTbx";
            this.mailLoginTbx.PasswordChar = '\0';
            this.mailLoginTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailLoginTbx.SelectedText = "";
            this.mailLoginTbx.SelectionLength = 0;
            this.mailLoginTbx.SelectionStart = 0;
            this.mailLoginTbx.ShortcutsEnabled = true;
            this.mailLoginTbx.Size = new System.Drawing.Size(212, 28);
            this.mailLoginTbx.TabIndex = 1;
            this.mailLoginTbx.UseSelectable = true;
            this.mailLoginTbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mailLoginTbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 95);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "E-mail:";
            // 
            // vkNotificationChbx
            // 
            this.vkNotificationChbx.AutoSize = true;
            this.vkNotificationChbx.Location = new System.Drawing.Point(33, 136);
            this.vkNotificationChbx.Margin = new System.Windows.Forms.Padding(4);
            this.vkNotificationChbx.Name = "vkNotificationChbx";
            this.vkNotificationChbx.Size = new System.Drawing.Size(125, 17);
            this.vkNotificationChbx.TabIndex = 3;
            this.vkNotificationChbx.Text = "Уведомлять в ВК";
            this.vkNotificationChbx.UseSelectable = true;
            // 
            // connectVKBtn
            // 
            this.connectVKBtn.Location = new System.Drawing.Point(33, 168);
            this.connectVKBtn.Margin = new System.Windows.Forms.Padding(4);
            this.connectVKBtn.Name = "connectVKBtn";
            this.connectVKBtn.Size = new System.Drawing.Size(287, 34);
            this.connectVKBtn.TabIndex = 4;
            this.connectVKBtn.Text = "Подключить ВК";
            this.connectVKBtn.UseSelectable = true;
            this.connectVKBtn.Click += new System.EventHandler(this.connectVKBtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 296);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Размер шрифта:";
            // 
            // fontSizeBx
            // 
            this.fontSizeBx.Location = new System.Drawing.Point(199, 297);
            this.fontSizeBx.Margin = new System.Windows.Forms.Padding(4);
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
            this.fontSizeBx.Size = new System.Drawing.Size(79, 22);
            this.fontSizeBx.TabIndex = 6;
            this.fontSizeBx.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(92, 219);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(160, 20);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Ключевая фраза/слово";
            // 
            // keyWordTbx
            // 
            // 
            // 
            // 
            this.keyWordTbx.CustomButton.Image = null;
            this.keyWordTbx.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.keyWordTbx.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.keyWordTbx.CustomButton.Name = "";
            this.keyWordTbx.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.keyWordTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyWordTbx.CustomButton.TabIndex = 1;
            this.keyWordTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyWordTbx.CustomButton.UseSelectable = true;
            this.keyWordTbx.CustomButton.Visible = false;
            this.keyWordTbx.Lines = new string[] {
        "список"};
            this.keyWordTbx.Location = new System.Drawing.Point(31, 251);
            this.keyWordTbx.Margin = new System.Windows.Forms.Padding(4);
            this.keyWordTbx.MaxLength = 32767;
            this.keyWordTbx.Name = "keyWordTbx";
            this.keyWordTbx.PasswordChar = '\0';
            this.keyWordTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyWordTbx.SelectedText = "";
            this.keyWordTbx.SelectionLength = 0;
            this.keyWordTbx.SelectionStart = 0;
            this.keyWordTbx.ShortcutsEnabled = true;
            this.keyWordTbx.Size = new System.Drawing.Size(259, 28);
            this.keyWordTbx.TabIndex = 8;
            this.keyWordTbx.Text = "список";
            this.keyWordTbx.UseSelectable = true;
            this.keyWordTbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyWordTbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(291, 253);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(18, 20);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "#";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(27, 344);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(287, 34);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Изменить данные для входа";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
            this.loadBtn.ImageSize = 28;
            this.loadBtn.Location = new System.Drawing.Point(291, 414);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(28, 28);
            this.loadBtn.TabIndex = 12;
            this.loadBtn.UseSelectable = true;
            this.loadBtn.Visible = false;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okBtn.Image = ((System.Drawing.Image)(resources.GetObject("okBtn.Image")));
            this.okBtn.ImageSize = 40;
            this.okBtn.Location = new System.Drawing.Point(71, 384);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(113, 73);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "Сохранить";
            this.okBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.okBtn.UseSelectable = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelLink
            // 
            this.cancelLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelLink.Image = ((System.Drawing.Image)(resources.GetObject("cancelLink.Image")));
            this.cancelLink.ImageSize = 40;
            this.cancelLink.Location = new System.Drawing.Point(190, 384);
            this.cancelLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelLink.Name = "cancelLink";
            this.cancelLink.Size = new System.Drawing.Size(77, 73);
            this.cancelLink.TabIndex = 14;
            this.cancelLink.Text = "Отмена";
            this.cancelLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelLink.UseSelectable = true;
            this.cancelLink.Click += new System.EventHandler(this.cancelLink_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 470);
            this.Controls.Add(this.cancelLink);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.keyWordTbx);
            this.Controls.Add(this.fontSizeBx);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.connectVKBtn);
            this.Controls.Add(this.vkNotificationChbx);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mailLoginTbx);
            this.Controls.Add(this.mailNotificationChbx);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(357, 470);
            this.MinimumSize = new System.Drawing.Size(357, 470);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox keyWordTbx;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLink loadBtn;
        private MetroFramework.Controls.MetroLink okBtn;
        private MetroFramework.Controls.MetroLink cancelLink;
    }
}