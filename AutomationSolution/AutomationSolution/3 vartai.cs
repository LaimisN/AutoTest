using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationSolution
{
    class vartai
    {
        private static IWebDriver driver;

        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "http://vartutechnika.lt/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            IWebElement cookies = driver.FindElement(By.Id("cookiescript_close"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => cookies.Displayed);
            cookies.Click();

        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Close();
        }
        /*
        ● 2000 x 2000 + Vartų automatika = 665.98€
●       4000 x 2000 + Vartų automatika + Vartų montavimo darbai = 1006.43€
●         4000 x 2000 = 692.35€
●        5000 x 2000 + Vartų montavimo darbai = 989.21€*/
        [TestCase("2000", "2000", true, false, "665.98€", TestName = "2000 x 2000 + Vartų automatika = 665.98€")]
        //[TestCase("4000", "2000", true, true, "780.49€", TestName = "2000 x 2000 + Vartų automatika = 1006.43€")]
       // [TestCase("4000", "2000", false, false, "692.35€", TestName = "2000 x 2000 + Vartų automatika = 692.35€")]
       // [TestCase("5000", "2000", false, true, "989.21€", TestName = "2000 x 2000 + Vartų automatika = 989.21€")]


        //[Test]
        public static void TestVartuAutomatika(string widht, string height, bool gateAuto, bool darbai , string result)

        {
          
            IWebElement enternr1 = driver.FindElement(By.Id("doors_width"));
            enternr1.Clear();
            enternr1.SendKeys(widht);
            IWebElement enternr2 = driver.FindElement(By.Id("doors_height"));
            enternr2.Clear();
            enternr2.SendKeys(height);
            IWebElement oneclick = driver.FindElement(By.Id("automatika"));

            if (gateAuto != oneclick.Selected)
            {
                oneclick.Click();
            }
            IWebElement secondclick = driver.FindElement(By.Id("darbai"));

            if (darbai != secondclick.Selected)
            {
                secondclick.Click();
            }
            driver.FindElement(By.Id("calc_submit"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.CssSelector("calc_result>div")));
            IWebElement ResultBox = driver.FindElement(By.CssSelector("#calc_result > div > strong"));
            Assert.IsTrue(ResultBox.Text.Contains(result), $"suman neteisinga. Expected value is {result}, but actual result {ResultBox.Text}");
              
        }
    }
}
