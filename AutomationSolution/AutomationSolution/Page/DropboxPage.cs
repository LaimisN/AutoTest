using AutomationSolution.BaseTest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationSolution.Page
{
    public class DropboxPage : BasePage
    {
        private const string urlPage = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
        // $$('#isAgeSelected')patikrinimas paieska 
        // private static IWebDriver driver;
        private SelectElement multipleDropDown => new SelectElement(driver.FindElement(By.Id("multi-select")));

        //private IWebElement multiselectDropDownList => driver.FindElement(By.Id("multi-select")); //=> igalina naudojima kai bus priskirtas
        private IWebElement FirstSelectedState => driver.FindElement(By.CssSelector("#multi-select > option:nth-child(4)"));
        private IWebElement SecondSelectedState => driver.FindElement(By.CssSelector("#multi-select > option:nth-child(1)"));
        private IWebElement FirstElemetSelectedButton => driver.FindElement(By.Id("printMe"));
        private IWebElement GetAllSelected => driver.FindElement(By.Id("printAll"));
        private IWebElement Resulttext => driver.FindElement(By.ClassName("getall-selected"));


        //Pažymime 2 valstijas, spaudžiame "First Selected" mygtuką - patikrinam, ar rezultatas teisingas, rodo pirmą pažymėtą valstiją.

        public DropboxPage(IWebDriver webdriver) : base(webdriver)
        {
            // driver = webdriver;
            driver.Url = urlPage;

        }
        public DropboxPage SelectstateOfdropDownListByText(string text)
        {
            multipleDropDown.SelectByText(text);
            return this;
        }
        public DropboxPage ClickFirstSelectedButton()
        {
            FirstElemetSelectedButton.Click();
            return this;
        }
        public DropboxPage SelectMultiDropDownByText(string text1, string text2, string text3)
        {
            //Action action = new Action(driver);
            // SelectstateOfdropDownListByText.

            Actions action = new Actions(driver);
            action.KeyDown(Keys.Control);
            Thread.Sleep(1000);
            SelectstateOfdropDownListByText(text1);
            Thread.Sleep(1000);
            action.KeyUp(Keys.Control);
            Thread.Sleep(1000);
            SelectstateOfdropDownListByText(text2);
            Thread.Sleep(1000);
            action.KeyUp(Keys.Control);
            Thread.Sleep(1000);
            SelectstateOfdropDownListByText(text3);
            Thread.Sleep(1000);
            action.Build().Perform();
            Thread.Sleep(1000);
            GetAllSelected.Click();
            return this;

            /*
            multipleDropDown.SelectByText(text1);
            Thread.Sleep(2000);

            multipleDropDown.SelectByText(text2);
            FirstElemetSelectedButton.Click();*/

            // return this;
        }
        public DropboxPage SelectWhileMultiDropDownByText(string text1, string text2, string text3, string text4)
        {
            //Action action = new Action(driver);
            // SelectstateOfdropDownListByText.
            while (true)
            {

                Actions action = new Actions(driver);
                action.KeyDown(Keys.Control);
                SelectstateOfdropDownListByText(text1);
                Thread.Sleep(1000);
                action.KeyUp(Keys.Control);
                SelectstateOfdropDownListByText(text2);
                if (text3.Equals(""))
                {
                    break;
                }
                else
                {
                    action.KeyUp(Keys.Control);
                    SelectstateOfdropDownListByText(text3);
                    Thread.Sleep(1000);

                }
                if (text4.Equals(""))
                {
                    break;
                }
                else
                {
                    action.KeyUp(Keys.Control);
                    SelectstateOfdropDownListByText(text4);
                    //Thread.Sleep(1000);

                }
                action.Build().Perform();
                Thread.Sleep(1000);
                GetAllSelected.Click();
            }
                return this;
        }

        public DropboxPage ValidationFirstOfTwoStates(string text1)
        {
            // Assert.AreEqual(text1, Resulttext.Text.Contains(text1), "pasirinkta pirmoji valstija neatitinka");
            Assert.IsTrue(Resulttext.Text.Contains(text1), "pasirinkta pirmoji valstija neatitinka");
            return this;
        }
        public DropboxPage GetAllBoxButtonSelected()
        {
            GetAllSelected.Click();
            return this;
        }
        public DropboxPage ValidationAllOfSelectedStates(string text1, string text2, string text3)
        {
            // Assert.AreEqual(text1, Resulttext.Text.Contains(text1), "pasirinkta pirmoji valstija neatitinka");
            Assert.IsTrue(Resulttext.Text.Contains($"{ text1},{ text2},{ text3}"), "pasirinkta pirmoji valstija neatitinka");
            return this;
        }
        public DropboxPage ValidationAllOfSelectedStates4(string text1, string text2, string text3,string text4)
        {
            // Assert.AreEqual(text1, Resulttext.Text.Contains(text1), "pasirinkta pirmoji valstija neatitinka");
           // Assert.IsTrue(Resulttext.Text.Contains($"{ text1},{ text2},{ text3},{text4}"), "pasirinkta pirmoji valstija neatitinka");
            Assert.IsTrue(Resulttext.Text.Contains("text1, text2, text3, text4"), "pasirinkta pirmoji valstija neatitinka");
            return this;
        }


    }
}
