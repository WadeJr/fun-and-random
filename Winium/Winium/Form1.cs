using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Winium;



namespace Winium
{
    public partial class Form1 : Form
    {
        private string Calculator = @"C:\Users\wade2\Desktop\Calculator.lnk";
        private string ControlPanel = @"C:\Users\wade2\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\System Tools\Control Panel.lnk";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            WiniumDriver driver = StartDriver(Calculator);
            Thread.Sleep(3000);
            driver.Keyboard.SendKeys("7 + 5 =");
           // ICoordinates coordinates = new ICoordinates();
           // driver.Mouse.MouseMove(driver.FindElementById("")., Left + 25, 79);

            Thread.Sleep(5000);



            //try
            //{
            //    driver.FindElementById("Credential Manager").Click();
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("id");
            //}

            //try
            //{
            //    driver.FindElementByLinkText("Credential Manager").Click();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("linkText");
            //}

            //try
            //{
            //    driver.FindElementByName("Credential Manager").Click();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("name");
            //}

            //try
            //{
            //    driver.FindElementByXPath("Credential Manager").Click();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("xpath");
            //}

            try
            {
               // driver.Mouse.ContextClick.Name 
               // driver.Mouse.ContextClick.("Credential Manager").Click();
            }
            catch (Exception)
            {
                //MessageBox.Show("linkText");
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


    }
}
