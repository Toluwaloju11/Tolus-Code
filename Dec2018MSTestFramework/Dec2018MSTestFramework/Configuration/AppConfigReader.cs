using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.Interfaces;
using Dec2018MSTestFramework.Settings;

namespace Dec2018MSTestFramework.Configuration
{
   public class AppConfigReader : IConfig
    {
       public string GetUsername()
       {
           return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
       }

       public string GetPassword()  
       {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

       public string GetWebsite()
       {
           return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
       }

       public BrowserType GetBrowser()
       {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }
       
    }
}
