using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class AuthorizationForm : MetroFramework.Forms.MetroForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            GetToken.DocumentCompleted += GetToken_DocumentCompleted;
            GetToken.Navigate("https://oauth.vk.com/authorize?client_id=6619305&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.52");
        }

        private void GetToken_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (GetToken.Url.ToString().IndexOf("access_token=") != 0)
            {
                GetUserToken();
            }
        }

        private void GetUserToken()
        {
            char[] Symbols = { '=', '&' };
            string[] URL = GetToken.Url.ToString().Split(Symbols);
            //File.WriteAllText("UserInf.txt", URL[1] + "\n");
            //File.AppendAllText("UserInf.txt", URL[5]);
            this.Visible = false;
        }
    }
}
