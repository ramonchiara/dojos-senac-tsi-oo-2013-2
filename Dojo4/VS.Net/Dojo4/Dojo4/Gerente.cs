using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo4
{
    class Gerente : Funcionario
    {
        protected double bonus;

        public Gerente(string nome, double horas, double bonus)
            : base(nome, horas, 100)
        {
            this.bonus = bonus;
        }

        public override double CalculaSalario()
        {
            return base.CalculaSalario() + bonus;
        }
    }
}
