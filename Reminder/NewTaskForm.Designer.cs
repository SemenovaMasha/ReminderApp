namespace Reminder_desktop_application
{
    partial class NewTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTaskForm));
            this.cancelLink = new MetroFramework.Controls.MetroLink();
            this.saveLink = new MetroFramework.Controls.MetroLink();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.remindTimeDurationType = new System.Windows.Forms.ComboBox();
            this.remindDurationTbx = new System.Windows.Forms.TextBox();
            this.remindTimePeriodType = new System.Windows.Forms.ComboBox();
            this.remindPeriodTbx = new System.Windows.Forms.TextBox();
            this.remindRepeatCkb = new MetroFramework.Controls.MetroCheckBox();
            this.remindTimePck = new System.Windows.Forms.DateTimePicker();
            this.remindTimeLbl = new MetroFramework.Controls.MetroLabel();
            this.remindTextTbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.datePck = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.usualRdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.remindRdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // cancelLink
            // 
            this.cancelLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelLink.Image = ((System.Drawing.Image)(resources.GetObject("cancelLink.Image")));
            this.cancelLink.ImageSize = 40;
            this.cancelLink.Location = new System.Drawing.Point(249, 422);
            this.cancelLink.Margin = new System.Windows.Forms.Padding(2);
            this.cancelLink.Name = "cancelLink";
            this.cancelLink.Size = new System.Drawing.Size(58, 59);
            this.cancelLink.TabIndex = 2;
            this.cancelLink.Text = "Отмена";
            this.cancelLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelLink.UseSelectable = true;
            this.cancelLink.Click += new System.EventHandler(this.cancelLink_Click);
            // 
            // saveLink
            // 
            this.saveLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveLink.Image = ((System.Drawing.Image)(resources.GetObject("saveLink.Image")));
            this.saveLink.ImageSize = 40;
            this.saveLink.Location = new System.Drawing.Point(161, 422);
            this.saveLink.Margin = new System.Windows.Forms.Padding(2);
            this.saveLink.Name = "saveLink";
            this.saveLink.Size = new System.Drawing.Size(85, 59);
            this.saveLink.TabIndex = 1;
            this.saveLink.Text = "Сохранить";
            this.saveLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveLink.UseSelectable = true;
            this.saveLink.Click += new System.EventHandler(this.saveLink_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(223, 403);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "в течение";
            // 
            // remindTimeDurationType
            // 
            this.remindTimeDurationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remindTimeDurationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remindTimeDurationType.FormattingEnabled = true;
            this.remindTimeDurationType.Items.AddRange(new object[] {
            "минут",
            "часов",
            "дней",
            "лет"});
            this.remindTimeDurationType.Location = new System.Drawing.Point(355, 403);
            this.remindTimeDurationType.Name = "remindTimeDurationType";
            this.remindTimeDurationType.Size = new System.Drawing.Size(107, 21);
            this.remindTimeDurationType.TabIndex = 30;
            // 
            // remindDurationTbx
            // 
            this.remindDurationTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remindDurationTbx.Location = new System.Drawing.Point(301, 403);
            this.remindDurationTbx.Name = "remindDurationTbx";
            this.remindDurationTbx.Size = new System.Drawing.Size(48, 20);
            this.remindDurationTbx.TabIndex = 29;
            this.remindDurationTbx.Text = "1";
            // 
            // remindTimePeriodType
            // 
            this.remindTimePeriodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remindTimePeriodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remindTimePeriodType.FormattingEnabled = true;
            this.remindTimePeriodType.Items.AddRange(new object[] {
            "минут",
            "часов",
            "дней",
            "лет"});
            this.remindTimePeriodType.Location = new System.Drawing.Point(355, 378);
            this.remindTimePeriodType.Name = "remindTimePeriodType";
            this.remindTimePeriodType.Size = new System.Drawing.Size(107, 21);
            this.remindTimePeriodType.TabIndex = 28;
            // 
            // remindPeriodTbx
            // 
            this.remindPeriodTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remindPeriodTbx.Location = new System.Drawing.Point(301, 378);
            this.remindPeriodTbx.Name = "remindPeriodTbx";
            this.remindPeriodTbx.Size = new System.Drawing.Size(48, 20);
            this.remindPeriodTbx.TabIndex = 27;
            this.remindPeriodTbx.Text = "1";
            // 
            // remindRepeatCkb
            // 
            this.remindRepeatCkb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remindRepeatCkb.AutoSize = true;
            this.remindRepeatCkb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.remindRepeatCkb.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.remindRepeatCkb.Location = new System.Drawing.Point(155, 377);
            this.remindRepeatCkb.Name = "remindRepeatCkb";
            this.remindRepeatCkb.Size = new System.Drawing.Size(137, 19);
            this.remindRepeatCkb.TabIndex = 26;
            this.remindRepeatCkb.Text = "Повторять каждые";
            this.remindRepeatCkb.UseSelectable = true;
            this.remindRepeatCkb.CheckedChanged += new System.EventHandler(this.remindRepeatCkb_CheckedChanged);
            // 
            // remindTimePck
            // 
            this.remindTimePck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.remindTimePck.CustomFormat = "HH:mm";
            this.remindTimePck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.remindTimePck.Location = new System.Drawing.Point(80, 377);
            this.remindTimePck.MinDate = new System.DateTime(2016, 11, 5, 0, 0, 0, 0);
            this.remindTimePck.Name = "remindTimePck";
            this.remindTimePck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.remindTimePck.ShowUpDown = true;
            this.remindTimePck.Size = new System.Drawing.Size(62, 20);
            this.remindTimePck.TabIndex = 25;
            // 
            // remindTimeLbl
            // 
            this.remindTimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.remindTimeLbl.AutoSize = true;
            this.remindTimeLbl.Location = new System.Drawing.Point(23, 378);
            this.remindTimeLbl.Name = "remindTimeLbl";
            this.remindTimeLbl.Size = new System.Drawing.Size(51, 19);
            this.remindTimeLbl.TabIndex = 24;
            this.remindTimeLbl.Text = "Время:";
            // 
            // remindTextTbx
            // 
            this.remindTextTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.remindTextTbx.CustomButton.Image = null;
            this.remindTextTbx.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.remindTextTbx.CustomButton.Name = "";
            this.remindTextTbx.CustomButton.Size = new System.Drawing.Size(257, 257);
            this.remindTextTbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.remindTextTbx.CustomButton.TabIndex = 1;
            this.remindTextTbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.remindTextTbx.CustomButton.UseSelectable = true;
            this.remindTextTbx.CustomButton.Visible = false;
            this.remindTextTbx.Lines = new string[0];
            this.remindTextTbx.Location = new System.Drawing.Point(23, 112);
            this.remindTextTbx.MaxLength = 32767;
            this.remindTextTbx.MinimumSize = new System.Drawing.Size(434, 206);
            this.remindTextTbx.Multiline = true;
            this.remindTextTbx.Name = "remindTextTbx";
            this.remindTextTbx.PasswordChar = '\0';
            this.remindTextTbx.PromptText = "Текст...";
            this.remindTextTbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.remindTextTbx.SelectedText = "";
            this.remindTextTbx.SelectionLength = 0;
            this.remindTextTbx.SelectionStart = 0;
            this.remindTextTbx.ShortcutsEnabled = true;
            this.remindTextTbx.Size = new System.Drawing.Size(447, 259);
            this.remindTextTbx.TabIndex = 22;
            this.remindTextTbx.UseSelectable = true;
            this.remindTextTbx.WaterMark = "Текст...";
            this.remindTextTbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.remindTextTbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Текст заметки:";
            // 
            // datePck
            // 
            this.datePck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePck.Location = new System.Drawing.Point(294, 58);
            this.datePck.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePck.Name = "datePck";
            this.datePck.Size = new System.Drawing.Size(168, 29);
            this.datePck.TabIndex = 32;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(248, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Дата:";
            // 
            // usualRdbtn
            // 
            this.usualRdbtn.AutoSize = true;
            this.usualRdbtn.Location = new System.Drawing.Point(24, 63);
            this.usualRdbtn.Name = "usualRdbtn";
            this.usualRdbtn.Size = new System.Drawing.Size(68, 15);
            this.usualRdbtn.TabIndex = 34;
            this.usualRdbtn.Text = "Заметка";
            this.usualRdbtn.UseSelectable = true;
            this.usualRdbtn.CheckedChanged += new System.EventHandler(this.usualRdbtn_CheckedChanged);
            // 
            // remindRdbtn
            // 
            this.remindRdbtn.AutoSize = true;
            this.remindRdbtn.Location = new System.Drawing.Point(112, 63);
            this.remindRdbtn.Name = "remindRdbtn";
            this.remindRdbtn.Size = new System.Drawing.Size(101, 15);
            this.remindRdbtn.TabIndex = 35;
            this.remindRdbtn.Text = "Напоминание";
            this.remindRdbtn.UseSelectable = true;
            this.remindRdbtn.CheckedChanged += new System.EventHandler(this.remindRdbtn_CheckedChanged);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 503);
            this.Controls.Add(this.remindRdbtn);
            this.Controls.Add(this.usualRdbtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.datePck);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.remindTimeDurationType);
            this.Controls.Add(this.remindDurationTbx);
            this.Controls.Add(this.remindTimePeriodType);
            this.Controls.Add(this.remindPeriodTbx);
            this.Controls.Add(this.remindRepeatCkb);
            this.Controls.Add(this.remindTimePck);
            this.Controls.Add(this.remindTimeLbl);
            this.Controls.Add(this.remindTextTbx);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cancelLink);
            this.Controls.Add(this.saveLink);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(578, 503);
            this.MinimumSize = new System.Drawing.Size(493, 503);
            this.Name = "NewTaskForm";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Resizable = false;
            this.Text = "Запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink saveLink;
        private MetroFramework.Controls.MetroLink cancelLink;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox remindTimeDurationType;
        private System.Windows.Forms.TextBox remindDurationTbx;
        private System.Windows.Forms.ComboBox remindTimePeriodType;
        private System.Windows.Forms.TextBox remindPeriodTbx;
        private MetroFramework.Controls.MetroCheckBox remindRepeatCkb;
        private System.Windows.Forms.DateTimePicker remindTimePck;
        private MetroFramework.Controls.MetroLabel remindTimeLbl;
        private MetroFramework.Controls.MetroTextBox remindTextTbx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime datePck;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton usualRdbtn;
        private MetroFramework.Controls.MetroRadioButton remindRdbtn;
    }
}