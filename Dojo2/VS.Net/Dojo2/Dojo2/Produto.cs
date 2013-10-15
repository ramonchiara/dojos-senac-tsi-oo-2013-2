using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo2
{
    class Produto
    {
        private string descricao;
        private decimal preco;

        public Produto(string descricao, decimal preco)
        {
            this.descricao = descricao;
            this.preco = preco;
        }

        public string Descricao
        {
            get
            {
                return this.descricao;
            }
        }

        public decimal Preco
        {
            get
            {
                return this.preco;
            }
        }
    }
}
