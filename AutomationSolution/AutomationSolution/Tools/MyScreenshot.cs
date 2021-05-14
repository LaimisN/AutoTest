using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.Tools
{
    public class MyScreenshot
    {
        public static void TakeScreenshot (IWebDriver driver)
        {/*
          * https://github.com/ArnasR/ProjectDraft

          * 
            //Taking Screenshot in C#

            Screenshot ss = ((ITakesScreenshot)Browser).GetScreenshot();
            string title = ScenarioContext.Current.ScenarioInfo.Title;
            string Runname = title + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = "X:\\screenshots\\" + Runname + ".jpg";
            ss.SaveAsFile(screenshotfilename, System.Drawing.Imaging.ImageFormat.Jpeg);
            */
            /*
            Screenshot screenshot = driver.TakeScreenshot();
           // Console.WriteLine($"test code Location: {Assembly.GetExecutingAssembly().Location}");// patikrinimas kur yra serveryje saugojimo vieta
            string screenshotDirectory = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))));
            string sccreenshotFolder = Path.Combine(screenshotDirectory, "Screenshot");
            Directory.CreateDirectory(sccreenshotFolder);
                string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm_ss}.png";
            string screenhotPath = Path.Combine(sccreenshotFolder, screenshotName);
            screenshot.SaveAsFile(screenhotPath, ScreenshotImageFormat.Png);
            */



            Screenshot screenshot = driver.TakeScreenshot();
                string screenshotDirectory = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))));
                string screenshotFolder = Path.Combine(screenshotDirectory, "Screenshot");
                Directory.CreateDirectory(screenshotFolder);
                string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm_ss}.png";
                string sreenshotPath = Path.Combine(screenshotFolder, screenshotName);
                screenshot.SaveAsFile(sreenshotPath, ScreenshotImageFormat.Png);
/*
            Screenshot screenshot = driver.TakeScreenshot();
            string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm_ss}.png";
            string sreenshotPath = Path.Combine("C:\\", screenshotName);
            screenshot.SaveAsFile(sreenshotPath, ScreenshotImageFormat.Png);
        */
            }
    }
}
