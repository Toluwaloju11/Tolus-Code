﻿using System;
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
        #region Elements
        private readonly By _downloadLink =
            By.CssSelector("#content > ul:nth-child(4) > li:nth-child(2) > a");
        #endregion

        #region Actions
        public void DownloadButton()
       {
           LinkHelper.ClickLink(_downloadLink);
            //We can now put assertions her eg Page title as we are not returning any other pages
       }
        #endregion

        #region Navigation
       public void NoNavigation()
       {
           //There is no navigation on this page
       }
        #endregion
    }
}
