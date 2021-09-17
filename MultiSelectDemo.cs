using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace MultiselectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\icon\\source\\repos");
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            IWebElement select_box = driver.FindElement(By.Name("States"));
            OpenQA.Selenium.Support.UI.SelectElement select = new OpenQA.Selenium.Support.UI.SelectElement(select_box);
            Boolean status_multiple = select.IsMultiple;
            Console.WriteLine(status_multiple);
            select.SelectByIndex(4);
            select.SelectByValue("california");
            select.SelectByText("New Jersey");
            IList<IWebElement> options = select.AllSelectedOptions;
            Console.WriteLine(select.SelectedOption.Text);
            foreach (IWebElement option in options)
                Console.WriteLine(option.Text);
            driver.Close();
            {

            }
        }
    }
}
