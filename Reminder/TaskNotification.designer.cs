namespace Reminder_desktop_application
{
    partial class TaskNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskNotification));
            this.doneLink = new MetroFramework.Controls.MetroLink();
            this.notificationBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // doneLink
            // 
            this.doneLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doneLink.Image = ((System.Drawing.Image)(resources.GetObject("doneLink.Image")));
            this.doneLink.ImageSize = 45;
            this.doneLink.Location = new System.Drawing.Point(198, 17);
            this.doneLink.Name = "doneLink";
            this.doneLink.Size = new System.Drawing.Size(64, 48);
            this.doneLink.TabIndex = 4;
            this.doneLink.UseSelectable = true;
            this.doneLink.Click += new System.EventHandler(this.doneLink_Click);
            // 
            // notificationBox
            // 
            this.notificationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.notificationBox.CustomButton.Image = null;
            this.notificationBox.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.notificationBox.CustomButton.Name = "";
            this.notificationBox.CustomButton.Size = new System.Drawing.Size(101, 101);
            this.notificationBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.notificationBox.CustomButton.TabIndex = 1;
            this.notificationBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.notificationBox.CustomButton.UseSelectable = true;
            this.notificationBox.CustomButton.Visible = false;
            this.notificationBox.Enabled = false;
            this.notificationBox.Lines = new string[0];
            this.notificationBox.Location = new System.Drawing.Point(26, 83);
            this.notificationBox.MaxLength = 32767;
            this.notificationBox.Multiline = true;
            this.notificationBox.Name = "notificationBox";
            this.notificationBox.PasswordChar = '\0';
            this.notificationBox.ReadOnly = true;
            this.notificationBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.notificationBox.SelectedText = "";
            this.notificationBox.SelectionLength = 0;
            this.notificationBox.SelectionStart = 0;
            this.notificationBox.ShortcutsEnabled = true;
            this.notificationBox.Size = new System.Drawing.Size(236, 106);
            this.notificationBox.TabIndex = 6;
            this.notificationBox.UseSelectable = true;
            this.notificationBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.notificationBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TaskNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 225);
            this.Controls.Add(this.notificationBox);
            this.Controls.Add(this.doneLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.TopMost = true;
            this.MaximumSize = new System.Drawing.Size(291, 225);
            this.MinimumSize = new System.Drawing.Size(291, 225);
            this.Name = "TaskNotification";
            this.Resizable = false;
            this.Text = "Напоминание";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink doneLink;
        private MetroFramework.Controls.MetroTextBox notificationBox;
    }
}