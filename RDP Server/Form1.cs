using System;
using System.Windows.Forms;
using Microsoft.Win32;
using RDPConnectLib;


namespace RDP_Server
{

    public partial class Form1 : Form
    {
        ConnectServer server = new ConnectServer();

        public Form1()
        {
            InitializeComponent();

            const string exePath = "RDP Server.exe";
            const string pathRegistryKeyStartup ="SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

            using (RegistryKey registryKeyStartup =Registry.CurrentUser.OpenSubKey(pathRegistryKeyStartup, true))
            {
                registryKeyStartup.SetValue(exePath, string.Format("\"{0}\"", System.Reflection.Assembly.GetExecutingAssembly().Location));
            }

            server.OpenServer();

            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseClick);
            this.Resize += new EventHandler(this.Form1_Resize);
            
        }


        private void Form1_Resize(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try {

                MessageBox.Show("RDP Viewer \ncurrent connection information: \n"
                + Environment.OSVersion + "\n"
                + "Name ID:  " + Environment.MachineName + "\n"
                + "Public IP:  " + server.GetPublicIp() + "\n"
                + "Local IP:  " + server.GetLocalIp() + "\n"
                + "MAC:  " + server.GetMacAddress()); 

            }
            catch (Exception)
            {
                MessageBox.Show("RDP Viewer \ncurrent connection information: \n" + "Name ID: -  \n" + "Public IP: - \n" + "Local IP: - \n" + "MAC: - ");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Cipher-Git/RDP-Viewer");
        }
    }
}

