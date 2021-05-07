using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution
{
    class checkbox
    {
        [Test]
        public static void SingleCheckField()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
           // chrome.FindElement(By.Id("isAgeSelected")).Click();  //paklikinam viena karta surade. 
            IWebElement oneselect = chrome.FindElement(By.Id("isAgeSelected"));
            oneselect.Click();
            IWebElement showMessage = chrome.FindElement(By.CssSelector("#txtAge"));
            Assert.IsTrue(showMessage.Text.Equals("Success - Check box is checked"));
           // chrome.Close();
        }
        [Test]
        public static void TestMultipleCheckBox()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            chrome.Manage().Window.Maximize();

            /*IWebElement secondCheckbox = chrome.FindElement(By.Id("isAgeSelected"));
            if (secondCheckbox.Selected)
            {
                secondCheckbox.Click();
            }
            */
            // IWebElement multimlebox = chrome.FindElement(By.Id("isAgeSelected"));
            //IReadOnlyCollection<IWebElement> multipleCheckBox = chrome.FindElements(By.CssSelector("div.checkbox:nth-child(3) > label:nth-child(1) > input:nth-child(1)"));

            IReadOnlyCollection<IWebElement> multipleCheckBox = chrome.FindElements(By.ClassName("cb1-element"));
            foreach (IWebElement element in multipleCheckBox)
            {
                element.Click();
                Assert.IsTrue(element.Selected);

            }




        }

    }
}
