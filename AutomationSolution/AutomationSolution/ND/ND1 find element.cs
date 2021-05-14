using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationSolution
{
    class ND1
    {
        public IWebDriver chrome = new ChromeDriver();
        [Test]
        public void TesTwoPlusTwo()
        {
            chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            //  Thread.Sleep(2000);
            IWebElement enterMessageInput = chrome.FindElement(By.Id("sum1"));
            string firstnr = "2";
            enterMessageInput.SendKeys(firstnr);
            IWebElement enterMessageInput2 = chrome.FindElement(By.Id("sum2"));
            string secondnr = "2";
            enterMessageInput2.SendKeys(secondnr);
            IWebElement FindButton = chrome.FindElement(By.CssSelector("#gettotal > button"));
            // IWebElement FindButton = chrome.FindElement(By.Id("displayvalue"));
            FindButton.Click();
            //   Thread.Sleep(5000);
            string Expectedresult = "4";
            // IWebElement actualResult = chrome.FindElement(By.Id ("displayvalue"));
            IWebElement actualResult = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(Expectedresult, actualResult.Text, "Message is not 4 !");
        }

        [Test]
        public void TestMiusfiveplusTree()
        {
            chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            //   IWebElement enteronemessage = chrome.FindElement(By.CssSelector(input#sum1.form-control));
            IWebElement enterOneNr = chrome.FindElement(By.Id("sum1"));
            string nr1 = "-5";
            enterOneNr.SendKeys(nr1);
            IWebElement enterSecondNr = chrome.FindElement(By.Id("sum2"));
            string nr2 = "3";
            enterSecondNr.SendKeys(nr2);
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal>button"));
            button.Click();
            string expectedResult = "-2";
            IWebElement actualR = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(expectedResult, actualR.Text, "Gautas rezultatas neatitinka!");
        }

        [Test]
        public void TestAplusB()
        {
            chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement TextEnter1 = chrome.FindElement(By.Id("sum1"));
            string num1 = "a";
            TextEnter1.SendKeys(num1);
            IWebElement textEnter2 = chrome.FindElement(By.Id("sum2"));
            string num2 = "b";
            textEnter2.SendKeys(num2);
            IWebElement Buttonas = chrome.FindElement(By.CssSelector("#gettotal>button"));
            Buttonas.Click();
            string Tikimasi = "NaN";
            IWebElement actualRez = chrome.FindElement(By.Id("displayvalue"));
            //  IWebElement actualRez = chrome.FindElement(By.XPath(".//*[@id='displayvalue']"));
            Assert.AreEqual(Tikimasi, actualRez.Text, "Neatitinka gauto rez!!");

        }
        /*
        public void TestAplusB()
        {
            IWebDriver FireFox = FireFoxDriver();
            FireFox.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement TextEnter1 = FireFox.FindElement(By.Id("sum1"));
            string num1 = "a";
            TextEnter1.SendKeys(num1);
            IWebElement textEnter2 = FireFox.FindElement(By.Id("sum2"));
            string num2 = "b";
            textEnter2.SendKeys(num2);
            IWebElement Buttonas = FireFox.FindElement(By.CssSelector("button.btn:nth - child(3)"));

            Buttonas.Click();
            string Tikimasi = "NaN";
            IWebElement actualRez = FireFox.FindElement(By.XPath(".//*[@id='displayvalue']"));
            Assert.AreEqual(Tikimasi, actualRez.Text, "Neatitinka gauto rez!!");

        }
        public IWebDriver FireFoxDriver()
        {
            throw new NotImplementedException();
        }
        */
    }
}
