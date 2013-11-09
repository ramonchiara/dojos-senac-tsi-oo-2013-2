using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo4
{
    class ProgramadorSenior : Funcionario
    {
        public ProgramadorSenior(string nome, double horas)
            : base(nome, horas, 80)
        {
        }
    }
}
