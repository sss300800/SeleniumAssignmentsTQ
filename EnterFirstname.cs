using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebDriverAssignment1
{
    class EnterFirstname
    {
        static void main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Url = "https://accounts.google.com/signup/v2?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&flowName=GlifWebSignIn&flowEntry=SignUpp";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("firstName")).SendKeys("somnath");
            driver.Close();
        }
    }
}
