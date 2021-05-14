using AutomationSolution.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.Test
{
    class SimpleFormDemoTest
    {

        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://www.seleniumeasy.com/test/basic-first-form-demo.html";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(_driver => _driver.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Close();
        }
    
        [Test]

        public static void TestSingleInputField()
        {
            SimpleFormDemoPage page = new SimpleFormDemoPage(driver);
            string text = "penktadienis";
            page.InsertTextToSingleInputField(text);
            page.ClickMassageButton();
            page.VerifySingleInputField(text);
        }

        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a + b = NaN")]
        public static void TestSubBlock(string firs, string second, string result)
        {
            SimpleFormDemoPage page = new SimpleFormDemoPage(driver);
            page.InsertBothValuesToInputFolds(firs , second);
            page.ClickGetTotalButton();
            page.VerifySumResult(result);
        }

    }

}
