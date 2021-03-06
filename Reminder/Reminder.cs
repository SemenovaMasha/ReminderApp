﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Reminder_desktop_application
{
    public partial class Reminder : MetroFramework.Forms.MetroForm
    {
        /*  TODO:
         *  Lazy
         */

        public TaskControler taskControler = new TaskControler(new FileStreamer(), new NotificationControler());
        public List<Task> allDayTaks;
        public Dictionary<string, List<Task>> tasksForEeachDay;
        public Task taskToNotify;

        public Reminder()
        {
            InitializeComponent();

            //реинжиниринг напоминаний - если повторяющееся событие, и дата прошла, подвинуть дату на период, пока дата не станет > текущей или > его duration
            taskControler.reingin();

            Reminder_ResizeEnd(null, null);

            taskControler.TaskAppeared += SubscribeForNotification;
            PrintDayTasks(DateTime.Now.ToShortDateString());

            taskControler.Add(taskControler.getDailyTasks(DateTime.Now));

            int j = 0;
        }

        private void Reminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            taskControler.Stop();

        }
        
        private void Reminder_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShootOutNotification(object sender, EventArgs e)
        {

        }
        private void notificationIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notificationIcon_BalloonTipClicked(object sender, EventArgs e)
        {
        }

        private void SubscribeForNotification(Task task)
        {
            task.TaskStarted += ShootOutNotification;
        }

        private void PrintDayTasks(string date)
        {
            notesDataGrid.Columns.Clear();
            
            DateTime myDate = DateTime.ParseExact(date, "dd.MM.yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);

            notesDataGrid.AutoGenerateColumns = false;
            notesDataGrid.DataSource = taskControler.getDailyTasks(myDate);

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "text";
            column1.HeaderText = "Текст";
            column1.DataPropertyName = "text";
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.FillWeight = 60;
            column1.ReadOnly = true;
            notesDataGrid.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "time";
            column2.HeaderText = "Время";
            column2.DataPropertyName = "time";
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.FillWeight = 15;
            column2.ReadOnly = true;
            notesDataGrid.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "price";
            column3.HeaderText = "Цена";
            column3.DataPropertyName = "price";
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.FillWeight = 15;
            notesDataGrid.Columns.Add(column3);


        }

        private void PrintingTheTask(Task task)
        {
            
            notesDataGrid.Rows.Add(task.text,task.remind_flag?task.next_date.ToShortTimeString():"",task.price);

        }

        private void reminderDateTime_ValueChanged(object sender, EventArgs e)
        {
            PrintDayTasks(datePicker.Value.ToShortDateString());
        }

        private void reminderTasksView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void notificationForm_FormClosing(object sender, EventArgs e)
        {
            PrintDayTasks(datePicker.Value.ToShortDateString());
        }
        private void reminderDateTime_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("%{DOWN}");
        }
        
        private void Reminder_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            NewTaskForm form = new NewTaskForm(taskControler,datePicker.Value);
            form.ShowDialog();
            
            PrintDayTasks(datePicker.Value.ToShortDateString());

            int j = 0;
        }

        private void reminderDateTime_ValueChanged_1(object sender, EventArgs e)
        {
            PrintDayTasks(datePicker.Value.ToShortDateString());

        }

        private void prevDayBtn_Click(object sender, EventArgs e)
        {
            datePicker.Value= datePicker.Value.AddDays(-1);
        }

        private void nextDayBtn_Click(object sender, EventArgs e)
        {

            datePicker.Value= datePicker.Value.AddDays(1);
        }

        private void notesDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2)
            {
                NewTaskForm form = new NewTaskForm(taskControler, ((List<Task>)notesDataGrid.DataSource)[notesDataGrid.SelectedRows[0].Index]);
                form.ShowDialog();

                PrintDayTasks(datePicker.Value.ToShortDateString());
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            //if (notesDataGrid.SelectedRows[0].Index>=0)
            {
                //DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                {
                    try
                    {
                        Task temp = ((List<Task>)notesDataGrid.DataSource)[notesDataGrid.SelectedRows[0].Index];
                        taskControler.Remove(temp);
                        PrintDayTasks(datePicker.Value.ToShortDateString());
                    }
                    catch (RemoveTaskException exp)
                    {
                        MessageBox.Show(exp.ToString());
                    }
                }
            }
        }

        private void notesDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Task temp = ((List<Task>)notesDataGrid.DataSource)[e.RowIndex];
            temp.price = Convert.ToDouble(notesDataGrid[2, e.RowIndex].Value.ToString().Replace(".",","));

            taskControler.Edit(temp);
        }
    }
}
