using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP;


namespace Application
{
    public partial class application : Form
    {
        ServerFunctions functions = new ServerFunctions();

        public application()
        {
            InitializeComponent();
        }

        private void application_Load(object sender, EventArgs e)
        {

        }
    }
}
