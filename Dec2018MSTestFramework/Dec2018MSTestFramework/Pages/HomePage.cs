using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.ComponentHelper;
using Dec2018MSTestFramework.Settings;
using OpenQA.Selenium;

namespace Dec2018MSTestFramework.Pages
{
    public class HomePage
    {
        #region WebElements

        private readonly By _desktopHeader = By.LinkText("Desktops");
        private readonly By _macOption = By.LinkText("Mac (1)");
        #endregion

        #region Actions
        public void SelectDesktopHeader()
        {
            ButtonHelper.ClickButton(_desktopHeader);
        }
        public void SelectMacOption()
        {

            ButtonHelper.ClickButton(_macOption);
        }
        #endregion

        public MacPage GoToMacPage()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
            SelectDesktopHeader();
            SelectMacOption();
            return new MacPage();
        }
        #region Navigation

        #endregion

    }
}
