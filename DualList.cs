using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualListDemo
{
    class Program
    {
        public static object SelectElement { get; private set; }

        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.seleniumeasy.com/test/jquery-dual-list-box-demo.html";
            
           // driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[1]/select")).SendKeys("Isis");
           // driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[2]/button[1]")).Click();
           // driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[1]/select")).SendKeys("Sophia");
          //  driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[2]/button[1]")).Click();
           // driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[1]/select")).SendKeys("Laura");
           // driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[2]/button[1]")).Click();
           // driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[1]/select")).SendKeys("Luiza");
           // driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[2]/button[1]")).Click();

            IWebElement select_box = driver.FindElement(By.ClassName("form-control"));
            SelectElement select = new SelectElement(select_box);
            select.SelectByIndex(0);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[2]/button[1]")).Click();
            select.SelectByIndex(2);
             driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[2]/button[1]")).Click();
            select.SelectByIndex(3);
             driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[2]/button[1]")).Click();
            select.SelectByIndex(4);
             driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div/div/div[2]/button[1]")).Click();
            IList<IWebElement> options = select.AllSelectedOptions;
            Console.WriteLine(select.SelectedOption.Text);
            foreach(IWebElement option in options)
                Console.WriteLine(option.Text);



        }
    }
}