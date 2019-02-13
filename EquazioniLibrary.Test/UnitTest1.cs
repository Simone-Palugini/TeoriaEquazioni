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
            double a = 0, b = 0;
            bool RespAttesa = true;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted2()
        {
            double a = -3, b = 0;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted3()
        {
            double a = 0, b = -3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted4()
        {
            double a = -3, b = -3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted5()
        {
            double a = 2, b = -3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted6()
        {
            double a = -3, b = 3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted7()
        {
            double a = 3, b = -3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted8()
        {
            double a = -3, b = 2;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted9()
        {
            double a = 0, b = 3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted10()
        {
            double a = 3, b = 0;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted11()
        {
            double a = 3, b = 3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted12()
        {
            double a = 3, b = 2;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted13()
        {
            double a = 2, b = 3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsInconsisted14()
        {
            double a = -2, b = 3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        //test per equazione indeterminata

        [TestMethod]
        public void TestIsIndetermined1()
        {
            double a = 3, b = 0;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsIndetermined(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsIndetermined2()
        {
            double a = -3, b = 0;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsIndetermined(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsIndetermined3()
        {
            double a = 0, b = 0;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsIndetermined(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsIndetermined4()
        {
            double a = 0, b = 3;
            bool RespAttesa = true;
            bool Resp = Equazioni.IsIndetermined(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsIndetermined5()
        {
            double a = 0, b = -3;
            bool RespAttesa = true;
            bool Resp = Equazioni.IsIndetermined(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
    }




}
