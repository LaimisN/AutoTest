using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.ND
{
    class NDcheckbox
    {
        public IWebDriver chrome = new ChromeDriver();
        [Test]
        public void OneCheckBoxClick()
        {
            chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            //  Thread.Sleep(2000);
            IWebElement OneCheckBoxClick = chrome.FindElement(By.Id("isAgeSelected"));
            OneCheckBoxClick.Click();
            IWebElement OneCheckBoxClickResult = chrome.FindElement(By.Id("txtAge"));
            Assert.IsTrue(OneCheckBoxClickResult.Text.Contains("Success - Check box is checked"));


        }
    }
}
