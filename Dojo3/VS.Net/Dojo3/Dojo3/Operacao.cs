using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo3
{
    class Operacao
    {
        protected double v1;
        protected double v2;

        public Operacao(double v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public virtual double executa()
        {
            return 0.5;
        }

    }
}
