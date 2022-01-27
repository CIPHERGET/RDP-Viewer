using System;
using System.Windows.Forms;
using RDPCOMAPILib;
using System.IO;
using Microsoft.Win32;
using System.Configuration;
//using WinSCP;
using System.Drawing;

namespace RDP_Server
{

    public partial class Form1 : Form
    {
        public static RDPSession currentSession = null;

        public static void createSession()
        {

            currentSession = new RDPSession();

        }

        public void Connect(RDPSession session)
        {
            
                session.OnAttendeeConnected += Incoming;
                session.Open();
            
            
        }

        public static void Disconnect(RDPSession session)
        { 
            session.Close();
        }

        public static string GetConnectionString(RDPSession session, String authString, string group, string password, int clientLimit)
        {
            IRDPSRAPIInvitation invitation = session.Invitations.CreateInvitation
            (authString, group, password, clientLimit);
            return invitation.ConnectionString;
        }

        private static void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_MAX;

        }

        
        public Form1()
        {
            InitializeComponent();

            string ExePath = Application.ExecutablePath;
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            //RegistryKey reg_1 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run");
            reg.SetValue("RDP Server.exe", ExePath);
            reg.Close();

            notifyIcon1.Visible = false; 
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseClick);
            this.Resize += new EventHandler(this.Form1_Resize);
            labelName.Text = "Name ID:        " + Environment.MachineName;

            timer.Tick += new EventHandler(RefreshLabel);
            timer.Interval = 5000; // Здесь измени интервал на 5000 (5 сек)
            timer.Start();
        }


        Timer timer = new Timer();

        public void RefreshLabel(object sender, EventArgs e)
        {
            if (Internet.CheckConnection())
            {
                label2.Text = "INTERNET OK";
                pictureBox2.BackColor = Color.FromArgb(57, 180, 74);
                if (currentSession == null)
                {
                    System.Threading.Thread.Sleep(5000);
                    StartServer();
                }

            }
            else 
            {
                label2.Text = "INTERNET ERROR";
                pictureBox2.BackColor = Color.FromArgb(255, 56, 37); 
                if (currentSession != null)
                {
                    //Disconnect(currentSession);
                    Application.Restart();
                }

            }

        }

        //private static int WinScpConect()
        //{
        //    try
        //    {
        //        string pathIp = ConfigurationManager.AppSettings.Get("IP");
        //        // Setup session options
        //        SessionOptions sessionOptions = new SessionOptions
        //        {
        //            Protocol = Protocol.Sftp,
        //            HostName = pathIp,
        //            UserName = "server",
        //            Password = "password",
        //            SshHostKeyFingerprint = "ssh-**************************************************",
        //        };

        //        using (Session session = new Session())
        //        {
        //            // Connect
        //            session.Open(sessionOptions);

        //            // Download files
        //            TransferOptions transferOptions = new TransferOptions();
        //            transferOptions.TransferMode = TransferMode.Binary;

        //            TransferOperationResult transferResult;
        //            string pathDir = ConfigurationManager.AppSettings.Get("dir");
        //            transferResult = session.PutFiles(pathDir, @"/KEY", false, transferOptions);

        //            // Throw on any error
        //            transferResult.Check();

        //            // Print results
        //            foreach (TransferEventArgs transfer in transferResult.Transfers)
        //            {
        //                Console.WriteLine("Download of {0} succeeded", transfer.FileName);
        //            }
        //        }

        //        return 0;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error: {0}", e);
        //        return 1;
        //    }
        //}
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


        private void StartServer()
        {
            //Disconnect(currentSession);
            createSession();
            Connect(currentSession);

            string pathDir = ConfigurationManager.AppSettings.Get("dir");
            string pathPass = ConfigurationManager.AppSettings.Get("Pass");
            DirectoryInfo dirInfo = new DirectoryInfo(pathDir);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            string serverName = Environment.MachineName;
            string key = GetConnectionString(currentSession, serverName, "", pathPass, 5);

            File.WriteAllText(pathDir + serverName + ".bin", key);

           // WinScpConect();
        }
        
    }
}

