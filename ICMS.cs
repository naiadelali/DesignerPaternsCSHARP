namespace DesignerPaterns
{
    public class ICMS : IImposto
    {
        public ICMS(IImposto outroImposto) :base(outroImposto)
        {
            
        }

        public ICMS()
        {
           
        }
        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50.0 + CalculoDoOutroImposto(orcamento);
        }

     
    }
}
