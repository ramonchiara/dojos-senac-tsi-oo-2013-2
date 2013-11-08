using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo3
{
    class Divisao : Operacao
    {
        public Divisao(double v1, double v2)
            : base(v1, v2)
        {
        }

        public override double executa()
        {
            if (v2 == 0)
            {
                throw new ArgumentException();
            }

            return v1 / v2;
        }
    }
}
