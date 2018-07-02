using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;

namespace ToluMSTestFramework.PageObjectModel
{
    public class UserAccountPage
    {
        private readonly By _downloadLink = By.LinkText("Downloads");

        public DownloadPage NavigateToDownloadPage()
        {
            LinkHelper.ClickLink(_downloadLink);
            return new DownloadPage();
        }
    }
}
