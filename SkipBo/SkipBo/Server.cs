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

namespace SkipBo
{
    public partial class Server : Form
    {
        public static string ip = "192.168.0.7";
        public static string port = "8910";
        TCP.ServerFunctions functions = new TCP.ServerFunctions();

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            txtHost.Text = ip;
            txtPort.Text = port;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread tcpServerRunThread = new Thread(new ThreadStart(TcpServerRun));
            tcpServerRunThread.Start();
            Play play = new Play("Player 1", txtHost.Text, txtPort.Text);
            play.Show();

        }

        private void TcpServerRun()
        {
            try
            {
                TcpListener tcpListener = new TcpListener(IPAddress.Parse(txtHost.Text), Convert.ToInt32(txtPort.Text));
                tcpListener.Start();
                updateUI("Server started..." + System.Environment.NewLine);

                while (true)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    Thread tcpHandlerThread = new Thread(new ParameterizedThreadStart(tcpHandler));
                    tcpHandlerThread.Start(client);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to start the server. Change the host address or " +
                    "the port number and try again.");
            }

        }


        private void tcpHandler(object client)
        {
            TcpClient mClient = (TcpClient)client;
            NetworkStream stream = mClient.GetStream();
            byte[] message = new byte[1024];
            stream.Read(message, 0, message.Length);
            updateUI(Encoding.ASCII.GetString(message));
            functions.FunctionChecks(txtStatus);
            stream.Close();
            mClient.Close();

        }


        private void updateUI(string s)
        {
            Func<int> del = delegate ()
            {
                txtStatus.AppendText(s);
                ScrollToBottom();
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
