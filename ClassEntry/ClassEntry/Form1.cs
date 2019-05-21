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

namespace ClassEntry
{
    public partial class Entry : Form
    {
        FirefoxDriver driver;
        public static Thread thread;
        public static Thread thread2;
        public static bool go;


        private string url = "https://my.usf.edu/";
        //button class name
        private string name = "/html/body/div[3]/form/input[1]";




        public Entry()
        {
            InitializeComponent();
        }

        private void Entry_Load(object sender, EventArgs e)
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

                            if (url == "https://webauth.usf.edu/login?service=https%3A%2F%2Fshibboleth.usf.edu%2Fidp%2FAuthn%2FExtCas%3Fconversation%3De1s2%26entityId%3Dhttp%3A%2F%2Fadfs.usf.edu%2Fadfs%2Fservices%2Ftrust&entityId=http%3A%2F%2Fadfs.usf.edu%2Fadfs%2Fservices%2Ftrust")
                            {
                                element = driver.FindElement(By.Id("username"));
                                element.SendKeys(Program.user);
                                Thread.Sleep(1000);
                                element = driver.FindElement(By.Id("password"));
                                element.SendKeys(Program.password);
                                Thread.Sleep(1000);
                                element = driver.FindElement(By.Id("btn-submit"));
                                element.Click();
                            }
                            else if(url == "https://my.usf.edu/Pages/Home.aspx" )
                            {
                                driver.Navigate().GoToUrl("https://bannersso.usf.edu/ssomanager/c/SSB");
                                Thread.Sleep(2000);
                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/twbkwbis.P_GenMenu?name=bmenu.P_StuMainMnu");
                                Thread.Sleep(2000);
                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/twbkwbis.P_GenMenu?name=bmenu.P_RegMnu");
                                Thread.Sleep(2000);
                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm");
                                


                                url = "https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm";
                            }
                            else if(url == "https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm")
                            {
                                element = driver.FindElement(By.Id("term_id"));
                                element.SendKeys("spr");
                                Thread.Sleep(1000);
                               

                                element.SendKeys(OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Enter);
                                Thread.Sleep(3000);
                                element.SendKeys(OpenQA.Selenium.Keys.Enter);
                                element.Click();
                       
                                url = "https://usfonline.admin.usf.edu/pls/prod/bwcklibs.P_StoreTerm";
                            }
                            else if(url ==  "https://usfonline.admin.usf.edu/pls/prod/bwcklibs.P_StoreTerm")
                            {

                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb");
                                url = "https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb";
                    
                            }
                            else if (url == "https://usfonline.admin.usf.edu/pls/prod/csched.p_addfromsearch" || url == "https://usfonline.admin.usf.edu/pls/prod/csched.p_addfromsearch")
                            {
                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb");
                                url = "https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb";
                                Thread.Sleep(1000);
                            }
                            else
                            {





                                element = driver.FindElement(By.XPath(name));
                                element.Click();
                            //    Thread.Sleep(500);
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
                        if (url == "https://webauth.usf.edu/login?service=https%3A%2F%2Fshibboleth.usf.edu%2Fidp%2FAuthn%2FExtCas%3Fconversation%3De1s2%26entityId%3Dhttp%3A%2F%2Fadfs.usf.edu%2Fadfs%2Fservices%2Ftrust&entityId=http%3A%2F%2Fadfs.usf.edu%2Fadfs%2Fservices%2Ftrust")
                        {
                            element = driver.FindElement(By.Id("username"));
                            element.SendKeys(Program.user);
                            Thread.Sleep(1000);
                            element = driver.FindElement(By.Id("password"));
                            element.SendKeys(Program.password);
                            Thread.Sleep(1000);
                            element = driver.FindElement(By.Id("btn-submit"));
                            element.Click();
                        }
                        else if (url == "https://my.usf.edu/Pages/Home.aspx")
                        {
                            driver.Navigate().GoToUrl("https://bannersso.usf.edu/ssomanager/c/SSB");
                            Thread.Sleep(2000);
                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/twbkwbis.P_GenMenu?name=bmenu.P_StuMainMnu");
                            Thread.Sleep(2000);
                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/twbkwbis.P_GenMenu?name=bmenu.P_RegMnu");
                            Thread.Sleep(2000);
                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm");



                            url = "https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm";
                        }
                        else if (url == "https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm")
                        {
                            element = driver.FindElement(By.Id("term_id"));
                            element.SendKeys("spr");
                            Thread.Sleep(1000);


                            element.SendKeys(OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Enter);
                            Thread.Sleep(3000);
                            element.SendKeys(OpenQA.Selenium.Keys.Enter);
                            element.Click();

                            url = "https://usfonline.admin.usf.edu/pls/prod/bwcklibs.P_StoreTerm";
                        }
                        else if (url == "https://usfonline.admin.usf.edu/pls/prod/bwcklibs.P_StoreTerm")
                        {

                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb");
                            url = "https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb";

                        }
                        else if (url == "https://usfonline.admin.usf.edu/pls/prod/csched.p_addfromsearch" || url == "https://usfonline.admin.usf.edu/pls/prod/csched.p_addfromsearch")
                        {
                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb");
                            url = "https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb";
                            Thread.Sleep(1000);
                        }

                        else
                        {


                            element = driver.FindElement(By.Name(name));
                            element.Click();
                         //   Thread.Sleep(500);
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

                            if (url == "https://webauth.usf.edu/login?service=https%3A%2F%2Fshibboleth.usf.edu%2Fidp%2FAuthn%2FExtCas%3Fconversation%3De1s2%26entityId%3Dhttp%3A%2F%2Fadfs.usf.edu%2Fadfs%2Fservices%2Ftrust&entityId=http%3A%2F%2Fadfs.usf.edu%2Fadfs%2Fservices%2Ftrust")
                            {
                                element = driver.FindElement(By.Id("username"));
                                element.SendKeys(Program.user);
                                Thread.Sleep(1000);
                                element = driver.FindElement(By.Id("password"));
                                element.SendKeys(Program.password);
                                Thread.Sleep(1000);
                                element = driver.FindElement(By.Id("btn-submit"));
                                element.Click();
                            }
                            else if (url == "https://my.usf.edu/Pages/Home.aspx")
                            {
                                driver.Navigate().GoToUrl("https://bannersso.usf.edu/ssomanager/c/SSB");
                                Thread.Sleep(2000);
                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/twbkwbis.P_GenMenu?name=bmenu.P_StuMainMnu");
                                Thread.Sleep(2000);
                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/twbkwbis.P_GenMenu?name=bmenu.P_RegMnu");
                                Thread.Sleep(2000);
                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm");



                                url = "https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm";
                            }
                            else if (url == "https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm")
                            {
                                element = driver.FindElement(By.Id("term_id"));
                                element.SendKeys("spr");
                                Thread.Sleep(1000);


                                element.SendKeys(OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Enter);
                                Thread.Sleep(3000);
                                element.SendKeys(OpenQA.Selenium.Keys.Enter);
                                element.Click();

                                url = "https://usfonline.admin.usf.edu/pls/prod/bwcklibs.P_StoreTerm";
                            }
                            else if (url == "https://usfonline.admin.usf.edu/pls/prod/bwcklibs.P_StoreTerm")
                            {

                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb");
                                url = "https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb";

                            }
                            else if(url == "https://usfonline.admin.usf.edu/pls/prod/csched.p_addfromsearch" || url == "https://usfonline.admin.usf.edu/pls/prod/csched.p_addfromsearch")
                            {
                                driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb");
                                url = "https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb";
                                Thread.Sleep(1000);
                            }
                            else
                            {


                                element = driver.FindElement(By.Name(name));
                                element.Click();
                                //Thread.Sleep(500);
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
                        if (url == "https://webauth.usf.edu/login?service=https%3A%2F%2Fshibboleth.usf.edu%2Fidp%2FAuthn%2FExtCas%3Fconversation%3De1s2%26entityId%3Dhttp%3A%2F%2Fadfs.usf.edu%2Fadfs%2Fservices%2Ftrust&entityId=http%3A%2F%2Fadfs.usf.edu%2Fadfs%2Fservices%2Ftrust")
                        {
                            element = driver.FindElement(By.Id("username"));
                            element.SendKeys(Program.user);
                            Thread.Sleep(1000);
                            element = driver.FindElement(By.Id("password"));
                            element.SendKeys(Program.password);
                            Thread.Sleep(1000);
                            element = driver.FindElement(By.Id("btn-submit"));
                            element.Click();
                        }
                        else if (url == "https://my.usf.edu/Pages/Home.aspx")
                        {
                            driver.Navigate().GoToUrl("https://bannersso.usf.edu/ssomanager/c/SSB");
                            Thread.Sleep(2000);
                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/twbkwbis.P_GenMenu?name=bmenu.P_StuMainMnu");
                            Thread.Sleep(2000);
                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/twbkwbis.P_GenMenu?name=bmenu.P_RegMnu");
                            Thread.Sleep(2000);
                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm");



                            url = "https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm";
                        }
                        else if (url == "https://usfonline.admin.usf.edu/pls/prod/bwskflib.P_SelDefTerm")
                        {
                            element = driver.FindElement(By.Id("term_id"));
                            element.SendKeys("spr");
                            Thread.Sleep(1000);


                            element.SendKeys(OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Enter);
                            Thread.Sleep(3000);
                            element.SendKeys(OpenQA.Selenium.Keys.Enter);
                            element.Click();

                            url = "https://usfonline.admin.usf.edu/pls/prod/bwcklibs.P_StoreTerm";
                        }
                        else if (url == "https://usfonline.admin.usf.edu/pls/prod/bwcklibs.P_StoreTerm")
                        {

                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb");
                            url = "https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb";

                        }
                        else if (url == "https://usfonline.admin.usf.edu/pls/prod/csched.p_addfromsearch" || url == "https://usfonline.admin.usf.edu/pls/prod/csched.p_addfromsearch")
                        {
                            driver.Navigate().GoToUrl("https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb");
                            url = "https://usfonline.admin.usf.edu/pls/prod/csched.p_regs_ssb";
                            Thread.Sleep(1000);
                        }

                        else
                        {

                            element = driver.FindElement(By.Name(name));
                            element.Click();
                          //  Thread.Sleep(500);
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
            if (stopResetBtn.Text == "Stop")
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
