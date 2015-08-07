using System.Linq;

namespace DesignerPaterns
{
    public class IKCV:TemplateDeImpostoCondicional
    {
        public IKCV(IImposto outroImposto)
            : base(outroImposto)
        {
            
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            //6
            return orcamento.Valor*0.06;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            // 10%
            return orcamento.Valor * 0.1;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            //caso o valor do orçamento seja maior que 500,00 e algum item tiver valor superior a 100,00
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            return orcamento.Itens.Any(item => item.Valor > 100.0);
        }
     
    }
}