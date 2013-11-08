using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo3
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TestaSoma()
        {
            Soma operacao = new Soma(10, 20);

            double resultado = operacao.executa();

            Assert.AreEqual(30, resultado);
        }

        [TestMethod]
        public void TestaSubtracao()
        {
            Subtracao operacao = new Subtracao(10, 20);

            double resultado = operacao.executa();

            Assert.AreEqual(-10, resultado);
        }

        [TestMethod]
        public void TestaMultiplicacao()
        {
            Multiplicacao operacao = new Multiplicacao(10, 20);

            double resultado = operacao.executa();

            Assert.AreEqual(200, resultado);
        }

        [TestMethod]
        public void TestaDivisao()
        {
            Divisao operacao = new Divisao(10, 20);

            double resultado = operacao.executa();

            Assert.AreEqual(0.5, resultado);
        }

        [TestMethod]
        public void TestaDivisaoPorZero()
        {
            try
            {
                Divisao operacao = new Divisao(10, 0);

                double resultado = operacao.executa();

                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void TestaSomaPolimorfica()
        {
            Operacao op = new Soma(1, 2);

            double resultado = op.executa();

            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void TestaSubtracaoPolimorfica()
        {
            Operacao op = new Subtracao(1, 2);

            double resultado = op.executa();

            Assert.AreEqual(-1, resultado);
        }


        [TestMethod]
        public void TestaMultiplicacaoPolimorfica()
        {
            Operacao op = new Multiplicacao(1, 2);

            double resultado = op.executa();

            Assert.AreEqual(2, resultado);
        }


        [TestMethod]
        public void TestaDivisaoPolimorfica()
        {
            Operacao op = new Divisao(1, 2);

            double resultado = op.executa();

            Assert.AreEqual(0.5, resultado);
        }

        [TestMethod]
        public void TestaCriaSoma()
        {
            Operacao op = Calculadora.criaOperacao(10, 20, "+");

            double resultado = op.executa();

            Assert.AreEqual(30, resultado);
        }

        [TestMethod]
        public void TestaCriaSubtracao()
        {
            Operacao op = Calculadora.criaOperacao(44, 11, "-");

            double resultado = op.executa();

            Assert.AreEqual(33, resultado);
        }

        [TestMethod]
        public void TestaCriaMultiplicacao()
        {
            Operacao op = Calculadora.criaOperacao(44, 10, "*");

            double resultado = op.executa();

            Assert.AreEqual(440, resultado);
        }

        [TestMethod]
        public void TestaCriaDivisao()
        {
            Operacao op = Calculadora.criaOperacao(1000, 40, "/");

            double resultado = op.executa();

            Assert.AreEqual(25, resultado);
        }
    }
}
