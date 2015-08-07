﻿namespace DesignerPaterns
{
    public class ICCC:IImposto
    {
        public ICCC(IImposto outroImposto) :base(outroImposto)
        {
                
        }
        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return 0.05 * orcamento.Valor + CalculoDoOutroImposto(orcamento);
            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return 0.07 * orcamento.Valor + CalculoDoOutroImposto(orcamento);
            }
            else
            {
                return 0.08 * orcamento.Valor + 30.0 + CalculoDoOutroImposto(orcamento);
            }
        }

     
    }
}
