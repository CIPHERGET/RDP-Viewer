using System;
using System.Windows.Forms;
using AxRDPCOMAPILib;
using System.IO;
using System.Drawing;

namespace RDP_Client
{
    public partial class Form1 : Form
    {

        //[DllImport("user32.dll")]
        //static extern int ShowCursor(bool bShow);
        public Form1()
        {
            InitializeComponent();
             
        }

        public static void Connect(string invitation, AxRDPViewer display, string userName, string password)
        {  
            display.Connect(invitation, userName, password); 
        }

        public static void Disconnect(AxRDPViewer display)
        {
            display.Disconnect();
            display = null;
            //ShowCursor(true);
        }

        private void CloseServer_Click(object sender, EventArgs e)
        {
            Disconnect(this.RDPViewer);
           
            EnterKey.Enabled = true;
            toolStripTextBox.Visible = true;

            toolStripLabel1.Text = "Server ID:";
            toolStripLabel1.ForeColor = Color.Black;
        }

        private async void ConnectServer_Click(object sender, EventArgs e)
        {
            try
            {

                string path = openKey.FileName;
                    using (StreamReader sr = new StreamReader(path))
                    {
                     Connect(await sr.ReadToEndAsync(), RDPViewer, "", toolStripTextBox.Text);
                    EnterKey.Enabled = false;
                    toolStripTextBox.Visible = false;
                    toolStripLabel1.Text = "Server: " + Path.GetFileNameWithoutExtension(path);
                        toolStripLabel1.ForeColor = Color.DarkGreen;

                    //ShowCursor(false);

                }



            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to the Server \n Не выбран сервер");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DecktopSizeClient(object sender, EventArgs e)
        {
            if (RDPViewer.SmartSizing == false)
            {
               RDPViewer.SmartSizing = true;             
            }
            else
            {
                RDPViewer.SmartSizing = false; 
            }
        }

        private void EnterKey_Click(object sender, EventArgs e)
        {
            openKey.Filter = "Files key(*.bin)|*.bin";
            openKey.Multiselect = false;
            if (openKey.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
