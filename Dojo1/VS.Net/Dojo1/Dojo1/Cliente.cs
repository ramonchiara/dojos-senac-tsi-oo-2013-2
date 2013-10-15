using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    public class Cliente
    {
        private string nome;
        private string telefone;

        public Cliente(string name, string tel)
        {
            this.nome = name;
            this.telefone = tel;
        }

        public string Nome { get { return this.nome; } }
        public string Telefone { get { return this.telefone; } }
    }
}
