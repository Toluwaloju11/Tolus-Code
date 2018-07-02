using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;

namespace ToluMSTestFramework.PageObjectModel
{
   public class DownloadPage
   {
       private readonly By _downloadLink = By.LinkText("Downloads");

       public void DownloadsPageView()
       {
           LinkHelper.ClickLink(_downloadLink);
            //We can now put assertions her eg Page title as we are not returning any other pages
       }
   }
}
