using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.Configuration;

namespace Dec2018MSTestFramework.Interfaces
{
   public interface IConfig
   {
       string GetUsername();
       string GetPassword();
       string GetWebsite();
       BrowserType GetBrowser();

    }
}
