using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebDriverAssignment1
{
    class LaunchChrome
    {
        static void Main(string[] args)
        {  //launch chrome.
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in/";
        }
    }
}
