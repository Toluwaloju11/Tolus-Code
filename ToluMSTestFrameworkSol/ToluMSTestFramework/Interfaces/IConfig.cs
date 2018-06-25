using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToluMSTestFramework.Configuration;

namespace ToluMSTestFramework.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUsername();
        string GetPassword();
        string GetWebsite();
        string GetGroceries();
        string GetEmail();
        string GetDemoHome();
        string GetDemoRegister();
        int GetPageTimeout();
    }
}
