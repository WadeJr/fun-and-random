using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Support;
//using OpenQA.Selenium.Interactions;
using System.Threading;


namespace Selenium
{
    public partial class Selenium : Form
    {
        FirefoxDriver driver;
        public static Thread thread;
        public static Thread thread2;
        public static bool go;


        private string url = "https://www.boat-ed.com/florida/course_content/course/10101002/section/700138748/";
        //button class name
        private string name = "next"; 

        public Selenium()
        {
            InitializeComponent();
        }

        private void Selenium_Load(object sender, EventArgs e)
        {
            stopResetBtn.Enabled = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            var service = FirefoxDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver = new FirefoxDriver(service);

           
            stopResetBtn.Enabled = true;
            thread = new Thread(() =>
            {
                Execute();
            });
            thread.Start();


        }



        private void Execute()
        {
            if (urlText.Text != "")
            {
                url = urlText.Text;
            }
            if (idText.Text != "")
            {
                name = idText.Text;
            }

            
            IWebElement element;



            Action action = () => consoleTxt.AppendText(url + "\n");
            this.BeginInvoke(action);

            Action action1 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
            this.BeginInvoke(action1);

            Action action2 = () => consoleTxt.ScrollToCaret();
            this.BeginInvoke(action2);

            go = true;

            while (go)
            {

                try
                {

                    driver.Navigate().GoToUrl(url);


                    while (go)
                    {
                        try
                        {
                            //extra
                            if(url == @"https://www.boat-ed.com/site/login/")
                            {
                               // element = driver.FindElement(By.Id("LoginForm_username"));
                                //element.SendKeys("wade2slick");
                             //   Thread.Sleep(2000);
                               // element = driver.FindElement(By.Id("LoginForm_password"));
                                //element.SendKeys("password123");
                               // Thread.Sleep(2000);
                                element = driver.FindElement(By.ClassName("form-actions"));
                                element.Click();
                                Thread.Sleep(5000);
                                

                            }

                            //end extra
                            element = driver.FindElement(By.ClassName(name));
                            element.Click();
                            Thread.Sleep(5000);
                            if (url != driver.Url)
                            {
                                url = driver.Url;


                                Action action3 = () => consoleTxt.AppendText("SUCCESS\n");
                                this.BeginInvoke(action3);

                                Action action4 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                                this.BeginInvoke(action4);

                                Action action5 = () => consoleTxt.ScrollToCaret();
                                this.BeginInvoke(action5);

                                break;
                            }
                           

                        }
                        catch (Exception)
                        {
                            

                            if (url != driver.Url)
                            { 
                                url = driver.Url;

                            }

                            Action action6 = () => consoleTxt.AppendText("New Url: " + url + "\n");
                            this.BeginInvoke(action6);

                            Action action7 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                            this.BeginInvoke(action7);

                            Action action8 = () => consoleTxt.ScrollToCaret();
                            this.BeginInvoke(action8);
                        }

                    }



                    startBtn.Enabled = false;
                    break;



                }
                catch (Exception)
                {



                    Action action9 = () => consoleTxt.AppendText("FAILED\n");
                    this.BeginInvoke(action9);

                    Action action10 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                    this.BeginInvoke(action10);

                    Action action11 = () => consoleTxt.ScrollToCaret();
                    this.BeginInvoke(action11);
                }
            }


            //Continue

            while (go)
            {

                while (go)
                {
                    try
                    {
                        element = driver.FindElement(By.ClassName(name));
                        element.Click();
                        Thread.Sleep(5000);
                        if (url != driver.Url)
                        {
                            url = driver.Url;

                            Action action3 = () => consoleTxt.AppendText("SUCCESS\n");
                            this.BeginInvoke(action3);

                            Action action4 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                            this.BeginInvoke(action4);

                            Action action5 = () => consoleTxt.ScrollToCaret();
                            this.BeginInvoke(action5);

                            break;
                        }

                    }
                    catch (Exception)
                    {

                        Action action6 = () => consoleTxt.Text += ".";
                        this.BeginInvoke(action6);

                        Action action7 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                        this.BeginInvoke(action7);

                        Action action8 = () => consoleTxt.ScrollToCaret();
                        this.BeginInvoke(action8);
                    }
                }
            }



        }

        private void Resume()
        {
            


            IWebElement element;



            Action action = () => consoleTxt.AppendText(url + "\n");
            this.BeginInvoke(action);

            Action action1 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
            this.BeginInvoke(action1);

            Action action2 = () => consoleTxt.ScrollToCaret();
            this.BeginInvoke(action2);

            go = true;

            while (go)
            {

                try
                {

                  //  driver.Navigate().GoToUrl(url);


                    while (go)
                    {
                        try
                        {
                            element = driver.FindElement(By.ClassName(name));
                            element.Click();
                            Thread.Sleep(5000);
                            if (url != driver.Url)
                            {
                                url = driver.Url;


                                Action action3 = () => consoleTxt.AppendText("SUCCESS\n");
                                this.BeginInvoke(action3);

                                Action action4 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                                this.BeginInvoke(action4);

                                Action action5 = () => consoleTxt.ScrollToCaret();
                                this.BeginInvoke(action5);

                                break;
                            }

                        }
                        catch (Exception)
                        {


                            if (url != driver.Url)
                            {
                                url = driver.Url;

                            }

                            Action action6 = () => consoleTxt.AppendText("New Url: " + url + "\n");
                            this.BeginInvoke(action6);

                            Action action7 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                            this.BeginInvoke(action7);

                            Action action8 = () => consoleTxt.ScrollToCaret();
                            this.BeginInvoke(action8);
                        }

                    }

                    
                    break;

                }
                catch (Exception)
                {



                    Action action9 = () => consoleTxt.AppendText("FAILED\n");
                    this.BeginInvoke(action9);

                    Action action10 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                    this.BeginInvoke(action10);

                    Action action11 = () => consoleTxt.ScrollToCaret();
                    this.BeginInvoke(action11);
                }
            }


            //Continue

            while (go)
            {

                while (go)
                {
                    try
                    {
                        element = driver.FindElement(By.ClassName(name));
                        element.Click();
                        Thread.Sleep(5000);
                        if (url != driver.Url)
                        {
                            url = driver.Url;

                            Action action3 = () => consoleTxt.AppendText("SUCCESS\n");
                            this.BeginInvoke(action3);

                            Action action4 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                            this.BeginInvoke(action4);

                            Action action5 = () => consoleTxt.ScrollToCaret();
                            this.BeginInvoke(action5);

                            break;
                        }

                    }
                    catch (Exception)
                    {

                        Action action6 = () => consoleTxt.Text += ".";
                        this.BeginInvoke(action6);

                        Action action7 = () => consoleTxt.SelectionStart = consoleTxt.TextLength;
                        this.BeginInvoke(action7);

                        Action action8 = () => consoleTxt.ScrollToCaret();
                        this.BeginInvoke(action8);
                    }
                }
            }



        }



        private void stopResetBtn_Click(object sender, EventArgs e)
        {
            if(stopResetBtn.Text == "Stop")
            {
                go = false;
                stopResetBtn.Text = "Resume";
            }
            else
            {
                stopResetBtn.Text = "Stop";
                thread2 = new Thread(() =>
                {
                    Resume();
                });
                thread2.Start();
            }

        }
    }
}

       /* private void Continue(FirefoxDriver driver)
        {
            IWebElement element;
            driver.Navigate().GoToUrl(url);



            while (true)
            {
                try
                {
                    element = driver.FindElement(By.Id(name));
                    element.Click();
                    Thread.Sleep(5000);
                    if (url != driver.Url)
                    {
                        url = driver.Url;
                        WriteToConsole("SUCCESS\n");

                        break;
                    }

                }
                catch (Exception)
                {

                    WriteToConsole(".");
                }
            }

            Continue(driver);
        }

        private void WriteToConsole(string text)
        {
            consoleTxt.Text += text + "\n";
            ScrollToBottom();
        }


        private void ScrollToBottom()
        {
            consoleTxt.SelectionStart = consoleTxt.TextLength;
            consoleTxt.ScrollToCaret();
        }
    }
}
/*private void startBtn_Click(object sender, EventArgs e)
        {
            //url = urlText.Text;
            //name = idText.Text;
            consoleTxt.Text += url + "\n";
            try
            {
                var driver = new FirefoxDriver();
                
                
                driver.Navigate().GoToUrl(url);
                IWebElement element;

               while (true)
                {
                    try
                    {
                        element = driver.FindElement(By.Id(name));
                        element.Click();
                        break;
                    }
                    catch (Exception)
                    {

                        consoleTxt.Text += ".";
                    }
                }
               
                startBtn.Enabled = false;
                Thread.Sleep(5000);
                consoleTxt.Text += "SUCCESS\n";
                Continue(driver.Url, driver);
              

            }
            catch(Exception)
            {
                consoleTxt.Text += "FAILED\n";
            }

            
           

        }

       private void Continue(string newUrl, FirefoxDriver driver)
        {
            url = newUrl;
            while (true)
            {
                try
                {
                    
                    driver.Navigate().GoToUrl(url);
                    IWebElement element;

                    while (true)
                    {
                        try
                        {
                            element = driver.FindElement(By.Id(name));
                            element.Click();
                            Thread.Sleep(10000);
                            break;
                        }
                        catch (Exception)
                        {

                            consoleTxt.Text += ".";
                        }
                    }

                    
                    Thread.Sleep(5000);
                    consoleTxt.Text += "SUCCESS\n";
                    break;
                }
                catch (Exception)
                {
                    consoleTxt.Text += "FAILED\n";
                }
            }
            Continue(url, driver);
        }*/

//button
/* //url = urlText.Text;
    //name = idText.Text;
    consoleTxt.Text += url + "\n";
    try
    {
        var driver = new FirefoxDriver();


        driver.Navigate().GoToUrl(url);
        IWebElement element;

       while (true)
        {
            try
            {
                element = driver.FindElement(By.Id(name));
                element.Click();
                break;
            }
            catch (Exception)
            {

                consoleTxt.Text += ".";
            }

        }

        startBtn.Enabled = false;
        Thread.Sleep(5000);
        consoleTxt.Text += "SUCCESS\n";
        Continue(driver.Url, driver);


    }
    catch(Exception)
    {
        consoleTxt.Text += "FAILED\n";
    }

    */
