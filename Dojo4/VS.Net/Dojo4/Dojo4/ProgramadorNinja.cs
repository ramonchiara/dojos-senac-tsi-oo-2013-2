using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo4
{
    class ProgramadorNinja: Funcionario
    {
        public ProgramadorNinja(string nome, double horas)
        :base(nome, horas, 1000)
        {
           
        }
    }
}
