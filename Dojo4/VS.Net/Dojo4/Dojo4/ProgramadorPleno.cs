using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo4
{
    class ProgramadorPleno : Funcionario
    {
        public ProgramadorPleno(string nome, double horas)
            : base(nome, horas, 45)
        {
        }
    }
}
