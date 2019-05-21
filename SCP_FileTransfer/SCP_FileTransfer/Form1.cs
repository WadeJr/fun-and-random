using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using OpenQA.Selenium.Winium;
using System.Threading;
using WinSCP;


namespace SCP_FileTransfer
{
    public partial class Form1 : Form
    {
        
        public string ubuntu = @"c:\Users\wade2\AppData\Local\Microsoft\WindowsApps\CanonicalGroupLimited.UbuntuonWindows_79rhkp1fndgsc\ubuntu.exe";
        public string cmd = @"C:\Users\wade2\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Windows PowerShell\Windows PowerShell.lnk";// @"C:\Windows\System32\cmd.exe";

          WiniumDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fpTxt.Text = "~/nand.tar.gz";
          
            if(Class1.username != "")
            {
                sshTxt.Text = Class1.username;
            }
            if(Class1.password != "")
            {
                passwordTxt.Text = Class1.password;
            }
        }
        private WiniumDriver StartDriver(string path)
        {
            var service = WiniumDriverService.CreateDesktopService(@"C:\Users\wade2\Desktop\Hacking\Fun\Winium\");
            service.HideCommandPromptWindow = true;
            var options = new DesktopOptions { ApplicationPath = path };
            WiniumDriver driver = new WiniumDriver(service, options);
            return driver;
        }


        private void Write(string text)
        {
           // driver.Keyboard.SendKeys(text + "\n");
            //Thread.Sleep(8000);
         //   driver.Keyboard.SendKeys(passwordTxt.Text + "\n");
        }
    

        private void browseBtn_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.FolderBrowserDialog();
            if(FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                localFpTxt.Text = FD.SelectedPath;
            }
        }

        private string BuildReceive()
        {
            return "scp -r " + sshTxt.Text + "@sc.rc.usf.edu:"+  fpTxt.Text + " " + fixPath()   + @"\" + stripName();
        }
  
        private void recieveBtn_Click(object sender, EventArgs e)
        {
            SessionOptions sessionOptions = new SessionOptions();
            sessionOptions.HostName = "sc.rc.usf.edu";
            sessionOptions.UserName = "smithw";
            sessionOptions.Password = Class1.password;
            sessionOptions.PortNumber = 22;
            sessionOptions.Protocol = Protocol.Scp;
            sessionOptions.GiveUpSecurityAndAcceptAnySshHostKey = true;
            Session session = new Session();
            session.ExecutablePath = @"C:\Program Files (x86)\WinSCP\WinSCP.exe";
            session.Open(sessionOptions);

            TransferOptions transfer = new TransferOptions();
            transfer.TransferMode = TransferMode.Binary;
           
            session.GetFiles(fpTxt.Text, localFpTxt.Text + @"\" + stripName(), false, transfer);
           /* driver = StartDriver(cmd);
            Thread.Sleep(5000);

            Thread thread = new Thread(() =>
            {
                Write(BuildReceive());
            });
            thread.Start();*/


        }

        private string stripName()
        {
            string path = fpTxt.Text;
            string[] name = path.Split('/');
            try
            {
                return name[name.Count() - 1];
            }
            catch(Exception){ return "file"; }
            
        }
        
        private string fixPath()
        {
            string at = @"\";
            string path = localFpTxt.Text;
            string[] fix = path.Split(Convert.ToChar(at));
            

     
            if(fix.Count() > 0)
            {
                if(fix[0] == "C:" || fix[0] == "c:")
                {
                    fix[0] = "c";
                    string newPath = "";
                    for(int i = 0; i < fix.Count() - 1; i++)
                    {
                        newPath += fix[i] + at;
                    }
                    newPath += fix[fix.Count() - 1];
                    return newPath;
                }
            }
            return path;
        }
    }
}



/* private string BuildSend()
   {
       return "scp -r " + localFpTxt.Text + " " + sshTxt.Text + "@sc.rc.usf.edu:" + fpTxt.Text;
   }

   private void sendBtn_Click(object sender, EventArgs e)
   {
       Write(BuildSend());
   }
   */
