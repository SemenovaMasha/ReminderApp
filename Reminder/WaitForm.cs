using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reminder
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            this.TopMost = true;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона  
            this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
            this.ShowInTaskbar = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
