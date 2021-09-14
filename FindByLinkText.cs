using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebDriverAssignment1
{
    class FindByLinkText
    {
        static void main(string[] args)
        {
        
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in/";
            driver.FindElement(By.LinkText("Gmail")).Click();
            driver.Close();


        } 
    }
}
