using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace WebDriverAssignment2
{
    class ByRelativeXpath
    {
        static void main(string[] args)
        {
            IWe
        }bDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in/";
            driver.FindElement(By.XPath("//div[@class=gLFyf gsfi")).SendKeys("selenium");
            driver.Close();
    }
}
