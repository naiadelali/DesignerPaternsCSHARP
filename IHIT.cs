using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignerPaterns
{
    public class IHIT:TemplateDeImpostoCondicional
    {

        public IHIT(IImposto outroImposto)
            : base(outroImposto)
        {
            
        }
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            /*Crie o imposto IHIT, que tem a seguinte regra: caso existam 2 ítens com o mesmo nome, o imposto deve ser de 13% mais R$100,00.
             * Caso contrário, o valor do imposto deverá ser (1% * o número de ítens no orçamento).*/

            IList<String> noOrcamento = new List<string>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome)) return true;
                else noOrcamento.Add(item.Nome);
            }

            return false;
        }

    
    }
}