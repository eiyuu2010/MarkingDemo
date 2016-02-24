using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.webBrowser1.ObjectForScripting = new ObjectScripting(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            //path = Application.CommonAppDataPath;
            //path = Application.ExecutablePath;
            //path = Application.LocalUserAppDataPath;
            //path = Application.StartupPath;
            //path = Application.UserAppDataPath;
            path = path + "\\test_ENQUETE\\index.html";
            if (System.IO.File.Exists(path))
            {
                Uri uri = new Uri(path);
                webBrowser1.Navigate(uri);
            }
            else
            {
                this.lbMessage.Text = "File Not Found!";
            }
        }

        private void cmdShowDraw_Click(object sender, EventArgs e)
        {
            DrawB drawForm = new DrawB();
            drawForm.Show();
        }
    }
}
