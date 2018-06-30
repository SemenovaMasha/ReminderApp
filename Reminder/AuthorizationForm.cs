using Reminder_desktop_application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class AuthorizationForm : MetroFramework.Forms.MetroForm
    {
        TaskServiceDB context;
        public AuthorizationForm(TaskServiceDB context)
        {
            this.context = context;
            InitializeComponent();




        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            //GetToken.Document.Cookie = "";
            //Process.Start("cmd.exe", "/C RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 255");
            //GetToken.Navigate("javascript:void((function(){var a,b,c,e,f;f=0;a=document.cookie.split('; ');for(e=0;e<a.length&&a[e];e++){f++;for(b='.'+location.host;b;b=b.replace(/^(?:%5C.|[^%5C.]+)/,'')){for(c=location.pathname;c;c=c.replace(/.$/,'')){document.cookie=(a[e]+'; domain='+b+'; path='+c+'; expires='+new Date((new Date()).getTime()-1e11).toGMTString());}}}})())");
            //GetToken.Navigate("https://oauth.vk.com/authorize?client_id=6619305&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=messages,offline&response_type=token&v=5.52");
            
        }

        private void GetToken_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //GetToken.Document.Cookie ="remixlang=0; remixsid=; expires=Fri, 31 Dec 1999 23:59:59 GMT;";
            //if (GetToken.Url.ToString().Contains("access_token="))
            //{
            //    char[] Symbols = { '=', '&' };
            //    string[] URL = GetToken.Url.ToString().Split(Symbols);
            //    token = URL[1];
            //}
        }
        string token;

        public string getToken()
        {
            return token;
        }

        UserSettingsModel model;

        private void okBtn_Click(object sender, EventArgs e)
        {

            model = context.getUserSettings();
            WorkToVk workVk = new WorkToVk();
            workVk.loginAuthorization(loginTbx.Text, passwordTbx.Text);
            model.vkToken = Crypter.Encrypt(workVk.token);
            model.vkUser = workVk.userId.ToString();

            context.editToken(workVk.token, workVk.userId);
            try
            {
                string tokken = context.getToken();
                string iduser = model.vkUser;

                workVk.start(tokken, iduser, model.secretWord, context);
            }
            catch
            {
                MessageBox.Show("Авторизация не удалась. Пройдите заново авторизацию VK.");
            }

            this.Close();
        }
    }
}
