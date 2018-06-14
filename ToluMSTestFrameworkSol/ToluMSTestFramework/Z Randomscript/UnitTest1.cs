using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToluMSTestFramework.Configuration;

namespace ToluMSTestFramework
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void MyUnitTestone()
        {
            Console.WriteLine("First test");
        }
       [TestMethod]
        public void MyUnitTesttwo()
        {
            Console.WriteLine("Second test");
        }
        [TestMethod]
        [TestCategory("config")]
        public void Sample()
        {
           //String conf = ConfigurationManager.AppSettings.Get("Browser");
            //Console.WriteLine(conf);

            AppConfigReader acr = new AppConfigReader();
            Console.WriteLine("The browser is {0}", acr.GetBrowser());
            Console.WriteLine("The password is {0}", acr.GetPassword());
            Console.WriteLine("The username is {0}", acr.GetUsername());
           
        }



    }
}
