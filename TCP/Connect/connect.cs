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
using TheApp;


namespace Connect
{
    public partial class connect : Form
    {
        public static string ip = "192.168.0.10";
        public static string port = "8910";
        TheApp.Form1 App =  new TheApp.Form1();

        public connect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHost.Text = ip;
            txtPort.Text = port;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
            this.Hide();
            
            App.Show();
            
        }

        private void ConnectAsClient()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse(txtHost.Text), Convert.ToInt32(txtPort.Text));
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

   
    }
}
