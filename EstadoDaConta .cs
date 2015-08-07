namespace DesignerPaterns
{
    public interface EstadoDaConta 
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor); 
    }
}