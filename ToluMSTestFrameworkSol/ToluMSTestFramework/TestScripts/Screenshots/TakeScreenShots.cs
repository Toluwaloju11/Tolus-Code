using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.Screenshots
{
    [TestClass]
    public class TakeScreenShots
    {
        [TestMethod, TestCategory("TAKE A SCREENSHOT")]
        public void Screenshots()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            //alt enter to get the scrreshot class below(command alt enter on MAC)
           //Screenshot screenshot = ObjectRepository.driver.TakeScreenshot();
           // screenshot.SaveAsFile("ScreenshotTest.jpeg", ScreenshotImageFormat.Jpeg);
            //This is saved in bin folder 
            GeneralclassHelper.TakeAScreenshot();
            GeneralclassHelper.TakeAScreenshot("Screenshooooooot");
        }
        
    }
}
