﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class NewTaskForm : MetroFramework.Forms.MetroForm
    {
        TaskControler taskControler;
        private Task editTask;
        public NewTaskForm(TaskControler controler)
        {
            InitializeComponent();
            taskControler = controler;

            usualRdbtn.Checked = true;
        }

        public NewTaskForm(TaskControler controler, DateTime date) : this(controler)
        {
            datePck.Value = date;
            remindTimePck.Value = date;
        }

        public NewTaskForm(TaskControler controler, Task editTask) : this(controler)
        {
            this.editTask = editTask;
            remindTextTbx.Text = editTask.text;
            datePck.Value = editTask.next_date.Date;
            remindTimePck.Value = editTask.next_date;

            if (editTask.remind_flag)
            {
                remindRdbtn.Checked = true;
                if (editTask.period_min > 0)
                {
                    remindRepeatCkb.Checked = true;
                    
                    if (editTask.period_min % 525600 == 0)
                    {
                        remindTimePeriodType.SelectedIndex = 3;
                        remindPeriodTbx.Text = editTask.period_min / 525600 + "";
                    }
                    else if (editTask.period_min % 1440 == 0)
                    {
                        remindTimePeriodType.SelectedIndex = 2;
                        remindPeriodTbx.Text = editTask.period_min / 1440 + "";
                    }
                    else if (editTask.period_min % 60 == 0)
                    {
                        remindTimePeriodType.SelectedIndex = 1;
                        remindPeriodTbx.Text = editTask.period_min / 60 + "";
                    }
                    else 
                    {
                        remindTimePeriodType.SelectedIndex = 0;
                        remindPeriodTbx.Text = editTask.period_min + "";
                    }
                }
            }
            
                   // period_duration, 

        }
        private string getGuid()
        {
            return Guid.NewGuid().ToString();
        }

        private void saveLink_Click(object sender, EventArgs e)
        {
            
            if (usualRdbtn.Checked)
            {
                Task task = new Task(getGuid(),remindTextTbx.Text, datePck.Value,false, -1, -1, 0);
                taskControler.Add(task);
            }
            else 
            {
                int period_sec = -1;
                int period_duration = -1;
                if (remindRepeatCkb.Checked)
                {
                    int period_value = Convert.ToInt32(remindPeriodTbx.Text);
                    if (remindTimePeriodType.SelectedIndex == 0)
                    {
                        period_sec = period_value;
                    }
                    else if (remindTimePeriodType.SelectedIndex == 1)
                    {
                        period_sec = period_value *60;
                    }
                    else if (remindTimePeriodType.SelectedIndex == 2)
                    {
                        period_sec = period_value * 1440;
                    }
                    else if (remindTimePeriodType.SelectedIndex == 3)
                    {
                        period_sec = period_value * 525600;
                    }
                    
                    period_value = Convert.ToInt32(remindDurationTbx.Text);
                    if (remindTimeDurationType.SelectedIndex == 0)
                    {
                        period_duration = period_value ;
                    }
                    else if (remindTimeDurationType.SelectedIndex == 1)
                    {
                        period_duration = period_value * 60;
                    }
                    else if (remindTimeDurationType.SelectedIndex == 2)
                    {
                        period_duration = period_value * 1440;
                    }
                    else if (remindTimeDurationType.SelectedIndex == 3)
                    {
                        period_duration = period_value * 525600;
                    }
                }

                Task task = new Task(getGuid(),remindTextTbx.Text, GetDateZeroTime(datePck.Value).Add(GetTimeZeroSeconds(remindTimePck.Value).TimeOfDay),
                    true,  period_sec,
                    period_duration,0);

                taskControler.Add(task);
                
            }
            this.Close();
        }

        public static DateTime GetDateZeroTime(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
        }

        public static DateTime GetTimeZeroSeconds(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour,date.Minute,0);
        }

        private void cancelLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void usualRdbtn_CheckedChanged(object sender, EventArgs e)
        {
                remindTimePck.Enabled = false;
                remindRepeatCkb.Checked = false;
                remindRepeatCkb.Enabled = false;

            remindRepeatCkb_CheckedChanged(null, null);
        }

        private void remindRdbtn_CheckedChanged(object sender, EventArgs e)
        {
                remindTimePck.Enabled = true;
                remindRepeatCkb.Checked = false;
                remindRepeatCkb.Enabled = true;

            remindRepeatCkb_CheckedChanged(null, null);
        }

        private void remindRepeatCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (!remindRepeatCkb.Checked)
            {
                remindPeriodTbx.Enabled = false;
                remindTimePeriodType.Enabled = false;
                remindDurationTbx.Enabled = false;
                remindTimeDurationType.Enabled = false;
                metroLabel4.Enabled = false;
                //для metroLabel4 норм цвет подобрать
            }
            else
            {
                remindPeriodTbx.Enabled = true;
                remindTimePeriodType.Enabled = true;
                remindDurationTbx.Enabled = true;
                remindTimeDurationType.Enabled = true;
                metroLabel4.Enabled = true;
            }
        }
    }
}
