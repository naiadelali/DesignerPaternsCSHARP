namespace DesignerPaterns
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(IImposto outroImposto):base(outroImposto)
        {
            
        }

        public ICPP()
        {
            
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
           //deve-se cobrar 5%;
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            //deve-se cobrar 7%;
            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            //caso o valor do orçamento seja menor que 500,00
            return orcamento.Valor >= 500.0 + CalculoDoOutroImposto(orcamento);
        }

    }
}