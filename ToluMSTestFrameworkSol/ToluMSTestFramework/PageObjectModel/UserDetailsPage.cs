using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;

namespace ToluMSTestFramework.PageObjectModel
{
    public class UserDetailsPage
    {
        #region Element
        private readonly By _downloadLink = By.CssSelector("#content > ul:nth-child(4) > li:nth-child(2) > a");////*[@id="content"]/ul[2]/li[2]/a
        #endregion
#region Actions
        public void DownloadAction()
        {
            //No Actions on this page
        }
        #endregion
        #region Navigation
        public  new DownloadPage ClickDownloadLink()
        {
            LinkHelper.ClickLink(_downloadLink);
            return new DownloadPage();
        }
        #endregion
    }
}