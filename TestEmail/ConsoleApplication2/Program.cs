using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            IWebDriver driver = new ChromeDriver(@"E:\");
            driver.Navigate().GoToUrl("https://mail.google.com");
            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys(d.Login);
            IWebElement pass = driver.FindElement(By.Id("Passwd"));
            pass.SendKeys(d.password);
            IWebElement sign = driver.FindElement(By.Id("signIn"));
            sign.Click();
            
            
        }
    }
}
