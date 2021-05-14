using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.BaseTest
{
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver webdriver)
        {
            driver = webdriver;

        }

        /*
        [OneTimeSetUp]
        public void Open()
        {
            // IWebDriver crome = new ChromeDriver();
            Driver = new ChromeDriver();
            Driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
        }
        */
        //[OneTimeTearDown]
        public void close()
        {
            driver.Quit();
        }

        public WebDriverWait GetWait(int seconds = 10)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }


    }

}
