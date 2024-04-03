using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Ftp_Server
{
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }
        public ManageUsersForm(string username, string passwd)
        {
            usernameTextBox.Text = username;
            passwordTextBox.Text = passwd;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            MongoClient conn = new MyMongoDBConnect().connection;
            var accountCollection = conn.GetDatabase("users").GetCollection<Account>("account");
            string encrypt_passwd = BCrypt.Net.BCrypt.EnhancedHashPassword(passwordTextBox.Text);
            accountCollection.InsertOne(new Account(usernameTextBox.Text, encrypt_passwd, roleComboBox.Text, virtualPathTextBox.Text, locationTextBox.Text));
        }

        private void locationTextBox_Enter(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    locationTextBox.Text = fbd.SelectedPath;
                }
            } 
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            roleComboBox.SelectedIndex = 1;
            virtualPathTextBox.Text = "/";
        }
    }
}
