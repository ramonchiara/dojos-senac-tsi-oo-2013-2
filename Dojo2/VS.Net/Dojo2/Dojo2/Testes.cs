using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo2
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void DevoPoderCriarUmCliente()
        {
            Cliente cliente = new Cliente("João", "11 555-8888");

            Assert.AreEqual("João", cliente.Nome);
            Assert.AreEqual("11 555-8888", cliente.Telefone);
        }

        [TestMethod]
        public void DevoPoderCriarUmPedido()
        {
            Pedido pedido = new Pedido(3412);

            Assert.AreEqual(3412, pedido.Numero);
        }

        [TestMethod]
        public void DevoPoderCriarUmProduto()
        {
            Produto produto = new Produto("CPU", 600M);

            Assert.AreEqual("CPU", produto.Descricao);
            Assert.AreEqual(600M, produto.Preco);
        }

        [TestMethod]
        public void DevoPoderAdicionarUmProdutoAoPedido()
        {
            Produto produto = new Produto("CPU", 600M);
            Pedido pedido = new Pedido(3412);

            pedido.Adiciona(produto);

            Assert.AreEqual(1, pedido.QuantidadeDeItens);
        }

        [TestMethod]
        public void DevoPoderAdicionarDoisProdutoAoPedido()
        {
            Produto produto1 = new Produto("CPU", 600M);
            Produto produto2 = new Produto("RAM 1Gb", 100M);
            Pedido pedido = new Pedido(3412);

            pedido.Adiciona(produto1);
            pedido.Adiciona(produto2);

            Assert.AreEqual(2, pedido.QuantidadeDeItens);
        }
    }
}
