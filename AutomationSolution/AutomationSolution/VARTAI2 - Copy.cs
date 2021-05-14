using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution
{
    class VARTAI2
    {/*
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "http://vartutechnika.lt/";
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
           // _driver.Close();
        }

        [TestCase("2000", "2000", true, false, "665.98€", TestName = "2000 x 2000 + Vartų automatika = 665.98€")]
        [TestCase("2000", "2000", true, true, "780.49€", TestName = "2000 x 2000 + Vartų automatika + Vartų montavimo darbai = 1006.43€")]
        [TestCase("4000", "2000", false, false, "692.35€", TestName = "4000 x 2000 = 692.35€")]
        [TestCase("5000", "2000", false, true, "989.21€", TestName = "5000 x 2000 + Vartų montavimo darbai = 989.21€")]
        public static void TestVartuAutomatika(string width, string height, bool gateAuto, bool darbai, string result)
        {
            IWebElement widthInput = _driver.FindElement(By.Id("doors_width"));
            widthInput.Clear();
            widthInput.SendKeys(width);

            IWebElement heightInput = _driver.FindElement(By.Id("doors_height"));
            heightInput.Clear();
            heightInput.SendKeys(height);
            IWebElement automatikaCheckBox = _driver.FindElement(By.Id("automatika"));
            if (gateAuto != automatikaCheckBox.Selected)
            //true != true
            {
                automatikaCheckBox.Click();
            }

            IWebElement darbaiCheckBox = _driver.FindElement(By.Id("darbai"));
            if (darbai != darbaiCheckBox.Selected)
            {
                darbaiCheckBox.Click();
            }

            _driver.FindElement(By.Id("calc_submit")).Click();
            IWebElement resultBox = _driver.FindElement(By.CssSelector("#calc_result > div"));

            Assert.IsTrue(resultBox.Text.Contains(result), $"Suma neteisinga. Expected value is {result}, but actual result is {resultBox.Text}");



            /*
             * From Lektorius Mantas to Everyone:  06:52 PM
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp() 
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }
From Lektorius Mantas to Everyone:  07:02 PM
        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        public static void TestSumBlock(string firstInput, string secondInput, string result)
        {
            IWebElement firstInputField = _driver.FindElement(By.Id("sum1"));
            IWebElement secondInputField = _driver.FindElement(By.Id("sum2"));
            firstInputField.SendKeys(firstInput);
            secondInputField.SendKeys(secondInput);
            IWebElement getTotalButton = _driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            getTotalButton.Click();
            IWebElement actualResult = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(result, actualResult.Text, "Sum is Incorrect");
From Lektorius Mantas to Everyone:  07:19 PM
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(x => x.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            _driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
        [OneTimeSetUp]
        public void SetUp() 
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(x => popUp.Displayed);
            popUp.Click();
        }
        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a + b = NaN")]
        public static void TestSumBlock(string firstInput, string secondInput, string result)
        {
            IWebElement firstInputField = _driver.FindElement(By.Id("sum1"));
            IWebElement secondInputField = _driver.FindElement(By.Id("sum2"));
            firstInputField.Clear();
            firstInputField.SendKeys(firstInput);
            secondInputField.Clear();
            secondInputField.SendKeys(secondInput);
            IWebElement getTotalButton = _driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            getTotalButton.Click();
            IWebElement actualResult = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(result, actualResult.Text, "Sum is Incorrect");
            
        }
From Lektorius Mantas to Everyone:  07:24 PM
_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

_driver.Manage().Window.Maximize();
----------------------------

[TestCase("2000", "2000", true, false, "665.98€", TestName = "2000 x 2000 + Vartų automatika = 665.98€")]
        [TestCase("2000", "2000", true, true, "780.49€", TestName = "2000 x 2000 + Vartų automatika + Vartų montavimo darbai = 1006.43€")]
        [TestCase("4000", "2000", false, false, "692.35€", TestName = "4000 x 2000 = 692.35€")]
        [TestCase("5000", "2000", false, true, "989.21€", TestName = "5000 x 2000 + Vartų montavimo darbai = 989.21€")]
        public static void TestVartuAutomatika(string width, string height, bool gateAuto, bool darbai, string result)
        {
            IWebElement widthInput = _driver.FindElement(By.Id("doors_width"));
            widthInput.Clear();
            widthInput.SendKeys(width);

            IWebElement heightInput = _driver.FindElement(By.Id("doors_height"));
            heightInput.Clear();
            heightInput.SendKeys(height);
IWebElement automatikaCheckBox = _driver.FindElement(By.Id("automatika"));
            if (gateAuto != automatikaCheckBox.Selected)
              //true != true
            {
                automatikaCheckBox.Click();
            }

            IWebElement darbaiCheckBox = _driver.FindElement(By.Id("darbai"));
            if (darbai != darbaiCheckBox.Selected)
            {
                darbaiCheckBox.Click();
            }

            _driver.FindElement(By.Id("calc_submit")).Click();
            IWebElement resultBox = _driver.FindElement(By.CssSelector("#calc_result > div"));

            Assert.IsTrue(resultBox.Text.Contains(result), $"Suma neteisinga. Expected value is {result}, but actual result is {resultBox.Text}");

        }

-------- IWebElement cookies = _driver.FindElement(By.Id("cookiescript_close"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(x => cookies.Displayed);
            cookies.Click();
-----------------
https://www.seleniumeasy.com/test/basic-checkbox-demo.html

[Test]
        public static void TestOneCheckbox()
        {
            _driver.FindElement(By.Id("isAgeSelected")).Click();
            IWebElement result = _driver.FindElement(By.Id("txtAge"));
            Assert.IsTrue(result.Text.Equals("Success - Check box is checked"));
        }
-----------------------------------
 [Test]
        public static void TestMultipleCheckBox()
        {
            IReadOnlyCollection<IWebElement> multipleCheckBox = _driver.FindElements(By.ClassName("cb1-element"));
            foreach (IWebElement element in multipleCheckBox)
            {
                element.Click();
                Assert.IsTrue(element.Selected);
            }
        }



        }*/
    }
}
