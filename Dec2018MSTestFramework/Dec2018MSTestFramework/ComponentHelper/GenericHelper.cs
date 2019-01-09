using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Dec2018MSTestFramework.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsELementPresent(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static IWebElement GetElement(By locator)
        {
            if (IsELementPresent(locator))
            {
                return ObjectRepository.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Element is not present" + locator.ToString());
            }
        }

        public static void TakeAScreenshot(string errorShot = "Screenshot")
        {
            var testName = MethodBase.GetCurrentMethod();
            var screenshot = ObjectRepository.Driver.TakeScreenshot();
            Directory.CreateDirectory("screenshots");
            errorShot = $"{DateTime.Now:dd.mm.yyyy-HH.mm.ss}.jpeg";
            screenshot.SaveAsFile("screenshots\\" + testName + ObjectRepository.Driver.Title 
            //screenshot.SaveAsFile("screenshots\\" + ObjectRepository.Driver.Title 
                + "--" + errorShot, ScreenshotImageFormat.Jpeg);
        }
    }
}
