using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandLine
{
    public partial class Form1 : Form
    {
        public Process proc;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\wade2\Desktop\Hacking\Fun\SynologyService\SynologyService\bin\Debug\SynologyService.exe";
            string folder = @"C:\Users\wade2\Desktop\Hacking\Fun\SynologyService\SynologyService\bin\Debug";
            Process process = new Process();
            StartProcess();
            //WriteCommand( "whoami");
            WriteCommand( "ifconfig");
            

            //cmd.WriteCommand(@"echo hello > c:\Users\wade2\Desktop\heel.txt");
            WriteCommand(@"cd ..\..\..\..\..\..\..\..\..\");

           
        
              WriteCommand("cd " + folder.Substring(3));
              WriteCommand(@"c:\windows\microsoft.net\framework\v4.0.30319\installutil.exe " + file);
            EndProcess();
        }

        private void WriteCommand(Process process, string text)
        {
            process.StandardInput.WriteLine(text);
            process.StandardInput.Flush();
        }

        private void WriteCommand(string text)
        {
            proc.StandardInput.WriteLine(text);
            proc.StandardInput.Flush();
        }

        private void EndProcess(Process process)
        {
            process.StandardInput.Close();
            process.WaitForExit();
            consoleTxt.AppendText(process.StandardOutput.ReadToEnd());
        }


        private void EndProcess()
        {
            proc.StandardInput.Close();
            proc.WaitForExit();
            consoleTxt.AppendText(proc.StandardOutput.ReadToEnd());
        }

        private void StartProcess()
        {
            proc = new Process();
            proc.StartInfo.FileName = "powershell.exe";

            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }

        private void StartProcess(Process process)
        {
            process.StartInfo.FileName = "ubuntu.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
                       process.Start();
        }

    }
}
