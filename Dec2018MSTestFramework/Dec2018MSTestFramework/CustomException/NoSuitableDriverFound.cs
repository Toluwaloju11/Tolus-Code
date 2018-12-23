using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.Configuration;

namespace Dec2018MSTestFramework.CustomException
{
    public class NoSuitableDriverFound: Exception
    {

        public NoSuitableDriverFound(string message, BrowserType getBrowser) : base (message)
        {
            
        }
    }
}
