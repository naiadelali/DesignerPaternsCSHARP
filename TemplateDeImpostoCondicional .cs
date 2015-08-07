namespace DesignerPaterns
{
    public abstract class TemplateDeImpostoCondicional :IImposto
    {
        public TemplateDeImpostoCondicional(IImposto outroImposto)
            : base(outroImposto)
        {
            
        }

        public TemplateDeImpostoCondicional()
        {
            
        }


        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }

        protected abstract double MinimaTaxacao(Orcamento orcamento);

        protected abstract double MaximaTaxacao(Orcamento orcamento);

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);

    }
}