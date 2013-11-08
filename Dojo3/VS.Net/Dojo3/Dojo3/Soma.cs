using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo3
{
    class Soma : Operacao
    {
        public Soma(double v1, double v2)
            : base(v1, v2)
        {
        }

        public override double executa()
        {
            return v1 + v2;
        }
    }
}
