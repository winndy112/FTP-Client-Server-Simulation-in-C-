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
        
        private void StartListening()
        {
            try
            {
                listener = new TcpListener(System.Net.IPAddress.Parse("0.0.0.0"), control_port);
                listener.Start();
                MessageBox.Show("FTP server started listening on port " + control_port);
                connection.Visible = false;
                label1.Text = "Connected to " + host;

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

        private void HandleConnection(object obj)
        {
            
            TcpClient client = (TcpClient)obj;
            try
            {
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
                    // Ví dụ: In dữ liệu lên màn hình
                    string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                  
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
    }
}
