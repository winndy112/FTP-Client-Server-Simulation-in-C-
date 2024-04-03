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
using System.Net;
using System.Net.Sockets;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.IO;

namespace Ftp_Server
{
    public partial class ManageUsersForm : Form
    {
        NetworkStream currentStream;
        public ManageUsersForm()
        {
            InitializeComponent();
        }
        public ManageUsersForm(NetworkStream stream, string username, string passwd)
        {
            usernameTextBox.Text = username;
            passwordTextBox.Text = passwd;
            currentStream = stream;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            MongoClient conn = new MyMongoDBConnect().connection;
            var accountCollection = conn.GetDatabase("users").GetCollection<Account>("account");

            var filter = Builders<Account>.Filter.Eq("username", usernameTextBox.Text);
            var result = accountCollection.Find(filter).FirstOrDefault();
            if (result == null) { 
                string encrypt_passwd = BCrypt.Net.BCrypt.EnhancedHashPassword(passwordTextBox.Text);
                accountCollection.InsertOne(new Account(usernameTextBox.Text, encrypt_passwd, roleComboBox.Text, virtualPathTextBox.Text, locationTextBox.Text));
            }
            else
            {
                byte[] response = Encoding.ASCII.GetBytes("200 Register successfully.");
                currentStream.Write(response, 0, response.Length);
            }
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
