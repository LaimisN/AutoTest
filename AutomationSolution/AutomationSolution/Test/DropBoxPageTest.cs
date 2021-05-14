
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
    public class DropBoxPageTest : BaseTest
    {
        // private static IWebDriver driver;
        // private static DropboxPage selectDropboxPage;
      /*  [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            selectDropboxPage = new DropboxPage(driver);
        }



        [OneTimeTearDown]
        public static void TearDown()
        {
            //driver.Close();
            //selectDropboxPage.CloseBrowser();
        }*/

        //1) Pažymime 2 valstijas, spaudžiame "First Selected" mygtuką - patikrinam, ar rezultatas teisingas, rodo pirmą pažymėtą valstiją.
        //3) Pažymime 3 valstijas, spaudžiame "First Selected" mygtuką - patikrinam, ar rezultatas teisingas, rodo pirmą pažymėtą valstiją.
        [TestCase("Washington","New Jersey", "Pennsylvania")]
        public static void SelectMultiStates(string state1, string state2, string state3)
        //[Test]
      //  public static void SelectMultiStates()
        {
            //  string state1 = "California";
            //  string state2 = "New York"; 
            // string state1 = "Texas";
            // string state2 = "Pennsylvania";

            selectDropboxPage.SelectMultiDropDownByText(state1, state2, state3)
                .ClickFirstSelectedButton()
                .ValidationFirstOfTwoStates(state1);



            /*selectDropboxPage.SelectMultiDropDownByText(state1);
            .SelectMultiDropDownByText(state2);
            */
        }
        //2) Pažymime 2 valstijas, spaudžiame "Get All Selected" mygtuką - patikrinam, ar rezultatas teisingas, rodo visas užžymėtas valstijas.
        //4) Pažymime 4 valstijas, spaudžiame "Get All Selected" mygtuką - patikrinam, ar rezultatas teisingas, rodo visas užžymėtas valstijas.
        [TestCase("Ohio", "New Jersey", "Florida")]
        public static void GetAllselectesStates(string state1, string state2, string state3)
        //[Test]
        //  public static void SelectMultiStates()
        {
            //  string state1 = "California";
            //  string state2 = "New York"; 
            // string state1 = "Texas";
            // string state2 = "Pennsylvania";
            // California,Florida,New Jersey,Ohio,New York,Texas,Pennsylvania,Washington

            selectDropboxPage.SelectMultiDropDownByText(state1, state2, state3)
                .GetAllBoxButtonSelected()
                .ValidationAllOfSelectedStates(state1, state2, state3);
        }
        [TestCase("Ohio", "New Jersey", "","")]

        public static void GetAllSelectWhileMultiDropDownByText(string state1, string state2, string state3,string state4)
        {
            selectDropboxPage.SelectWhileMultiDropDownByText(state1, state2, state3, state4)
                .GetAllBoxButtonSelected()
                .ValidationAllOfSelectedStates4(state1, state2, state3, state4);

        }
    }
}
