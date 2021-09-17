using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FetchTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in/";
            string title = driver.Title;
            Console.WriteLine(title);
            driver.FindElement(By.LinkText("Gmail")).Click();
            string title2 = driver.Title;
            Console.WriteLine(title2);
        }
    }
}
