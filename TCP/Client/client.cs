using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace Client
{
    public partial class client : Form
    {
        public static string ip = "192.168.0.10";
        public static string port = "8910";

        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            txtHost.Text = ip;
            txtPort.Text = port;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
            ScrollToBottom();
        }

        private void ConnectAsClient()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse(txtHost.Text), Convert.ToInt32(txtPort.Text));
                updateUI("Connected to server.");
                NetworkStream stream = client.GetStream();
                string s = "Client is connected";
                byte[] message = Encoding.ASCII.GetBytes(s + System.Environment.NewLine);
                stream.Write(message, 0, message.Length);
                stream.Close();
                client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect to server.");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Thread mThread = new Thread(new ThreadStart(SendMessageToServer));
            mThread.Start();
            ScrollToBottom();
        }
        private void SendMessageToServer(string text)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse(txtHost.Text), Convert.ToInt32(txtPort.Text));
                updateUI("Message Sent.");
                NetworkStream stream = client.GetStream();
                byte[] message = Encoding.ASCII.GetBytes(text + System.Environment.NewLine);
                stream.Write(message, 0, message.Length);
                stream.Close();
                client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to send message to server.");
            }
        }

        private void SendMessageToServer()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse(txtHost.Text), Convert.ToInt32(txtPort.Text));
                updateUI("Message Sent.");
                NetworkStream stream = client.GetStream();
                byte[] message = Encoding.ASCII.GetBytes(txtMessage.Text + System.Environment.NewLine);
                stream.Write(message, 0, message.Length);
                stream.Close();
                client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to send message to server.");
            }
        }

        private void updateUI(string s)
        {
            Func<int> del = delegate ()
            {
                txtStatus.AppendText(s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }

        private void ScrollToBottom()
        {
            txtStatus.SelectionStart = txtStatus.TextLength;
            txtStatus.ScrollToCaret();
        }




    }
}












/*
 *     SimpleTcpClient Client;
        public static string ip = "172.16.121.64";
        public static string port = "8910";

        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
            Client.DataReceived += Client_DataRecieved;
            txtHost.Text = ip;
            txtPort.Text = port;
        }

        private void Client_DataRecieved(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString.Trim();
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            Client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
            Client.WriteLine("Client Connected." + "\r\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text + "\r\n";
            message.Trim();
            Client.WriteLine("this is message: " + message);
            Client.WriteLine("This is just write line: " + txtMessage.Text + "\r\n");
           // Client.WriteLineAndGetReply(txtMessage.Text + "\r\n", TimeSpan.FromSeconds(1));
        }
*/
