using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dec2018MSTestFramework.TestScripts
{
    [TestClass]
    public class ShopForAMac
    {
        [TestMethod,TestCategory("TestHomePage")]
        public void PurchaseAMac()
        {
             var homePage = new HomePage();
            //var macPage = new MacPage();
            homePage.GoToMacPage().AddItemsToBasket();


        }
    }
}
