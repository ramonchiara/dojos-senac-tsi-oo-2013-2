using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    public class Pedido
    {
        private string nome;
        private int qtde;
        private decimal preco;

        public Pedido(string nome, int qtde, decimal preco)
        {
            this.nome = nome;
            this.qtde = qtde;
            this.preco = preco;
        }

        public string Nome { get { return this.nome; } set { this.nome = value; } }
        public int Qtde { get { return this.qtde; } set { this.qtde = value; } }
        public decimal Preco { get { return this.preco; } set { this.preco = value; } }
    }
}