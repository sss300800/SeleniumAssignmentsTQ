using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SelectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();
            driver.Url = "https://formstone.it/components/dropdown/demo/";
            IWebElement select_box = driver.FindElement(By.Id("demo_basic"));
            SelectElement select = new SelectElement(select_box);
            select.SelectByIndex(1);   //starting from zero.
            //select.SelectByText("Two");
            //select.SelectByValue("1");
            driver.Close();

        }
    }
}
