using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using MongoDB.Driver;
using MongoDB.Bson;
using System.CodeDom;
using MongoDB.Bson.Serialization.Attributes;

namespace Ftp_Server
{
    public partial class MainForm : Form
    {
        private string host;
        private int port;
        private string password;
        private int control_port = 30;
        private TcpListener listener;
        private Thread listenThread;
        public MainForm()
        {
            InitializeComponent();
        }

        private void connection_Click(object sender, EventArgs e)
        {
            using (var connectionForm = new ConnectForm())
            {
                if (connectionForm.ShowDialog() == DialogResult.OK)
                {   
                    host = connectionForm.host;
                    port = connectionForm.port;
                    password = connectionForm.password;
                    StartListening();
                }
            }
        }
        private void CreateHeaders_viewLog()
        {
            // Clear existing columns
            ViewLog.Columns.Clear();

            // Add new columns
            ViewLog.Columns.Add("Date/Time");
            ViewLog.Columns.Add("Type");
            ViewLog.Columns.Add("Message");
            

            // Set column widths
            ViewLog.Columns[0].Width = 200;
            ViewLog.Columns[1].Width = 200;
            ViewLog.Columns[2].Width = 500;
            
            ViewLog.View = View.Details;
        }
        private void CreateHeaders_viewSession()
        {
            // Clear existing columns
            viewSession.Columns.Clear();
            // Add new columns
            viewSession.Columns.Add("Date/Time");
            viewSession.Columns.Add("SessionID");
            viewSession.Columns.Add("Host");
            viewSession.Columns.Add("User");
            // Set column widths
            viewSession.Columns[0].Width = 200;
            viewSession.Columns[1].Width = 200;
            viewSession.Columns[2].Width = 200;
            viewSession.Columns[2].Width = 200;

            viewSession.View = View.Details;
        }

        private void StartListening()
        {
            try
            {
                listener = new TcpListener(System.Net.IPAddress.Parse("0.0.0.0"), control_port);
                listener.Start();
                MessageBox.Show("FTP server started listening on port " + control_port);
                connection.Visible = false;
                label1.Text = "Connected to " + host;
                CreateHeaders_viewLog();
                CreateHeaders_viewSession();
                listenThread = new Thread(new ThreadStart(AcceptConnections));
                listenThread.Start();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting FTP server: " + ex.Message);
            }
        }
        private void AcceptConnections()
        {
            while (true)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    // Start a new thread to handle the connection
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleConnection));
                    clientThread.Start(client);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error accepting connection: " + ex.Message);
                }
            }
        }

        
        /*
            REGISTER <username> <password>
         */
        private bool register(string command)
        {
            string[] myParams = command.Split(' ');
            string username, passwd;
            if (myParams.Length > 2) 
            {
                username = myParams[1];
                passwd = myParams[2];
                try
                {
                    new ManageUsersForm(username, passwd).ShowDialog();
                    return true;
                }
                catch
                {
                    return false;
                }
                //accountCollection.InsertOne();
            }
            else
            {
                return false;
            }
        }

        private void HandleConnection(object obj)
        {
            
            TcpClient client = (TcpClient)obj;
            try
            {
                string username_client, password_client; 
                // Lấy dữ liệu luồng mạng của client
                NetworkStream stream = client.GetStream();
                host = Dns.GetHostName();
                
                // Chuỗi chào mừng
                string welcomeMessage = "Connected to" + Dns.GetHostByName(host).AddressList[0].ToString()+  "\r\n";

                // Chuyển chuỗi chào mừng thành mảng byte
                byte[] welcomeBytes = Encoding.ASCII.GetBytes(welcomeMessage);

                // Gửi chuỗi chào mừng đến client
                stream.Write(welcomeBytes, 0, welcomeBytes.Length);

                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // Xử lý dữ liệu đọc được từ client ở đây
                    
                    string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (receivedData.StartsWith("REGISTER"))
                    {
                        if (register(receivedData))
                        {

                        }
                    }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error handling connection: " + ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUsersForm().ShowDialog();
        }
    }

    public class MyMongoDBConnect
    {
        const string connectionUri = "mongodb+srv://22521168:TO82PIYRxNeYBd18@cluster0.x3ovogy.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
        public MongoClient connection;
        public MyMongoDBConnect()
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            this.connection = new MongoClient(settings);
            // Send a ping to confirm a successful connection
        }
    }
    public class Account
    {

        public ObjectId _id { get; set; }

        [BsonElement("username")]
        public string username { get; set; }
        [BsonElement("passwd")]
        public string passwd { get; set; }
        [BsonElement("role")]
        public string role { get; set; }
        [BsonElement("virtualpath")]
        public string virtualpath { get; set; }
        [BsonElement("location")]
        public string location { get; set; }
        public Account(string _username, string _passwd, string _role, string _virtualpath, string _location)
        {
            this.username = _username;
            this.passwd = _passwd;
            this.role = _role;
            this.virtualpath = _virtualpath;
            this.location = _location;
        }
    }
}

