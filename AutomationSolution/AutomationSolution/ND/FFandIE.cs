using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution
{
    class FFandIE
    {
        [Test]
        public void TestAplusB()
        {
            IWebDriver FireFox = new FirefoxDriver();
            // IWebDriver driver = new FirefoxDriver();
            FireFox.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement TextEnter1 = FireFox.FindElement(By.Id("sum1"));
            string num1 = "a";
            TextEnter1.SendKeys(num1);
            IWebElement textEnter2 = FireFox.FindElement(By.Id("sum2"));
            string num2 = "b";
            textEnter2.SendKeys(num2);
            IWebElement Buttonas = FireFox.FindElement(By.CssSelector("#gettotal>button"));
            //IWebElement button = chrome.FindElement(By.CssSelector("#gettotal>button"));

            Buttonas.Click();
            string Tikimasi = "NaN";
            //IWebElement actualRez = FireFox.FindElement(By.XPath(".//*[@id='displayvalue']"));
            IWebElement actualRez = FireFox.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(Tikimasi, actualRez.Text, "Neatitinka gauto rez!!");
        }
        [Test]
        public void Testnumnum()
        {
            IWebDriver explorer = new InternetExplorerDriver();
            explorer.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            //  Thread.Sleep(2000);
            IWebElement enterMessageInput = explorer.FindElement(By.Id("sum1"));
            string firstnr = "2";
            enterMessageInput.SendKeys(firstnr);
            IWebElement enterMessageInput2 = explorer.FindElement(By.Id("sum2"));
            string secondnr = "2";
            enterMessageInput2.SendKeys(secondnr);
            IWebElement FindButton = explorer.FindElement(By.CssSelector("#gettotal > button"));
            // IWebElement FindButton = chrome.FindElement(By.Id("displayvalue"));
            FindButton.Click();
            //   Thread.Sleep(5000);
            string Expectedresult = "4";
            // IWebElement actualResult = chrome.FindElement(By.Id ("displayvalue"));
            IWebElement actualResult = explorer.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(Expectedresult, actualResult.Text, "Message is not 4 !");

        }
    }
}
