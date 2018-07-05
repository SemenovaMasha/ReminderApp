using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Reminder_desktop_application
{
    public partial class StatisticsForm : MetroFramework.Forms.MetroForm
    {
        TaskControler controler;
        public StatisticsForm(TaskControler controler)
        {
          //  this.TopMost = true;
            this.controler = controler;
            InitializeComponent();

            dateDtPkc.Format = DateTimePickerFormat.Custom;
            dateDtPkc.CustomFormat = "yyyy";

            dateDtPkc_ValueChanged(null, null);

            

            int fontSize = controler.getFontSize();
            statsGrid.DefaultCellStyle.Font = new Font("Segoe UI", fontSize);
            if (fontSize >= 15)
                sumLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            else if (fontSize > 10)
                sumLbl.FontSize = MetroFramework.MetroLabelSize.Medium;
            else
                sumLbl.FontSize = MetroFramework.MetroLabelSize.Small;
        }

        private void dateDtPkc_ValueChanged(object sender, EventArgs e)
        {
            this.statsChart.Series.Clear();


            string[] seriesArray = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            double[] sumPoints = new double[12];


            this.statsChart.Palette = ChartColorPalette.Pastel;

            List<TaskModel> tasks = controler.getYearTasks(dateDtPkc.Value);

            foreach (TaskModel task in tasks)
            {
                sumPoints[task.next_date.Month - 1] += (double)(task.price);
            }

            Series series = this.statsChart.Series.Add("месяцы");
            //series.IsValueShownAsLabel = true;

            statsGrid.Rows.Clear();

            for (int i = 0; i < seriesArray.Length; i++)
            {
                //series.Points.Add(sumPoints[i]);
                series.Points.Add(sumPoints[i]);
                series.Points[i].AxisLabel = seriesArray[i];
                if (sumPoints[i] > 0)
                    series.Points[i].IsValueShownAsLabel = true;

                statsGrid.Rows.Add(seriesArray[i], sumPoints[i]);
            }
            sumLbl.Text = "Итоговая сумма: " + controler.getYearSum(dateDtPkc.Value)+"р.";
        }

        private void nextDayBtn_Click(object sender, EventArgs e)
        {
            dateDtPkc.Value = dateDtPkc.Value.AddYears(1);
        }

        private void prevDayBtn_Click(object sender, EventArgs e)
        {
            dateDtPkc.Value = dateDtPkc.Value.AddYears(-1);
        }
    }
}
