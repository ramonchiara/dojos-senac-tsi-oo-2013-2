using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo4
{
    class Folha
    {
        protected List<Funcionario> funcionarios;
        protected double pagamento;

        public Folha(List<Funcionario> funcionarios)
        {
            this.funcionarios = funcionarios;
            pagamento = 0;
        }

        public double GetTotal() { 
        
            foreach(Funcionario f in funcionarios){
                pagamento += f.CalculaSalario();

            }
            return pagamento;
        }
    }
}
