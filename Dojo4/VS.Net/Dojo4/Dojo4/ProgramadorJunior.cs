using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo4
{
    
    class ProgramadorJunior : Funcionario
    {
        public ProgramadorJunior(string nome, double horas)
        :base(nome, horas, 30)
        {
           
        }
    }
}
