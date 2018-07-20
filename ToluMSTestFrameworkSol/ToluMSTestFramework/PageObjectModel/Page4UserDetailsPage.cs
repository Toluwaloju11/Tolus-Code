using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;

namespace ToluMSTestFramework.PageObjectModel
{
    public class Page4UserDetailsPage
    {
        #region Element

        private readonly By _downloadLink = By.LinkText("Downloads");
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
            LinkHelper.ClickLink(_downloadLink);
            return new Page5DownloadPage();
        }
        #endregion
    }
}