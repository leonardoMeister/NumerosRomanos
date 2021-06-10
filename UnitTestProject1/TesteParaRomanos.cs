using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TesteParaRomanos
    {
        [TestMethod]
        public void DeveRetornarI()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(1);

            Assert.AreEqual("I" , aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarII()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(2);

            Assert.AreEqual("II", aux.NumeroRomano);
        }
        [TestMethod]
        public void DeveRetornarIII()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(3);

            Assert.AreEqual("III", aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarV()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(5);

            Assert.AreEqual("V", aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarIV()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(4);

            Assert.AreEqual("IV", aux.NumeroRomano);
        }
        [TestMethod]
        public void DeveRetornarX()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(10);

            Assert.AreEqual("X", aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarC()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(100);

            Assert.AreEqual("C", aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarL()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(50);

            Assert.AreEqual("L", aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarM()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(1000);

            Assert.AreEqual("M", aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarD()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(500);

            Assert.AreEqual("D", aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarV̄()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(5000);

            Assert.AreEqual("V̄", aux.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarX̄()
        {
            NumerosParaRomanos aux = new NumerosParaRomanos();

            aux.NumerosArabicosParaRomanos(10000);

            Assert.AreEqual("X̄", aux.NumeroRomano);
        }

    }
}
