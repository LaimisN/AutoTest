using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution
{
    class ND2
    {

        [TestCase("firefox")]
        [TestCase("chrome")]
        [TestCase("opera")]


        public static void Testdriver(string narsykle)
        {

            switch (narsykle)
            {
                case "chrome":
                    IWebDriver chrome = new ChromeDriver();
                    chrome.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";

                    IWebElement Boxtext = chrome.FindElement(By.CssSelector("#primary-detection > div"));
                    string expected = "Chrome 90 on Windows 10";
                    Assert.IsTrue(Boxtext.Text.Contains(expected), "textas nesutampa");
                    chrome.Quit();
                    break;
                case "firefox":
                    IWebDriver firefox = new FirefoxDriver();
                    firefox.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";

                    IWebElement Boxtext1 = firefox.FindElement(By.CssSelector("#primary-detection > div"));
                    string expected1 = "Firefox 88 on Windows 10";
                    Assert.IsTrue(Boxtext1.Text.Contains(expected1), "textas nesutampa");
                    firefox.Quit();
                    break;
                case "opera":
                    OperaDriverService service = OperaDriverService.CreateDefaultService("C:\\Users\\Bullet\\AppData\\Local\\Programs\\Opera", "operadriver.exe");
                    var operaOptions = new OperaOptions
                    {
                        BinaryLocation = "C:\\Users\\Bullet\\AppData\\Local\\Programs\\Opera\\76.0.4017.107\\opera.exe",
                        LeaveBrowserRunning = false
                    };
                    IWebDriver opera = new OperaDriver(service, operaOptions);
                    opera.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
                    IWebElement Boxtext2 = opera.FindElement(By.CssSelector("#primary-detection > div"));
                    string expected2 = "Opera 76 on Windows 10";
                    Assert.IsTrue(Boxtext2.Text.Contains(expected2), "textas nesutampa");
                      opera.Quit();     
                    break;

            }

        }



        [Test]

        public static void Testone()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";

            IWebElement Boxtext = chrome.FindElement(By.CssSelector("#primary-detection > div"));
            string expected = "Chrome 90 on Windows 10";
            // Assert.AreEqual(true,Boxtext.Text.Contains(expected), "textas nesutampa");
            Assert.IsTrue(Boxtext.Text.Contains(expected), "textas nesutampa");
            //chrome.Quit();
        }
        [Test]
        public static void Testas2()
        {

            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";

            IWebElement Boxtext = firefox.FindElement(By.CssSelector("#primary-detection > div"));
            string expected = "Firefox 88 on Windows 10";
            Assert.IsTrue(Boxtext.Text.Contains(expected), "textas nesutampa");
            //  firefox.Quit();
        }
        [Test]
        public static void Testas3()
        {

            IWebDriver explorer = new InternetExplorerDriver();
            //explorer.Manage().Window.Maximize();
            //explorer.Url = "http://google.com";
            explorer.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            explorer.Manage().Window.Maximize();

            IWebElement Boxtext = explorer.FindElement(By.CssSelector("#primary-detection > div"));
            string expected = "Internet Explorer 11 on Windows 10";
            Assert.IsTrue(Boxtext.Text.Contains(expected), "textas nesutampa");
            //  firefox.Quit();

        }
        [Test]
        public static void Testas4()
        {
            OperaDriverService service = OperaDriverService.CreateDefaultService("C:\\Users\\Bullet\\AppData\\Local\\Programs\\Opera", "operadriver.exe");
            var operaOptions = new OperaOptions
            {
                BinaryLocation = "C:\\Users\\Bullet\\AppData\\Local\\Programs\\Opera\\76.0.4017.107\\opera.exe",
                LeaveBrowserRunning = false
            };
            IWebDriver opera = new OperaDriver(service, operaOptions);

         //   IWebDriver opera = new OperaDriver();
            opera.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";

            IWebElement Boxtext = opera.FindElement(By.CssSelector("#primary-detection > div"));
            string expected = "Opera 76 on Windows 10";
            Assert.IsTrue(Boxtext.Text.Contains(expected), "textas nesutampa");
            //  firefox.Quit();      
        }

        [Test]
        public static void ArNubegs()
        {

            // #page-wrapper > aside > div > header > span
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.active.com/fitness/calculators/pace";
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            chrome.Manage().Window.Maximize();
            IWebElement cookies = chrome.FindElement(By.CssSelector("#page-wrapper > aside > div > header > span"));
            WebDriverWait wait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10));
            wait.Until(x => cookies.Displayed);
            cookies.Click();

            IWebElement TimeHrs = chrome.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(1) > input[type=number]"));
            IWebElement TimeMin = chrome.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(2) > input[type=number]"));
            // IWebElement TimeSec = chrome.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(3) > input[type=number]"));
            string TH = "1";
            string TM = "5";
            // string TS = "";
            TimeHrs.SendKeys(TH);
            TimeMin.SendKeys(TM);
            //  TimeSec.SendKeys(TS);
            IWebElement Distance = chrome.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > label > input[type=number]"));
            Distance.SendKeys("13");
           // IWebElement milebox = chrome.FindElement(By.ClassName("selectboxit-text"));
           // IWebElement milebox = chrome.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span > span.selectboxit-arrow-container"));
            IWebElement milebox = chrome.FindElement(By.CssSelector(".selectboxit-hover")); 
            SelectElement elemementas = new SelectElement(milebox);
            elemementas.SelectByText("Kilometers");
            elemementas.SelectByIndex(1);

            //chrome.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(6) > div > a")).Click();
           // chrome.FindElement(By.XPath("//*[@id='calculator - pace']/form/div[6]/div/a")).Click();
            chrome.FindElement(By.ClassName("btn btn-medium - yellow calculate - btn")).Click();

            


            //IWebElement TimeHrs = chrome.FindElement(By.CssSelector(""));


        }
    }
}
