namespace Reminder_desktop_application
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.dateDtPkc = new MetroFramework.Controls.MetroDateTime();
            this.statsGrid = new MetroFramework.Controls.MetroGrid();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nextDayBtn = new MetroFramework.Controls.MetroLink();
            this.prevDayBtn = new MetroFramework.Controls.MetroLink();
            this.sumLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.statsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDtPkc
            // 
            this.dateDtPkc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDtPkc.CustomFormat = "";
            this.dateDtPkc.Location = new System.Drawing.Point(57, 63);
            this.dateDtPkc.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDtPkc.Name = "dateDtPkc";
            this.dateDtPkc.Size = new System.Drawing.Size(371, 30);
            this.dateDtPkc.TabIndex = 0;
            this.dateDtPkc.ValueChanged += new System.EventHandler(this.dateDtPkc_ValueChanged);
            // 
            // statsGrid
            // 
            this.statsGrid.AllowUserToAddRows = false;
            this.statsGrid.AllowUserToDeleteRows = false;
            this.statsGrid.AllowUserToResizeRows = false;
            this.statsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.statsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.statsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.statsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsGrid.ColumnHeadersVisible = false;
            this.statsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.sum});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.statsGrid.EnableHeadersVisualStyles = false;
            this.statsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statsGrid.Location = new System.Drawing.Point(24, 106);
            this.statsGrid.Name = "statsGrid";
            this.statsGrid.ReadOnly = true;
            this.statsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.statsGrid.RowHeadersVisible = false;
            this.statsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.statsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statsGrid.Size = new System.Drawing.Size(438, 175);
            this.statsGrid.TabIndex = 1;
            // 
            // month
            // 
            this.month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.month.FillWeight = 70F;
            this.month.HeaderText = "Месяц";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sum.FillWeight = 30F;
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // statsChart
            // 
            this.statsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.Interval = 1D;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.statsChart.ChartAreas.Add(chartArea2);
            this.statsChart.Location = new System.Drawing.Point(24, 319);
            this.statsChart.Name = "statsChart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.statsChart.Series.Add(series2);
            this.statsChart.Size = new System.Drawing.Size(438, 287);
            this.statsChart.TabIndex = 2;
            this.statsChart.Text = "statsChart";
            // 
            // nextDayBtn
            // 
            this.nextDayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextDayBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextDayBtn.Image")));
            this.nextDayBtn.ImageSize = 28;
            this.nextDayBtn.Location = new System.Drawing.Point(434, 63);
            this.nextDayBtn.Name = "nextDayBtn";
            this.nextDayBtn.Size = new System.Drawing.Size(28, 28);
            this.nextDayBtn.TabIndex = 15;
            this.nextDayBtn.UseSelectable = true;
            this.nextDayBtn.Click += new System.EventHandler(this.nextDayBtn_Click);
            // 
            // prevDayBtn
            // 
            this.prevDayBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevDayBtn.Image")));
            this.prevDayBtn.ImageSize = 28;
            this.prevDayBtn.Location = new System.Drawing.Point(23, 63);
            this.prevDayBtn.Name = "prevDayBtn";
            this.prevDayBtn.Size = new System.Drawing.Size(28, 28);
            this.prevDayBtn.TabIndex = 16;
            this.prevDayBtn.UseSelectable = true;
            this.prevDayBtn.Click += new System.EventHandler(this.prevDayBtn_Click);
            // 
            // sumLbl
            // 
            this.sumLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sumLbl.AutoSize = true;
            this.sumLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.sumLbl.Location = new System.Drawing.Point(358, 289);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(76, 25);
            this.sumLbl.TabIndex = 17;
            this.sumLbl.Text = "Итого: 0";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 629);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.prevDayBtn);
            this.Controls.Add(this.nextDayBtn);
            this.Controls.Add(this.statsChart);
            this.Controls.Add(this.statsGrid);
            this.Controls.Add(this.dateDtPkc);
            this.MinimumSize = new System.Drawing.Size(258, 428);
            this.Name = "StatisticsForm";
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.statsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dateDtPkc;
        private MetroFramework.Controls.MetroGrid statsGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart statsChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private MetroFramework.Controls.MetroLink nextDayBtn;
        private MetroFramework.Controls.MetroLink prevDayBtn;
        private MetroFramework.Controls.MetroLabel sumLbl;
    }
}