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
using System.Threading;

namespace SelenP2
{
    public partial class Form1 : Form
    {

        FirefoxDriver driver;
        IWebElement element;
        public static Thread thread;
       

        private string url = "https://clickclickclick.click";
        //button class name
        private string name = "button"; //"timer"; //"timer_span_next";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                execute();
            });
            thread.Start();
        }
        public void execute()
        {
            var service = FirefoxDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl(url);
            element = driver.FindElement(By.ClassName(name));
            while (true)
            {
                try
                {
                    element.Click();
                    Thread.Sleep(100000);
                }
                catch (Exception) { }
                
            }
        }
    }
}






/*
                    


                    while (go)
                    {
                        try
                        {
                           
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
}*/