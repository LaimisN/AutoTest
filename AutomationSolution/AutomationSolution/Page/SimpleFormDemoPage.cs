using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.Page
{
   public class SimpleFormDemoPage
    {
        private static IWebDriver driver;
        private IWebElement enterMessageInput => driver.FindElement(By.Id("user-message")); //=> igalina naudojima kai bus priskirtas
        private IWebElement showMessageButton => driver.FindElement(By.CssSelector("#get-input > button"));
        private IWebElement singleInputResult => driver.FindElement(By.Id("display"));
        private IWebElement firstInputField => driver.FindElement(By.Id("sum1"));
        private IWebElement secondInputField => driver.FindElement(By.Id("sum2"));
        private IWebElement getTotalButton => driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
        private IWebElement actualResult => driver.FindElement(By.Id("displayvalue"));


        public SimpleFormDemoPage(IWebDriver webdriver)
        {
            driver = webdriver;

        }
        
        public void InsertTextToSingleInputField(string text)
        {
            enterMessageInput.Clear();
            enterMessageInput.SendKeys(text);
        } 

        public void ClickMassageButton()
        {
            showMessageButton.Click();

        }
        public void VerifySingleInputField(string expectedResult)
        {
            Assert.AreEqual(expectedResult, singleInputResult.Text, "Test is not equals"); // prad=ioje expected o antras actual rezultatas
        }

        public void InsertFirstInputField(string firstInput)
        {
            firstInputField.Clear();
            firstInputField.SendKeys(firstInput);
        }

        public void InsertSecondInputField(string secondInput)
        {
            secondInputField.Clear();
            secondInputField.SendKeys(secondInput);
        }

        public void InsertBothValuesToInputFolds(string firstInput, string secondInput)
        {
            InsertFirstInputField(firstInput);
            InsertSecondInputField(secondInput);
        }

        public void ClickGetTotalButton()
        {
            getTotalButton.Click();
        }

        public void VerifySumResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, actualResult.Text, "Result is not correct!");
        }
    }


}
