using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo3
{
    class Calculadora : Operacao
    {
        public Calculadora(double v1, double v2)
            : base(v1, v2)
        {

        }
        public static Operacao criaOperacao(double v1, double v2, string operador)
        {
            if (operador == "+")
            {
                return new Soma(v1, v2);
            }
            else if (operador == "-")
            {
                return new Subtracao(v1, v2);
            }
            else if (operador == "*")
            {
                return new Multiplicacao(v1, v2);
            }
            else if (operador == "/")
            {
                return new Divisao(v1, v2);
            }
            else
            {
                return null;
            }
        }
    }
}
