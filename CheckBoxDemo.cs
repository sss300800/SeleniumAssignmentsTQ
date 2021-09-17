using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace CheckBoxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();
            // driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?hl=en&flowName=GlifWebSignIn&flowEntry=SignUp";
            // IWebElement check_box = driver.FindElement(By.XPath("//input[@id='i3']"));
            driver.Url = "https://preview.colorlib.com/theme/bootstrap/checkbox-01/";
            IWebElement check_box = driver.FindElement(By.ClassName("col-md-4"));
            IWebElement check_box1 = driver.FindElement(By.XPath("/html/body/section/div/div[2]/div/label[4]"));
          //  IWebElement check_box1 = driver.FindElement(By.ClassName("checkbox-wrap checkbox-warning"));
           // Thread.Sleep(3000);
            check_box.Click();
           

            check_box1.Click();
      
           // driver.Close();

        }
    }
}
