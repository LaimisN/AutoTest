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
    class VartuTechnikaPageTest
    {
        private static IWebDriver driver;
        [OneTimeSetUp]
        public static void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "http://vartutechnika.lt/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
            //coocie paklikinimas
            IWebElement cookies = driver.FindElement(By.Id("cookiescript_close"));
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => cookies.Displayed);
            cookies.Click();

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Close();
        }

        [TestCase("2000", "2000", true, false, "665.98€", TestName = "2000 x 2000 + Vartų automatika = 665.98€")]
        [TestCase("2000", "2000", true, true, "780.49€", TestName = "2000 x 2000 + Vartų automatika + Vartų montavimo darbai = 1006.43€")]
        [TestCase("4000", "2000", false, false, "692.35€", TestName = "4000 x 2000 = 692.35€")]
        [TestCase("5000", "2000", false, true, "989.21€", TestName = "5000 x 2000 + Vartų montavimo darbai = 989.21€")]
        public static void TestVartuAutomatika(string width, string height, bool gateAuto, bool darbai, string result)
        {
            /*
            VartuTechnikaPage page = new VartuTechnikaPage(driver);
            page.InsertWidhtAndHeight(width, height);
            page.CheckAutoCheckBox(gateAuto);
            page.CheckWorkCheckBox(darbai);
            page.clickCalculateButton();
            page.CheckResult(result);*/

            VartuTechnikaPage page = new VartuTechnikaPage(driver);
            page.InsertWidhtAndHeight(width, height)
                .CheckAutoCheckBox(gateAuto)
                .CheckWorkCheckBox(darbai)
                .clickCalculateButton()
                .CheckResult(result);


        }

    }
}
