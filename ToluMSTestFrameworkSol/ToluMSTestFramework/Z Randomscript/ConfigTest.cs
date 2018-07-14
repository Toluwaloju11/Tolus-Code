using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.Z_Randomscript
{
    [TestClass]
    public class ConfigTest
    {
        [TestMethod]
        [TestCategory("SAMPLE")]
        public void TestMethod1()
        {
            var expectedUrl = "https://demo.opencart.com/index.php?route=account/register";
            //Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            //IConfig config = new AppConfigReader();
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            MenuButtonHelper.SelectMenuButton(By.ClassName("caret"));
            MenuButtonHelper.SelectMenuButton(By.LinkText("Register"));
            var actualUrl = ObjectRepository.driver.Url;
            Assert.AreEqual(expectedUrl,actualUrl);
        }
    }
}
