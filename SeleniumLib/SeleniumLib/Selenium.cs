using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumLib
{
    public class Selenium
    {

        private FirefoxDriver driver;
        private IWebElement element;

        public Selenium()
        {
            IWebElement element;
            var service = FirefoxDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver = new FirefoxDriver(service);


        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Write(string text)
        {
            element.SendKeys(text);
        }

        public void FindElementBy_Id(string id)
        {
            element = driver.FindElement(By.Id(id));
        }

        public void FindElementBy_ClassName(string className)
        {
            element = driver.FindElement(By.ClassName(className));
        }

        public void FindElementBy_LinkText(string linkText)
        {
            element = driver.FindElementByLinkText(linkText);
        }

        public void FindElementBy_XPath(string xpath)
        {
            element = driver.FindElementByXPath(xpath);
        }

        public void FindElementBy_CssSelector(string css)
        {
            element = driver.FindElementByCssSelector(css);
        }


        public void PressKey(string keyName)
        {
            //This probably won't work read its message to find real way

        }

        public void Click()
        {
            element.Click();
        }

        public string GetUrl()
        {
            if (driver.Url != null)
            {
                return driver.Url;
            }
            return "";
        }

        public void Close()
        {
            driver.Quit();
        }

        public void SwitchTabs(int tabIndex)
        {
            driver.SwitchTo().Window(driver.WindowHandles[tabIndex]); // close the tab
        }

        public void CloseTab(int tabIndex)
        {
            driver.SwitchTo().Window(driver.WindowHandles[tabIndex]).Close();
        }

        public void WaitForUrl(string url)
        {
            while (GetUrl() != url) ;
        }

        public void WaitForPartialUrl(string url)
        {
            while (GetUrl().Substring(0, url.Length) != url) ;
        }


    }
}
