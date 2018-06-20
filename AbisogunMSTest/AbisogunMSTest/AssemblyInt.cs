using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToluMSTestFramework
{
    [TestClass]
    public class AssemblyInt
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext tc)
        {
            Console.WriteLine("This is before Assembly");
        }
        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Console.WriteLine("This is After Assembly");
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
