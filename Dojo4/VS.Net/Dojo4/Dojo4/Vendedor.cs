using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo4
{
    class Vendedor
    {
        protected string nome;
        protected double vendas;

        public Vendedor(string nome, double vendas)
        {
            this.nome = nome;
            this.vendas = vendas;
        }

        public double CalculaSalario()
        {
            return (vendas * 0.2 + 2000);
        }

        public string GetNome()
        {
            return nome;
        }
    }
}

