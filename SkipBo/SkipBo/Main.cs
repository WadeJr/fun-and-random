using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkipBo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void HostBtn_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
            Hide();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            connect.Show();
            Hide();
        }
    }
}
