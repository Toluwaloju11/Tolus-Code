using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToluMSTestFramework.Configuration;

namespace ToluMSTestFramework.Z_Randomscript
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod, TestCategory("ToluTest")]
        public void MyUnitTestone()
        {
            Console.WriteLine("First test");
        }

    }
}
