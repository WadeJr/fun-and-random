using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeleniumLib;

namespace AutoOrder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void wingBtn_Click(object sender, EventArgs e)
        {
            Selenium selenium = new Selenium();
            selenium.NavigateToUrl("https://www.wingstop.com/location/wingstop-135-tampa-fl-33612/menu/by-the-piece/10-wings");



            selenium.FindElementBy_ClassName("ng-star-inserted");
            selenium.Click();

            selenium.FindElementBy_XPath("/html/body/div/div/div/app-component/app-location-product/div/main/form/section/app-produ" +
                "ct-group-card[5]/div/div[1]/div/div/div/h5");
            selenium.Click();

            selenium.FindElementBy_ClassName("/html/body/div/div/div/app-component/app-location-pr" +
                "oduct/div/main/form/section/app-product-group-card[6]/div/div[1]/div/div/div/h5");
            selenium.Click();

            selenium.FindElementBy_XPath("/html/body/div[1]/div/div/app-component/app-location-product/div/main/form/section/app-" +
                "product-group-card[1]/div/div[2]/div/div/div/div/div/app-product-variant-card[3]/div/label/div");

            selenium.Click();

            selenium.FindElementBy_XPath("/html/body/div[1]/div/div/app-component/app-location-product/div/main/form/section/app-" +
                "product-group-card[2]/div/div[2]/div/div/div/div[4]/app-product-option/div/label");

            selenium.Click();

            selenium.FindElementBy_XPath("/html/body/div[1]/div/div/app-component/app-location-product/div/main/form/section/app" +
                "-product-group-card[6]/div/div[2]/div/div/div[1]/app-product-option/div/label");

            selenium.Click();

            selenium.FindElementBy_XPath("/html/body/div[1]/div/div/app-component/app-location-product/div/main/form/section/app" +
                "-product-group-card[5]/div/div[2]/div/div/div[2]/app-product-option/div/label");

            selenium.Click();

            selenium.FindElementBy_XPath("/html/body/div[1]/div/div/app-component/app-location-product/div/header/div/button");

            selenium.Click();
        }
    }
}
