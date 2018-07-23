using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.PageObjectModel
{
    public class Page4UserDetailsPage
    {
        #region Element

        [FindsBy(How = How.LinkText, Using = "Downloads")]
        private IWebElement _downloadLink;
        #endregion

        #region CONSTRUCTOR
        public Page4UserDetailsPage()
        {
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(ObjectRepository.driver, this);

        }
        #endregion

        #region Actions
        public void DownloadAction()
        {
            //No Actions on this page
        }
        #endregion

        #region Navigation
        public  new Page5DownloadPage ClickDownloadLink()
        {
            _downloadLink.Click();
            return new Page5DownloadPage();
        }
        #endregion
    }
}