using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationSolution.driver;
using AutomationSolution.Page;
using NUnit.Framework.Interfaces;
using AutomationSolution.Tools;

namespace AutomationSolution.Test
{
    public class BaseTest
    {
        protected static IWebDriver driver;
        public static BasicCheckboxDemoPage basicCheckBoxDemoPage;
        public static DropboxPage selectDropboxPage;
        [OneTimeSetUp]
        public static void Setup()
        {
            driver = CustomDriver.GetChromeDriver();
            basicCheckBoxDemoPage = new BasicCheckboxDemoPage(driver);
            selectDropboxPage = new DropboxPage(driver);

            /*

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(_driver => _driver.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
        driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
    */
        }
        [TearDown]

        public static void TearDownAttribute()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                // TakeScreenshot
                MyScreenshot.TakeScreenshot(driver);  //??
            }

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Close();
        }

    }
}
