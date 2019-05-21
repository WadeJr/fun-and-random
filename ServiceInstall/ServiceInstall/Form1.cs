using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmdLib;

namespace ServiceInstall
{
    public partial class Form1 : Form
    {
        private string file = null;
        private string folder = null;

        Cmd cmd = new Cmd();

        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = fileTxt.Text= fileDialog.FileName;
                folder = folderTxt.Text = System.IO.Path.GetDirectoryName(file);
            }

        }

        private void installBtn_Click(object sender, EventArgs e)
        {
            //cmd.WriteCommand(@"echo hello > c:\Users\wade2\Desktop\heel.txt");
            //cmd.WriteCommand(@"cd ..\..\..\..\..\..\..\..\..\");
            
            cmd.WriteCommand(@"cd ..");
            Debug.AutoFlush = true;
            Debug.Indent();
            Debug.WriteLine(" * *****************************************");
            Debug.WriteLine(cmd.Output);
            Debug.WriteLine("------------------------------------------");
           // cmd.WriteCommand("cd " + folder.Substring(3));
           // cmd.WriteCommand(@"c:\windows\microsoft.net\framework\v4.0.30319\installutil.exe " + file);

        }

        private void uninstallBtn_Click(object sender, EventArgs e)
        {
            cmd.WriteCommand("C:");
            cmd.WriteCommand("cd " + folder.Substring(3));
            cmd.WriteCommand(@":\windows\microsoft.net\framework\v4.0.30319\installutil.exe /u " + file);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmd.EndProcess();
        }
    }
}
