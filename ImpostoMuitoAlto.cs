namespace DesignerPaterns
{
    public class ImpostoMuitoAlto:IImposto
    {
        public ImpostoMuitoAlto(){}

        public ImpostoMuitoAlto(IImposto outroImposto):base(outroImposto){}

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor*0.20 + CalculoDoOutroImposto(orcamento);
        }
    }
}