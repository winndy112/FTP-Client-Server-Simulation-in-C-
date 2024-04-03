﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ftp_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void loadForm(object Panel, object Form)
        {
            Panel p = Panel as Panel;
            if (p.Controls.Count > 0)
            {
                p.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);
            p.Tag = f;
            f.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width), 
                Convert.ToInt32(0.5 *workingRectangle.Height));

            this.Location = new System.Drawing.Point(10, 10);
            loadForm(mainContainer.Panel2, new TranferSiteForm());
            loadForm(mainsiteContainer.Panel1, new LocalSiteForm());
            loadForm(mainsiteContainer.Panel2, new RemoteSiteForm());
                
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            /* Đăng nhập và kết nối ở đây */
        }

        // Không để làm gì cả
        private void inforServerConnectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Kết nối lại ở đây */
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Ngắt kết nối ở đây */
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Đăng kí ở đây */
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Cài đặt tài khoản ở đây */
        }

        /* 
         * Upload nam trong LocalSiteForm
         * Download nam trong RemoteSiteForm
         */

    }
}
