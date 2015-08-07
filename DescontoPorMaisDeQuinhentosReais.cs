using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPaterns
{
   
    public class DescontoPorMaisDeQuinhentosReais:Desconto
    {
        public Desconto Proximo { get; set; }
        //Desconto de 7% caso o valor da compra seja maior que 500,00 reais.
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor*0.07;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

    }
}
