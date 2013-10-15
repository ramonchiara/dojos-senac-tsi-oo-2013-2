using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dojo1;

namespace Testes
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n1 = 10;
            int n2 = 20;

            Somador somador = new Somador();
            int resultado = somador.adiciona(n1, n2);

            int esperado = 30;
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void cliente_com_o_nome_e_telefone()
        {
            string nome = "Ramon";
            string telefone = "9999-9999";

            Cliente cliente = new Cliente(nome, telefone);

            Assert.AreEqual("Ramon", cliente.Nome);
            Assert.AreEqual("9999-9999", cliente.Telefone);
        }

        [TestMethod]
        public void cliente_faz_pedido()
        {
            string nomeProduto = "Celular";
            int qtdeProduto = 1;
            decimal preco = 500M;

            Pedido pedido = new Pedido(nomeProduto, qtdeProduto, preco);

            Assert.AreEqual("Celular", pedido.Nome);
            Assert.AreEqual(1, pedido.Qtde);
            Assert.AreEqual(500M, pedido.Preco);
        }
    }
}
