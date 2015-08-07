using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignerPaterns
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; private set; }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }


        public IImposto(IImposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public IImposto()
        {
            this.OutroImposto = null;
        }
    }
}
