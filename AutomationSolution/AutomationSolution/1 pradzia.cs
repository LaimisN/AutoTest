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
    public class Class1
    {
        [Test]


        public static void TestIf4IsEven()
        {
            int LeftOver = 4 % 2;
            Assert.AreEqual(0, LeftOver, "4 is not even!!");
        }

        [Test]
        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(14, currentTime.Hour, "dabar ne 19 valanda");
        }

        [Test]
        public static void If995()
        {
            int if995 = 9 % 3;
            Assert.AreEqual(0, if995, "skaicius nesidalina 3");
        }
        
        [Test]
        public static void Pirmadienis()
        {
           //DayOfWeek pirm= DayOfWeek.Monday;
            DateTime Today = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Wednesday , Today.DayOfWeek , "dabar nepirmadienis");
          //  Assert.AreEqual(DayOfWeek.Monday, Today.DayOfWeek , "dabar nepirmadienis");

        }

        [Test]
        public static void Posecunziu()
        {
            Thread.Sleep(5000);
        }
        [Test]
        public static void SingleInputField()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            IWebElement enterMessageInput = chrome.FindElement(By.Id("user-message"));
            string expectedText = "Vasara";
            enterMessageInput.SendKeys(expectedText);
            IWebElement showMessageButton = chrome.FindElement(By.CssSelector("#get-input > button"));
            showMessageButton.Click();
            IWebElement result = chrome.FindElement(By.Id("display"));
            Assert.AreEqual("Vasara", result.Text, "Message is wrong!");
            // chrome.Close();
        }

    }

}
