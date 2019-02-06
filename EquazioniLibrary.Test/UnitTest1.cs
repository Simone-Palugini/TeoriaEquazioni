using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        //test per equazione determinata
        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = 3;
            bool RespAttesa = true;
            bool Resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = -3;
            bool RespAttesa = true;
            bool Resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsDetermined3()
        {
            double a = 0;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(RespAttesa, Resp);
        }

        //test per equazione impossibile
        [TestMethod]
        public void TestIsInconsisted1()
        {
            double a = 0;
            bool RespAttesa = true;
            bool Resp = Equazioni.IsInconsisted(a);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted2()
        {
            double a = -3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted3()
        {
            double a = 3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a);
            Assert.AreEqual(RespAttesa, Resp);
        }

        //test per equazione indeterminata
    }
}
