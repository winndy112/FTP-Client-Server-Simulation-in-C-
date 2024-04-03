namespace Ftp_Client
{
    partial class MainForm
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
            this.inforServerConnectPanel = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.mainsiteContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inforServerConnectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainsiteContainer)).BeginInit();
            this.mainsiteContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inforServerConnectPanel
            // 
            this.inforServerConnectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inforServerConnectPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.inforServerConnectPanel.Controls.Add(this.connectButton);
            this.inforServerConnectPanel.Controls.Add(this.passwdTextBox);
            this.inforServerConnectPanel.Controls.Add(this.usernameTextBox);
            this.inforServerConnectPanel.Controls.Add(this.hostTextBox);
            this.inforServerConnectPanel.Controls.Add(this.passwdLabel);
            this.inforServerConnectPanel.Controls.Add(this.portTextBox);
            this.inforServerConnectPanel.Controls.Add(this.usernameLabel);
            this.inforServerConnectPanel.Controls.Add(this.portLabel);
            this.inforServerConnectPanel.Controls.Add(this.hostLabel);
            this.inforServerConnectPanel.Location = new System.Drawing.Point(0, 28);
            this.inforServerConnectPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inforServerConnectPanel.Name = "inforServerConnectPanel";
            this.inforServerConnectPanel.Size = new System.Drawing.Size(1018, 39);
            this.inforServerConnectPanel.TabIndex = 1;
            this.inforServerConnectPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.inforServerConnectPanel_Paint);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(781, 6);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(113, 26);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Location = new System.Drawing.Point(648, 6);
            this.passwdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwdTextBox.Multiline = true;
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(115, 28);
            this.passwdTextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(439, 6);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(115, 28);
            this.usernameTextBox.TabIndex = 6;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(53, 6);
            this.hostTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hostTextBox.Multiline = true;
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(115, 28);
            this.hostTextBox.TabIndex = 4;
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(565, 12);
            this.passwdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(70, 16);
            this.passwdLabel.TabIndex = 3;
            this.passwdLabel.Text = "Password:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(225, 6);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portTextBox.Multiline = true;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(115, 28);
            this.portTextBox.TabIndex = 5;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(355, 12);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 16);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(181, 12);
            this.portLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 16);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "Port:";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(8, 12);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(38, 16);
            this.hostLabel.TabIndex = 0;
            this.hostLabel.Text = "Host:";
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainContainer.Location = new System.Drawing.Point(0, 70);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.mainsiteContainer);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.mainContainer.Size = new System.Drawing.Size(1018, 518);
            this.mainContainer.SplitterDistance = 345;
            this.mainContainer.SplitterWidth = 1;
            this.mainContainer.TabIndex = 2;
            // 
            // mainsiteContainer
            // 
            this.mainsiteContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainsiteContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainsiteContainer.Location = new System.Drawing.Point(0, 0);
            this.mainsiteContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainsiteContainer.Name = "mainsiteContainer";
            // 
            // mainsiteContainer.Panel1
            // 
            this.mainsiteContainer.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainsiteContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // mainsiteContainer.Panel2
            // 
            this.mainsiteContainer.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainsiteContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainsiteContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainsiteContainer.Size = new System.Drawing.Size(1018, 345);
            this.mainsiteContainer.SplitterDistance = 338;
            this.mainsiteContainer.SplitterWidth = 1;
            this.mainsiteContainer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1019, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconnectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 591);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.inforServerConnectPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "FTP Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.inforServerConnectPanel.ResumeLayout(false);
            this.inforServerConnectPanel.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainsiteContainer)).EndInit();
            this.mainsiteContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel inforServerConnectPanel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.SplitContainer mainsiteContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

