using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationSolution.BaseTest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationSolution
{/*
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

    
    public class ND
    //public class ND : BaseOpenClose
    {
        
        /*
        public object Selectelement { get; private set; }

        [Test]
    public void Test1()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://autoplius.lt/";
            IWebElement listOfcars = chrome.FindElement(By.XPath(""));
            SelectElement element = new SelectElement(listOfcars);
   //         element.SelectByIndex(99);
            element.SelectByText("Audi");
            element.SelectByValue("99");




        }
        */
    }

