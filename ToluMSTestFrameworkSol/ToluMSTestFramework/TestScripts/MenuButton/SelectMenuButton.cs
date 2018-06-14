using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.MenuButton
{
    [TestClass]
    public class SelectMenuButton
    {
        [TestMethod, TestCategory("SELECTBUTTON")]
        public void HandleButton()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoRegister());
            Console.WriteLine("Button Text is {0}",MenuButtonHelper.GetButtontext(By.ClassName("btn-primary")));
            Console.WriteLine(MenuButtonHelper.IsButtonenabled(By.ClassName("btn-primary")));

        }
    }
}
