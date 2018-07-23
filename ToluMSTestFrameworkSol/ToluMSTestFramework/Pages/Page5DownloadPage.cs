using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using OpenQA.Selenium.Support.PageObjects;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.PageObjectModel
{
   public class Page5DownloadPage
   {
        #region Elements
        [FindsBy(How = How.LinkText, Using = "Continue")]
        private IWebElement _continueLink;
        #endregion

        #region CONSTRUCTOR

       public Page5DownloadPage()
       {
        OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(ObjectRepository.driver, this);
       }
        #endregion  

        #region Actions
        public void DownloadButton()
       {
           _continueLink.Click();   
       }
        #endregion

        #region Navigation
       public void NoNavigation()
       {
           
       }
        #endregion
    }
}
