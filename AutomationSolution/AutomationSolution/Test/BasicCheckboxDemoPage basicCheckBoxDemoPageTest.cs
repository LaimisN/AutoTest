using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationSolution.Page;

namespace AutomationSolution.Test
{
    class BasicCheckboxDemoTest : BaseTest
    {
    //    private static BasicCheckboxDemoPage basicCheckBoxDemoPage;
    /*
        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            basicCheckBoxDemoPage = new BasicCheckboxDemoPage(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            basicCheckBoxDemoPage.close();
        }
            */
        [Order(1)]
        [Test]
        public static void SingleCheckBoxTest()
        {
            basicCheckBoxDemoPage.NavigatetoDefoultPage()
                .CheckSingleCheckBox()
                    .AssertSingleCheckBoxDemoSuccessMessage()
                    .UnCheckSingleCheckBox();
        }

        [Order(2)]
        [Test]
        public static void MultipleCheckBoxTest()
        {
            basicCheckBoxDemoPage.NavigatetoDefoultPage()
                .CheckAllMultipleCheckBoxes()
                .AssertButtonName("Uncheck All");
        }

        [Order(3)]
        [Test]
        public static void UncheckMultipleCheckBoxesTest()
        {
            basicCheckBoxDemoPage.NavigatetoDefoultPage()
                .CheckAllMultipleCheckBoxes()
                .ClickGroupButton()
                .AssertMultipleCheckBoxesUnchecked();
        }
        /*
        [Order(4)]
        [Test]
        public static void ThisIsDemoTest()
        {
            basicCheckBoxDemoPage.CheckAllMultipleCheckBoxes()
                .ClickGroupButton()
                .AssertMultipleCheckBoxesUnchecked();
        }*/
    }
}
