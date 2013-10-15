using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo2
{
    class Pedido
    {
        private int numero;
        private List<Produto> itens;

        public Pedido(int numero)
        {
            this.numero = numero;
            this.itens = new List<Produto>();
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public void Adiciona(Produto produto)
        {
            itens.Add(produto);
        }

        public int QuantidadeDeItens
        {
            get
            {
                return itens.Count();
            }
        }
    }
}
