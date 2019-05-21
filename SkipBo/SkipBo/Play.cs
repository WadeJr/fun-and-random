using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SkipBo
{
    public partial class Play : Form
    {
        string Player, Host, Port, text;
        TcpClient client;
       

        public Play(string player, string host, string port)
        {
            Player = player;
            Host = host;
            Port = port;
            InitializeComponent();
        }

        private void Player1C4_Load(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            text = Player + " clicked P1";
            Thread thread = new Thread(new ThreadStart(SendMessageToServer));
            thread.Start();
        }

        private void SendMessageToServer()
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse(Host), Convert.ToInt32(Port));
                NetworkStream stream = client.GetStream();
                byte[] message = Encoding.ASCII.GetBytes(text + System.Environment.NewLine);
                stream.Write(message, 0, message.Length);
                stream.Close();
                client.Close();
            }
            catch (Exception)
            { }
        }
    }
}
