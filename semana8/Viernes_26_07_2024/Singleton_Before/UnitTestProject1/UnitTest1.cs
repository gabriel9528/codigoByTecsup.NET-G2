using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var finder = new SingletonFinder(new DataPrueba());
            var total = finder.GetTotalPopultaion(new[] { "Lima", "Brasilia" });

            Assert.AreEqual(9751717+ 3039444, total);
        }
    }
}
