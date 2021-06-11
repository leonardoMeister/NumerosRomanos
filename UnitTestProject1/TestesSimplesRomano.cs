using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TestesSimplesRomano
    {
        [TestMethod]
        public void DeveRetornar1()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(1);

            Assert.AreEqual("I", aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar2()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(2);

            Assert.AreEqual("II", aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar3()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(3);

            Assert.AreEqual("III", aux.Resultado);
        }


        [TestMethod]
        public void DeveRetornar5()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(5);

            Assert.AreEqual("V", aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar6()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(6);

            Assert.AreEqual("VI", aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar10()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(10);

            Assert.AreEqual("X", aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar50()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(50);

            Assert.AreEqual("L", aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar100()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(100);

            Assert.AreEqual("C", aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar500()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(500);

            Assert.AreEqual("D", aux.Resultado);
        }

        [TestMethod]
        public void DeveRetornar1000()
        {
            ConversorRomanoSimples aux = new ConversorRomanoSimples(1000);

            Assert.AreEqual("M", aux.Resultado);
        }
    }
}

