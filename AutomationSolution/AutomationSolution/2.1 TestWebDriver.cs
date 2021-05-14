using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationSolution
{
    class TestWebDriver
    {
        
        [Test] 
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Url = "https://autoplius.lt";
            chrome.Close();
        }
        
        [Test]
        public static void TestfirefoxDriver()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://autoplius.lt";
            firefox.Close();
        }
        [Test]
        public static void TestOpera()
        {
            OperaDriverService service = OperaDriverService.CreateDefaultService("C:\\Users\\Bullet\\AppData\\Local\\Programs\\Opera", "operadriver.exe");
            var operaOptions = new OperaOptions
            {
                BinaryLocation = "C:\\Users\\Bullet\\AppData\\Local\\Programs\\Opera\\76.0.4017.107\\opera.exe",
                LeaveBrowserRunning = false
            };
            IWebDriver opera = new OperaDriver(service, operaOptions);
            opera.Navigate().GoToUrl("https://autoplius.lt");
        }

        
        
        [Test]
        public static void Emailinput()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize(); //padidina langa
            chrome.Url = "https://login.yahoo.com";
            IWebElement emailinput = chrome.FindElement(By.Id("login-username"));
            emailinput.SendKeys("Tesst@automation.com");
            IWebElement nextButton = chrome.FindElement(By.CssSelector("#login-signin"));
            nextButton.Click();
            string expectionErrorMessage = "Sorry, we don't recognize this email.";
            IWebElement actualErrorMessage = chrome.FindElement(By.Id("username-error"));
            Thread.Sleep(1000);
            Assert.AreEqual(expectionErrorMessage, actualErrorMessage.Text);
        }


        [Test]
        public static void TestSingleInputField()
        {

            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            chrome.Manage().Window.Maximize();
            IWebElement enterMessageInput = chrome.FindElement(By.Id("user-message"));
            string expectedText = "Vasara";
            enterMessageInput.SendKeys(expectedText);
            IWebElement showMessageButton = chrome.FindElement(By.CssSelector("#get-input > button"));
            showMessageButton.Click();
            IWebElement result = chrome.FindElement(By.Id("display"));
            Assert.AreEqual("Vasara", result.Text, "Message is wrong!");
            // chrome.Close();

            //Thread.Sleep(1000); //uzmigdo testa
        }
            [Test]
            public static void SingleInputField()
            {
                IWebDriver chrome = new ChromeDriver();
                chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

                IWebElement enterMessageInput = chrome.FindElement(By.Id("user-message"));
                string expectedText = "Vasara";
                enterMessageInput.SendKeys(expectedText);
                IWebElement showMessageButton = chrome.FindElement(By.CssSelector("#get-input > button"));
                showMessageButton.Click();
                IWebElement result = chrome.FindElement(By.Id("display"));
                Assert.AreEqual("Vasara", result.Text, "Message is wrong!");
              //  chrome.Close();
            }



        }
    }

