using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmazonConsole;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace AmazonVolume
{
    public partial class Form1 : Form
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        

        public Form1()
        {
            InitializeComponent();
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
           
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            volumeLbl.Text = Amazon.GetVolume(textBox1.Text);
        }

        private void bestSellersBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.amazon.com/Best-Sellers/zgbs");
        }

        private void tableBtn_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void keywordsBtn_Click(object sender, EventArgs e)
        {
            Keywords keywords = new Keywords();
            keywords.Show();
        }

        private void trendsBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://trends.google.com/trends/?geo=US");
        }
    }
}
