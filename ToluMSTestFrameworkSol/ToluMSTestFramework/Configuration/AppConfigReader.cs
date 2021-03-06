﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToluMSTestFramework.Interfaces;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.Configuration
{
   public class AppConfigReader : IConfig
    {
       public BrowserType GetBrowser()
       {
           var browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
           return (BrowserType) Enum.Parse(typeof (BrowserType), browser);
       }
       
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
        public string GetDemoRegister()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.DemoRegister);
        }
        public string GetGoCompareHome()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.GoCompareHome);
        }

        public int GetPageTimeout()
       {
          var Timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageTimeout);
           if (Timeout == null)
           {
               return 30;
           }
           return Convert.ToInt32(Timeout);
       }

       public string GetDemoHome()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.DemoHome);
        }

        public string GetGroceries()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Groceries);
        }
        public string GetEmail()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Email);
        }
        
    }
}
