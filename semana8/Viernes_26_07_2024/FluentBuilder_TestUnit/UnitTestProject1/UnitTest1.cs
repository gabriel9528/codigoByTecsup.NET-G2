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
            //Saludo saludo = new Saludo();
            //saludo.HoraDelDia = "Tarde";
            //saludo.SaludarA = "Gabriel";

            Saludo saludo = new SaludoBuilder()
                .HoraDelDia("Tardesss")
                .SaludarA("Gabriel")
                .Build();

            Assert.AreEqual("Buenas Tardes, Gabriel", saludo.Message);
        }
    }
}
