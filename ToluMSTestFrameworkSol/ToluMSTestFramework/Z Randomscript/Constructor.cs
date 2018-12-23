using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ToluMSTestFramework.Z_Randomscript
{
    [TestClass]
    public class Constructor
    {
        //[ClassInitialize]
        //public void ConnectToDb(TestContext tc)  
        //{
        //    Console.WriteLine("Connect to Database");  
        //}
        ////1. Constructors are auto called when a method is called in the main method. 
        ////2. If there is more than one arguement, then the one declared during object creation will be called.
        [TestInitialize]
        public void Normalmathod2()
        {
            Console.WriteLine("Test Init");
        }
        [TestMethod] 
        public  void FirstMethod()
        {
            Console.WriteLine("This is the First Method");
        }
        [TestMethod, TestCategory("toluuuuu")]
        public void SecondMethod()
        {
            Console.WriteLine("This is the second method");
        }
        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine("Test Cleanup");
        }
        //[ClassCleanup]
        //public void DisconnectfromDB()
        //{
        //    Console.WriteLine("Connect to Database");
        //}

    }
}
