using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using ConsoleApplication2;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace UnitTestCrome
{
    [TestClass]
    public class UnitTest1
    {
       
        public const double Timeout = 10;
        
        public void TestDriverEmail(IWebDriver d)
        {
            Data data = new Data();
            IWebDriver driver = d;

            driver.Navigate().GoToUrl("https://mail.google.com");
            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys(data.Login);

            IWebElement pass = driver.FindElement(By.Id("Passwd"));
            pass.SendKeys(data.password);

            IWebElement sign = driver.FindElement(By.Id("signIn"));
            sign.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            IWebElement Send = driver.FindElement(By.XPath("//div[contains(@class, 'z0')]/div"));
            Send.Click();
            Assert.IsNotNull(Send);
           
            IWebElement who = driver.FindElement(By.XPath("//textarea[contains(@name, 'to')]"));
            who.SendKeys(data.Login);
            Assert.IsNotNull(who);
           
            IWebElement theme = driver.FindElement(By.ClassName("aoT"));
            theme.SendKeys("Std theme");
            Assert.IsNotNull(theme);
          
            IWebElement txt = driver.FindElement(By.XPath("//div[contains(@class, 'Am Al editable LW-avf')]"));
            txt.SendKeys("For me");
            Assert.IsNotNull(txt);
            
            IWebElement confirm = driver.FindElement(By.XPath("//div[contains(@class, 'T-I J-J5-Ji aoO T-I-atl L3')]"));
            confirm.Click();
            
            Assert.IsNotNull(confirm);
            IWebElement confirmMsg = driver.FindElement(By.ClassName("vh"));
            Assert.IsNotNull(confirmMsg);
           
            IWebElement refresh = driver.FindElement(By.XPath("//div[contains(@class, 'asf T-I-J3 J-J5-Ji')]"));
            refresh.Click();
            Assert.IsNotNull(refresh);
            driver.Close();
            
        }

        [TestMethod]
        public void TestChrome()
        {
            TestDriverEmail(new ChromeDriver(@"E:\"));
        }
        [TestMethod]
        public void TestFirefox()
        {
            
            TestDriverEmail(new FirefoxDriver());
        }
    }
}
