using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AlertDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.seleniumeasy.com/test/javascript-alert-box-demo.html";
            // driver.FindElement(By.CssSelector("button.btn")).Click();
            // IAlert alert = driver.SwitchTo().Alert();
            // string alert_Text = alert.Text;
            // Console.WriteLine(alert_Text);
            // Thread.Sleep(3000);
            //respond alert
            //alert.Accept();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[2]/button")).Click();
            IAlert alert = driver.SwitchTo().Alert();
            string alert_Text = alert.Text;
            Console.WriteLine(alert_Text);
            Thread.Sleep(3000);
            //respond alert
            alert.Dismiss();



        }
    }
}
