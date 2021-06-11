using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TesteSimplesArabico
    {
        [TestMethod]
        public void DeveRetornar1()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("I");

            Assert.AreEqual(1, aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar2()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("II");

            Assert.AreEqual(2, aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar3()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("III");

            Assert.AreEqual(3, aux.Resultado);
        }

 
        [TestMethod]
        public void DeveRetornar5()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("V");

            Assert.AreEqual(5, aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar6()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("VI");

            Assert.AreEqual(6, aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar10()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("X");

            Assert.AreEqual(10, aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar50()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("L");

            Assert.AreEqual(50, aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar100()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("C");

            Assert.AreEqual(100, aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar500()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("D");

            Assert.AreEqual(500, aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar1000()
        {
            ConversorArabicoSimples aux = new ConversorArabicoSimples("M");

            Assert.AreEqual(1000, aux.Resultado);
        }
    }
}
