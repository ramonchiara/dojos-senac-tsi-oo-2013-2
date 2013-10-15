using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo2
{
    class Cliente
    {
        private string nome;
        private string telefone;

        public Cliente(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }

        }

        public string Telefone
        {
            get
            {
                return this.telefone;
            }
            set
            {
                this.telefone = value;
            }

        }
    }
}
