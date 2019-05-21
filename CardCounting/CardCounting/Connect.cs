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

namespace CardCounting
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0X13;
            server.StringEncoder = Encoding.UTF8;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
            }
            else
            {
                //System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(HostTxt.Text));
                // server.Start(ip, Convert.ToInt32(PortTxt.Text));

                Player player = new Player();
                player.Show();
                this.Hide();

                
                
               
            }
        }
    }
}
