using AutomationSolution.BaseTest;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.Page
{
    class VartuTechnikaPage : BasePage 
    {
       // private static IWebDriver driver;
        private  IWebElement widthInput => driver.FindElement(By.Id("doors_width"));
        private  IWebElement heightInput => driver.FindElement(By.Id("doors_height"));
        private  IWebElement automatikaCheckBox => driver.FindElement(By.Id("automatika"));
        private  IWebElement darbaiCheckBox => driver.FindElement(By.Id("darbai"));
        private  IWebElement CalculatePriceButton => driver.FindElement(By.Id("calc_submit"));
        private /*static*/ IWebElement resultBox => driver.FindElement(By.CssSelector("#calc_result > div"));
        public VartuTechnikaPage(IWebDriver webdriver) : base(webdriver)
        {
           // driver = webdriver;

        }
        public VartuTechnikaPage /*static void*/ InsertWidth(string width)
        {
            widthInput.Clear();
            widthInput.SendKeys(width);
            return this;

        }
        public VartuTechnikaPage /*static void*/ InsertHight(string Height)
        {
            heightInput.Clear();
            heightInput.SendKeys(Height);
            return this;

        }
        public VartuTechnikaPage/* void*/ InsertWidhtAndHeight(string width, string Height)
        {
            InsertWidth(width);
            InsertHight(Height);
            return this;

        }
        public VartuTechnikaPage/* void*/ CheckAutoCheckBox(bool ShouldBeChecked)
        {
            if (ShouldBeChecked != automatikaCheckBox.Selected)
            {
                automatikaCheckBox.Click();
            }
            return this;

        }
        public VartuTechnikaPage/* void*/ CheckWorkCheckBox(bool ShouldBeChecked)
        {
            if (ShouldBeChecked != darbaiCheckBox.Selected)
            {
                darbaiCheckBox.Click();
            }
            return this;

        }

        public VartuTechnikaPage/* void*/ clickCalculateButton()
        {
            CalculatePriceButton.Click();
            return this;
        }
        public VartuTechnikaPage/* void*/ CheckResult(string result)
        {
            Assert.IsTrue(resultBox.Text.Contains(result), $"Suma neteisinga. Expected value is {result}, but actual result is {resultBox.Text}");

            return this;

        }


    }
}
