using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class NewTaskForm : MetroFramework.Forms.MetroForm
    {
        TaskControler taskControler;
        private TaskModel editTask;
        public NewTaskForm(TaskControler controler)
        {
            //  this.TopMost = true;
            InitializeComponent();
            taskControler = controler;

            usualRdbtn.Checked = true;
            remindTimePeriodType.SelectedIndex = 0;
            remindTimeDurationType.SelectedIndex = 1;

            int fontSize = taskControler.getFontSize();
            if (fontSize >= 15)
                remindTextTbx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            else if (fontSize > 10)
                remindTextTbx.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            else
                remindTextTbx.FontSize = MetroFramework.MetroTextBoxSize.Small;
        }

        public NewTaskForm(TaskControler controler, DateTime date) : this(controler)
        {
            datePck.Value = date;
            //remindTimePck.Value = date;
            remindTimePck.Value = DateTime.Now;
        }

        public NewTaskForm(TaskControler controler, TaskModel editTask) : this(controler)
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
                        remindTimeDurationType.SelectedIndex = 0;
                        remindDurationTbx.Text = editTask.duration_min / 525600 + "";
                    }
                    else if (editTask.period_min % 1440 == 0)
                    {
                        remindTimePeriodType.SelectedIndex = 2;
                        remindPeriodTbx.Text = editTask.period_min / 1440 + "";
                        remindTimeDurationType.SelectedIndex = 0;
                        remindDurationTbx.Text = editTask.duration_min / 1440 + "";
                    }
                    else if (editTask.period_min % 60 == 0)
                    {
                        remindTimePeriodType.SelectedIndex = 1;
                        remindPeriodTbx.Text = editTask.period_min / 60 + "";
                        remindTimeDurationType.SelectedIndex = 0;
                        remindDurationTbx.Text = editTask.duration_min / 60 + "";
                    }
                    else
                    {
                        remindTimePeriodType.SelectedIndex = 0;
                        remindPeriodTbx.Text = editTask.period_min + "";
                        remindTimeDurationType.SelectedIndex = 0;
                        remindDurationTbx.Text = editTask.duration_min + "";
                    }

                }
            }

        }

        private void saveLink_Click(object sender, EventArgs e)
        {
            if (remindTextTbx.Text.Trim() != "")
            {
                if (editTask == null)
                {

                    if (usualRdbtn.Checked)
                    {
                        TaskModel task = new TaskModel
                        {
                            text = remindTextTbx.Text,
                            next_date = datePck.Value,
                            remind_flag = false,
                            period_min = -1,
                            duration_min = -1,
                            price = 0
                        }
                        ;
                        task.generateJobKey();
                        taskControler.Add(task);
                    }
                    else
                    {
                        int period_sec = -1;
                        int period_duration = -1;
                        if (remindRepeatCkb.Checked)
                        {
                            try
                            {
                                Convert.ToInt32(remindPeriodTbx.Text);
                                Convert.ToInt32(remindDurationTbx.Text);
                            }
                            catch
                            {
                                MessageBox.Show("Введите целые числа");
                                return;
                            }
                            int period_value = Convert.ToInt32(remindPeriodTbx.Text);
                            int duration_value = Convert.ToInt32(remindDurationTbx.Text);
                            if(period_value<1|| duration_value < 1)
                            {
                                MessageBox.Show("Проверьте периоды напоминаний");
                                return;
                            }
                            if (remindTimePeriodType.SelectedIndex == 0)
                            {
                                period_sec = period_value;
                                if (remindTimeDurationType.SelectedIndex == 0)
                                {
                                    period_duration = duration_value;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 1)
                                {
                                    period_duration = duration_value * 60;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 2)
                                {
                                    period_duration = duration_value * 1440;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 3)
                                {
                                    period_duration = duration_value * 525600;
                                }
                            }
                            else if (remindTimePeriodType.SelectedIndex == 1)
                            {
                                period_sec = period_value * 60;
                                if (remindTimeDurationType.SelectedIndex == 0)
                                {
                                    period_duration = duration_value * 60;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 1)
                                {
                                    period_duration = duration_value * 1440;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 2)
                                {
                                    period_duration = duration_value * 525600;
                                }
                            }
                            else if (remindTimePeriodType.SelectedIndex == 2)
                            {
                                period_sec = period_value * 1440;
                                if (remindTimeDurationType.SelectedIndex == 0)
                                {
                                    period_duration = duration_value * 1440;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 1)
                                {
                                    period_duration = duration_value * 525600;
                                }
                            }
                            else if (remindTimePeriodType.SelectedIndex == 3)
                            {
                                period_sec = period_value * 525600;
                                if (remindTimeDurationType.SelectedIndex == 0)
                                {
                                    period_duration = duration_value * 525600;
                                }
                            }
                        }
                        if (remindTimeDurationType.SelectedIndex == 0)
                        {
                            if (period_sec > period_duration)
                            {
                                MessageBox.Show("Период повторений не может быть больше периода продолжительности напоминаний");
                                return;
                            }
                        }
                        TaskModel task = new TaskModel
                        {
                            text = remindTextTbx.Text,
                            next_date = GetDateZeroTime(datePck.Value).Add(GetTimeZeroSeconds(remindTimePck.Value).TimeOfDay),
                            remind_flag = true,
                            period_min = period_sec,
                            duration_min = period_duration,
                            price = 0
                        };
                        task.generateJobKey();

                        taskControler.Add(task);

                    }
                }
                else
                {
                    if (usualRdbtn.Checked)
                    {
                        editTask.text = remindTextTbx.Text;
                        editTask.next_date = datePck.Value;
                        editTask.remind_flag = false;
                        editTask.period_min = -1;
                        editTask.duration_min = -1;
                        //editTask.generateJobKey();

                        taskControler.Controler.Remove(editTask);

                        taskControler.Edit(editTask);
                    }
                    else
                    {
                        int period_sec = -1;
                        int period_duration = -1;
                        if (remindRepeatCkb.Checked)
                        {
                            try
                            {
                                Convert.ToInt32(remindPeriodTbx.Text);
                                Convert.ToInt32(remindDurationTbx.Text);
                            }
                            catch
                            {
                                MessageBox.Show("Введите целые числа");
                                return;
                            }
                            int period_value = Convert.ToInt32(remindPeriodTbx.Text);
                            int duration_value = Convert.ToInt32(remindDurationTbx.Text);
                            if (period_value < 1 || duration_value < 1)
                            {
                                MessageBox.Show("Проверьте периоды напоминаний");
                                return;
                            }
                            if (remindTimePeriodType.SelectedIndex == 0)
                            {
                                period_sec = period_value;
                                if (remindTimeDurationType.SelectedIndex == 0)
                                {
                                    period_duration = duration_value;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 1)
                                {
                                    period_duration = duration_value * 60;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 2)
                                {
                                    period_duration = duration_value * 1440;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 3)
                                {
                                    period_duration = duration_value * 525600;
                                }
                            }
                            else if (remindTimePeriodType.SelectedIndex == 1)
                            {
                                period_sec = period_value * 60;
                                if (remindTimeDurationType.SelectedIndex == 0)
                                {
                                    period_duration = duration_value * 60;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 1)
                                {
                                    period_duration = duration_value * 1440;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 2)
                                {
                                    period_duration = duration_value * 525600;
                                }
                            }
                            else if (remindTimePeriodType.SelectedIndex == 2)
                            {
                                period_sec = period_value * 1440;
                                if (remindTimeDurationType.SelectedIndex == 0)
                                {
                                    period_duration = duration_value * 1440;
                                }
                                else if (remindTimeDurationType.SelectedIndex == 1)
                                {
                                    period_duration = duration_value * 525600;
                                }
                            }
                            else if (remindTimePeriodType.SelectedIndex == 3)
                            {
                                period_sec = period_value * 525600;
                                if (remindTimeDurationType.SelectedIndex == 0)
                                {
                                    period_duration = duration_value * 525600;
                                }
                            }


                        }
                        if (remindTimeDurationType.SelectedIndex == 0)
                        {
                            if (period_sec > period_duration)
                            {
                                MessageBox.Show("Период повторений не может быть больше периода продолжительности напоминаний");
                                return;
                            }
                        }
                        editTask.text = remindTextTbx.Text;
                        editTask.next_date = GetDateZeroTime(datePck.Value).Add(GetTimeZeroSeconds(remindTimePck.Value).TimeOfDay);
                        editTask.remind_flag = true;
                        editTask.period_min = period_sec;
                        editTask.duration_min = period_duration;

                        taskControler.Controler.Remove(editTask);
                        taskControler.Controler.Add(editTask);

                        taskControler.Edit(editTask);

                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Текст заметки не может быть пустым");
            }

        }

        public static DateTime GetDateZeroTime(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
        }

        public static DateTime GetTimeZeroSeconds(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
        }

        private void cancelLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usualRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            remindTimePck.Visible = false;
            //remindRepeatCkb.Checked = false;
            remindRepeatCkb.Visible = false;
            remindTimeLbl.Visible = false;

            //remindRepeatCkb_CheckedChanged(null, null);
            remindPeriodTbx.Visible = false;
            remindTimePeriodType.Visible = false;
            remindDurationTbx.Visible = false;
            remindTimeDurationType.Visible = false;
            metroLabel4.Visible = false;
        }

        private void remindRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            remindTimePck.Visible = true;
            //remindRepeatCkb.Checked = false;
            remindRepeatCkb.Visible = true;
            remindTimeLbl.Visible = true;

            remindRepeatCkb_CheckedChanged(null, null);
        }

        private void remindRepeatCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (!remindRepeatCkb.Checked)
            {
                remindPeriodTbx.Visible = false;
                remindTimePeriodType.Visible = false;
                remindDurationTbx.Visible = false;
                remindTimeDurationType.Visible = false;
                metroLabel4.Visible = false;
            }
            else
            {
                remindPeriodTbx.Visible = true;
                remindTimePeriodType.Visible = true;
                remindDurationTbx.Visible = true;
                remindTimeDurationType.Visible = true;
                metroLabel4.Visible = true;
            }
        }

        private void remindTextTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void remindTextTbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (remindTextTbx.Text.Trim().Length < 1)
            {
                saveLink.Visible = false;
            }
            else
            {
                saveLink.Visible = true;
            }

        }

        private void remindTimePeriodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            remindTimeDurationType.Items.Clear();
            if (remindTimePeriodType.SelectedIndex == 0)
            {
                remindPeriodTbx.MaxLength = 8;
                object[] d = { "минут", "часов", "дней", "лет" };
                remindTimeDurationType.Items.AddRange(d);
                remindTimeDurationType.SelectedIndex = 0;
            }
            else if (remindTimePeriodType.SelectedIndex == 1)
            {
                remindPeriodTbx.MaxLength = 6;
                if (remindPeriodTbx.Text.Length > 6)
                {
                    remindPeriodTbx.Text = remindPeriodTbx.Text.Substring(remindPeriodTbx.Text.Length - 6);
                }
                object[] d = { "часов", "дней", "лет" };
                remindTimeDurationType.Items.AddRange(d);
                remindTimeDurationType.SelectedIndex = 0;
            }
            else if (remindTimePeriodType.SelectedIndex == 2)
            {
                remindPeriodTbx.MaxLength = 5;
                if (remindPeriodTbx.Text.Length > 5)
                {
                    remindPeriodTbx.Text = remindPeriodTbx.Text.Substring(remindPeriodTbx.Text.Length - 5);
                }
                object[] d = { "дней", "лет" };
                remindTimeDurationType.Items.AddRange(d);
                remindTimeDurationType.SelectedIndex = 0;
            }
            else if (remindTimePeriodType.SelectedIndex == 3)
            {
                remindPeriodTbx.MaxLength = 2;
                if (remindPeriodTbx.Text.Length > 2)
                {
                    remindPeriodTbx.Text = remindPeriodTbx.Text.Substring(remindPeriodTbx.Text.Length - 2);
                }
                object[] d = { "лет" };
                remindTimeDurationType.Items.AddRange(d);
                remindTimeDurationType.SelectedIndex = 0;
            }
        }

        private void remindTimeDurationType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (remindTimeDurationType.SelectedIndex == 0)
            {
                remindDurationTbx.MaxLength = 8;
            }
            else if (remindTimeDurationType.SelectedIndex == 1)
            {
                remindDurationTbx.MaxLength = 6;
                if (remindDurationTbx.Text.Length > 6)
                {
                    remindDurationTbx.Text = remindDurationTbx.Text.Substring(remindDurationTbx.Text.Length - 6);
                }
            }
            else if (remindTimeDurationType.SelectedIndex == 2)
            {
                remindDurationTbx.MaxLength = 5;
                if (remindDurationTbx.Text.Length > 5)
                {
                    remindDurationTbx.Text = remindDurationTbx.Text.Substring(remindDurationTbx.Text.Length - 5);
                }
            }
            else if (remindTimeDurationType.SelectedIndex == 3)
            {
                remindDurationTbx.MaxLength = 2;
                if (remindDurationTbx.Text.Length > 2)
                {
                    remindDurationTbx.Text = remindDurationTbx.Text.Substring(remindDurationTbx.Text.Length - 2);
                }
            }
        }
    }
}