using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo4
{
    abstract class Funcionario
    {
        protected string nome;
        protected double horas;
        protected double valordahora;

        public Funcionario(string nome, double horas, double valordahora)
        {
            this.nome = nome;
            this.horas = horas;
            this.valordahora = valordahora;
        }

        public virtual double CalculaSalario()
        {
            return horas * valordahora;
        }

        public string GetNome()
        {
            return nome;
        }
    }
}
