using System;

namespace DesignerPaterns
{
    public class RespostaEmXml 
    {
        public Resposta OutraReposta { get; set; }
        public RespostaEmXml(Resposta outraResposta)
        {
            this.OutraReposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraReposta.Responde(req, conta);
            }
        }   
    }
}