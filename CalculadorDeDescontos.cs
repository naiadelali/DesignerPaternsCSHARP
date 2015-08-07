using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPaterns
{
    public class CalculadorDeDescontos
    {

        public double Calcula(Orcamento orcamento)
        {
            /* 1) Desconto de 10% para mais de 5 ítens;
             * 2) Desconto de 7% caso o valor da compra seja maior que 500,00 reais.*/
            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto d3 =  new DescontoPorVendaCasada();
            Desconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);


        }
    }
}
