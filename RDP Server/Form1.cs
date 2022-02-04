using System;
using System.Windows.Forms;
using Microsoft.Win32;
using RDPConnectLib;


namespace RDP_Server
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            ConnectServer server = new ConnectServer();
            server.OpenServer();
            string ExePath = Application.ExecutablePath;
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            //RegistryKey reg_1 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
            reg.SetValue("RDP Server.exe", ExePath);
            reg.Close();

            notifyIcon1.Visible = false; 
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseClick);
            this.Resize += new EventHandler(this.Form1_Resize);
            labelName.Text = "Name ID:        " + Environment.MachineName;


        }

        
        private void Form1_Resize(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;

            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;

        }
        
        
    }
}

