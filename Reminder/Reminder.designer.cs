
namespace Reminder_desktop_application
{
    partial class Reminder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesDataGrid = new MetroFramework.Controls.MetroGrid();
            this.datePicker = new MetroFramework.Controls.MetroDateTime();
            this.settingsBtn = new MetroFramework.Controls.MetroLink();
            this.deleteBtn = new MetroFramework.Controls.MetroLink();
            this.addBtn = new MetroFramework.Controls.MetroLink();
            this.nextDayBtn = new MetroFramework.Controls.MetroLink();
            this.prevDayBtn = new MetroFramework.Controls.MetroLink();
            this.statsBtn = new MetroFramework.Controls.MetroLink();
            this.sumLbl = new MetroFramework.Controls.MetroLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationIcon
            // 
            this.notificationIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Visible = true;
            this.notificationIcon.BalloonTipClicked += new System.EventHandler(this.notificationIcon_BalloonTipClicked);
            this.notificationIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notificationIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 52);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notesDataGrid
            // 
            this.notesDataGrid.AllowUserToAddRows = false;
            this.notesDataGrid.AllowUserToDeleteRows = false;
            this.notesDataGrid.AllowUserToResizeRows = false;
            this.notesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.notesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.notesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notesDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.notesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.notesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.notesDataGrid.EnableHeadersVisualStyles = false;
            this.notesDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.notesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.notesDataGrid.Location = new System.Drawing.Point(23, 75);
            this.notesDataGrid.Name = "notesDataGrid";
            this.notesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.notesDataGrid.RowHeadersVisible = false;
            this.notesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.notesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notesDataGrid.Size = new System.Drawing.Size(481, 314);
            this.notesDataGrid.TabIndex = 8;
            this.notesDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesDataGrid_CellDoubleClick);
            this.notesDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesDataGrid_CellEndEdit);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.Location = new System.Drawing.Point(179, 28);
            this.datePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(143, 30);
            this.datePicker.TabIndex = 7;
            this.datePicker.ValueChanged += new System.EventHandler(this.reminderDateTime_ValueChanged_1);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageSize = 28;
            this.settingsBtn.Location = new System.Drawing.Point(442, 26);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(28, 28);
            this.settingsBtn.TabIndex = 9;
            this.settingsBtn.UseSelectable = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageSize = 28;
            this.deleteBtn.Location = new System.Drawing.Point(408, 26);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(28, 28);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageSize = 28;
            this.addBtn.Location = new System.Drawing.Point(375, 26);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(28, 28);
            this.addBtn.TabIndex = 11;
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nextDayBtn
            // 
            this.nextDayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextDayBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextDayBtn.Image")));
            this.nextDayBtn.ImageSize = 28;
            this.nextDayBtn.Location = new System.Drawing.Point(328, 28);
            this.nextDayBtn.Name = "nextDayBtn";
            this.nextDayBtn.Size = new System.Drawing.Size(28, 28);
            this.nextDayBtn.TabIndex = 12;
            this.nextDayBtn.UseSelectable = true;
            this.nextDayBtn.Click += new System.EventHandler(this.nextDayBtn_Click);
            // 
            // prevDayBtn
            // 
            this.prevDayBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevDayBtn.Image")));
            this.prevDayBtn.ImageSize = 28;
            this.prevDayBtn.Location = new System.Drawing.Point(145, 28);
            this.prevDayBtn.Name = "prevDayBtn";
            this.prevDayBtn.Size = new System.Drawing.Size(28, 28);
            this.prevDayBtn.TabIndex = 13;
            this.prevDayBtn.UseSelectable = true;
            this.prevDayBtn.Click += new System.EventHandler(this.prevDayBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statsBtn.Image = ((System.Drawing.Image)(resources.GetObject("statsBtn.Image")));
            this.statsBtn.ImageSize = 28;
            this.statsBtn.Location = new System.Drawing.Point(476, 26);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(28, 28);
            this.statsBtn.TabIndex = 14;
            this.statsBtn.UseSelectable = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // sumLbl
            // 
            this.sumLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sumLbl.AutoSize = true;
            this.sumLbl.Location = new System.Drawing.Point(417, 393);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(62, 20);
            this.sumLbl.TabIndex = 15;
            this.sumLbl.Text = "Итого: 0";
            this.sumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(519, 419);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.prevDayBtn);
            this.Controls.Add(this.nextDayBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.notesDataGrid);
            this.Controls.Add(this.datePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(519, 419);
            this.Name = "Reminder";
            this.Text = "Blocknote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reminder_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Reminder_ResizeEnd);
            this.Resize += new System.EventHandler(this.Reminder_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid notesDataGrid;
        private MetroFramework.Controls.MetroDateTime datePicker;
        private MetroFramework.Controls.MetroLink settingsBtn;
        private MetroFramework.Controls.MetroLink deleteBtn;
        private MetroFramework.Controls.MetroLink addBtn;
        private MetroFramework.Controls.MetroLink nextDayBtn;
        private MetroFramework.Controls.MetroLink prevDayBtn;
        private MetroFramework.Controls.MetroLink statsBtn;
        private MetroFramework.Controls.MetroLabel sumLbl;
    }
}

