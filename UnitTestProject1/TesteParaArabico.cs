using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TesteParaArabico
    {
        [TestMethod]
        public void DeveRetornar1()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("I");

            Assert.AreEqual(1, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar2()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("II");

            Assert.AreEqual(2, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar3()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("III");

            Assert.AreEqual(3, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar4()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("IV");

            Assert.AreEqual(4, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar5()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("V");

            Assert.AreEqual(5, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar6()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("VI");

            Assert.AreEqual(6, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar10()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("X");

            Assert.AreEqual(10, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar50()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("L");

            Assert.AreEqual(50, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar100()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("C");

            Assert.AreEqual(100, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar500()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("D");

            Assert.AreEqual(500, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar1000()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("M");

            Assert.AreEqual(1000, aux.NumeroArabico);
        }
        [TestMethod]
        public void DeveRetornar5000()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("V̄");

            Assert.AreEqual(5000, aux.NumeroArabico);
        }

        [TestMethod]
        public void DeveRetornar10000()
        {
            RomanosParaNumeros aux = new RomanosParaNumeros();

            aux.NumerosRomanosParaArabicos("X̄");

            Assert.AreEqual(10000, aux.NumeroArabico);
        }
    }
}
