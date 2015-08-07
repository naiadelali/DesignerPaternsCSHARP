namespace DesignerPaterns
{
    public interface Resposta 
    {
        void Responde(Requisicao req, Conta conta);
        Resposta Proxima { get; set; } 
    }
}