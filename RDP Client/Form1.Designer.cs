namespace RDP_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EnterKey = new System.Windows.Forms.ToolStripButton();
            this.ConnectServer = new System.Windows.Forms.ToolStripButton();
            this.CloseServer = new System.Windows.Forms.ToolStripButton();
            this.toolStripDecktopSize = new System.Windows.Forms.ToolStripButton();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.openKey = new System.Windows.Forms.OpenFileDialog();
            this.RDPViewer = new AxRDPCOMAPILib.AxRDPViewer();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RDPViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnterKey,
            this.ConnectServer,
            this.CloseServer,
            this.toolStripDecktopSize,
            this.Exit,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(347, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(290, 32);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EnterKey
            // 
            this.EnterKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EnterKey.Image = ((System.Drawing.Image)(resources.GetObject("EnterKey.Image")));
            this.EnterKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EnterKey.Name = "EnterKey";
            this.EnterKey.Size = new System.Drawing.Size(28, 29);
            this.EnterKey.Text = "Enter Key";
            this.EnterKey.Click += new System.EventHandler(this.EnterKey_Click);
            // 
            // ConnectServer
            // 
            this.ConnectServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConnectServer.Image = ((System.Drawing.Image)(resources.GetObject("ConnectServer.Image")));
            this.ConnectServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectServer.Name = "ConnectServer";
            this.ConnectServer.Size = new System.Drawing.Size(28, 29);
            this.ConnectServer.Text = "Connect";
            this.ConnectServer.ToolTipText = "Connect to server";
            this.ConnectServer.Click += new System.EventHandler(this.ConnectServer_Click);
            // 
            // CloseServer
            // 
            this.CloseServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseServer.Image = ((System.Drawing.Image)(resources.GetObject("CloseServer.Image")));
            this.CloseServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseServer.Name = "CloseServer";
            this.CloseServer.Size = new System.Drawing.Size(28, 29);
            this.CloseServer.Text = "Disconect";
            this.CloseServer.ToolTipText = "Close server session";
            this.CloseServer.Click += new System.EventHandler(this.CloseServer_Click);
            // 
            // toolStripDecktopSize
            // 
            this.toolStripDecktopSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDecktopSize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDecktopSize.Image")));
            this.toolStripDecktopSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDecktopSize.Name = "toolStripDecktopSize";
            this.toolStripDecktopSize.Size = new System.Drawing.Size(28, 29);
            this.toolStripDecktopSize.Text = "Decktop size";
            this.toolStripDecktopSize.ToolTipText = "Screen display mode";
            this.toolStripDecktopSize.Click += new System.EventHandler(this.DecktopSizeClient);
            // 
            // Exit
            // 
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 29);
            this.Exit.Text = "Close client";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 29);
            this.toolStripLabel1.Text = "Server ID";
            // 
            // openKey
            // 
            this.openKey.FileName = "openKey";
            // 
            // RDPViewer
            // 
            this.RDPViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RDPViewer.Enabled = true;
            this.RDPViewer.Location = new System.Drawing.Point(0, 0);
            this.RDPViewer.Name = "RDPViewer";
            this.RDPViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RDPViewer.OcxState")));
            this.RDPViewer.Size = new System.Drawing.Size(1024, 768);
            this.RDPViewer.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.RDPViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "Form1";
            this.Text = "Client";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RDPViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton CloseServer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Exit;
        private System.Windows.Forms.ToolStripButton toolStripDecktopSize;
        private System.Windows.Forms.OpenFileDialog openKey;
        private System.Windows.Forms.ToolStripButton EnterKey;
        private System.Windows.Forms.ToolStripButton ConnectServer;
        private AxRDPCOMAPILib.AxRDPViewer RDPViewer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

