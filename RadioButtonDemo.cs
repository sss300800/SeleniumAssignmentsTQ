using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace radiobuttondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            ReadOnlyCollection<IWebElement> radiobutton1 = driver.FindElements(By.Name("gender"));
            radiobutton1[0].Click();
            Thread.Sleep(3000);
            ReadOnlyCollection<IWebElement> radiobutton2 = driver.FindElements(By.Name("ageGroup"));
            radiobutton2[2].Click();
            Thread.Sleep(3000);






        }
    }
}
