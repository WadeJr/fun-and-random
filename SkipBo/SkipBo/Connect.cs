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


namespace SkipBo
{
    public partial class Connect : Form
    {
        public static string ip = "192.168.0.7";
        public static string port = "8910";

        public Connect()
        {
            InitializeComponent();
        }

        private void Connect_Load(object sender, EventArgs e)
        {
            txtHost.Text = ip;
            txtPort.Text = port;
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

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            Thread mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
            Play play = new Play("Player 2", txtHost.Text, txtPort.Text);
            play.Show();
            this.Hide();

            
        }
    }
}
