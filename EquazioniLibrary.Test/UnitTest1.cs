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
            bool RespAttesa = false;
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
            bool RespAttesa = true;
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
            bool RespAttesa = true;
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
            bool RespAttesa = true;
            bool Resp = Equazioni.IsIndetermined(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsIndetermined4()
        {
            double a = 0, b = 3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsIndetermined(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        [TestMethod]
        public void TestIsIndetermined5()
        {
            double a = 0, b = -3;
            bool RespAttesa = false;
            bool Resp = Equazioni.IsIndetermined(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }

        //test equazione di secondo grado       
        [TestMethod]
        public void TestIsDegree2_1()
        {
            double a = 0, b = 0;
            string RespAttesa = "indeterminata";
            Convert.ToString(a);
            Convert.ToString(b);
            string Resp = Equazioni.IsDegree2(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void TestIsDegree2_2()
        {
            double a = 0, b = 3;
            string RespAttesa = "impossibile";
            Convert.ToString(a);
            Convert.ToString(b);
            string Resp = Equazioni.IsDegree2(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void TestIsDegree2_3()
        {
            double a = 4, b = 8;
            string RespAttesa = "2";
            Convert.ToString(a);
            Convert.ToString(b);
            string Resp = Equazioni.IsDegree2(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void TestIsDegree2_4()
        {
            double a = 5, b = 15;
            string RespAttesa = "3";
            Convert.ToString(a);
            Convert.ToString(b);
            string Resp = Equazioni.IsDegree2(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
        
        // test controllo delta
        [TestMethod]
        public void Delta1()
        {
            double a = 8, b = 0, c = 2;
            //string RespAttesa = "il delta non si può fare";
            double RespAttesa = -64;
            double Resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void Delta2()
        {
            double a = 0, b = 8, c = 2;
            //string RespAttesa = "equazione 1° grado";
            double RespAttesa = 64;
            double Resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void Delta3()
        {
            double a = 5, b = 3, c = 2;
            double RespAttesa = -31;
            double Resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void Delta4()
        {
            double a = 8, b = 2, c = 0;
            //string RespAttesa = "il delta non si può fare";
            double RespAttesa = 4;
            double Resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void Delta5()
        {
            double a = 5, b = 8, c = 6;
            double RespAttesa = -56;
            double Resp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(RespAttesa, Resp);
        }

        //test equazione 1° grado
        [TestMethod]
        public void EquationDegree1_1()
        {
            double a = 0, b = 2;
            string RespAttesa = "impossibile";
            Convert.ToString(a);
            Convert.ToString(b);
            string Resp = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void EquationDegree1_2()
        {
            double a = 0, b = 0;
            string RespAttesa = "indeterminata";
            Convert.ToString(a);
            Convert.ToString(b);
            string Resp = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void EquationDegree1_3()
        {
            double a = 6, b = 12;
            string RespAttesa = "-2";
            Convert.ToString(a);
            Convert.ToString(b);
            string Resp = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
        [TestMethod]
        public void EquationDegree1_4()
        {
            double a = 20, b = 10;
            string RespAttesa = "-0,5";
            Convert.ToString(a);
            Convert.ToString(b);
            string Resp = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(RespAttesa, Resp);
        }
    }




}
