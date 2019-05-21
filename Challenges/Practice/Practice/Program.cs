using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using DirectoriesLib;
using TimeFunctions;
using SeleniumLib;
using NetworkLib;

namespace Practice
{
    class Program
    {
        public static void Sleep(int time)
        {
            int num = time * 1000;
            Thread.Sleep(num);
        }


        static void Main(string[] args)
        {
            #region Selenium
            /*
               string url = "https://usflearn.instructure.com/";

               Selenium selenium = new Selenium();

               try
               {
                   #region Sign in

                   selenium.NavigateToUrl(url);
                   Sleep(1);
                   selenium.FindElementBy_Id("username");
                   selenium.Write(username);
                   Sleep(1);
                   selenium.FindElementBy_Id("password");
                   Sleep(1);
                   selenium.Write(password);
                   Sleep(2);
                   selenium.FindElementBy_Id("btn-submit");
                   Sleep(1);
                   selenium.Click();
                   #endregion

                   #region Switch to Cengage
                   selenium.WaitForUrl("https://usflearn.instructure.com/");
                   Sleep(1);


                   //Assignment
                   selenium.NavigateToUrl("https://usflearn.instructure.com/courses/1316721/assignments/6262844");
                   Sleep(2);
                   //Path to Assignment
                   selenium.FindElementBy_XPath("/html/body/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/form/div/div[1]/div/button");
                   selenium.Click();
                   Sleep(2);

                   selenium.SwitchTabs(1); 
                   #endregion

                   selenium.WaitForPartialUrl("https://www.cengage.com/");
                   Sleep(8);

                   //Go to course
                   selenium.FindElementBy_XPath("/html/body/div[2]/div/div/top-course-info/div/div/div/div[1]/coursepage" +
                          "info-icon/div/div[2]/div/button");
                   selenium.Click();

                   //Select start new attempt
                   //class name: btn btn-default btn-block btn-success
                   //css selector: .ActivityOverview__action > button:nth-child(1)
                   //xpath: /html/body/div[3]/div/div[3]/div/section[1]/div[1]/div/div[2]/div/div[1]/div/div[2]/div[2]/button



               }
               catch (Exception)
               {

               }


               ////Class name
               //selenium.FindElementBy_XPath("/html/body/div[2]/div[2]/div/div[2]/div[1]/div/div/div[4]/div/div[4]/div/a/div");
               //selenium.Click();
               //Sleep(2);

               ////Assignments
               //selenium.FindElementBy_XPath("/html/body/div[2]/div[2]/div[2]/div[2]/nav/ul/li[5]/a");
               //selenium.Click();
               //Sleep(2);






               Console.Read();
               selenium.Close();*/
            #endregion

            Network network = new Network();
            var users = network.Ping_all();

            try
            {
                foreach (var user in users)
                {
                    try
                    {
                        Console.WriteLine(user);
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }



            Console.WriteLine("done");
            Console.ReadKey();


        }


    }
}
