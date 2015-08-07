using System;

namespace DesignerPaterns
{
    public class RespostaEmPorcento
    {
        private Resposta OutraReposta { get; set; }
        public RespostaEmPorcento(Resposta outraResposta)
        {
            this.OutraReposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            this.OutraReposta = null; // nao recebi a proxima!
        }
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else if (OutraReposta != null)
            {
                OutraReposta.Responde(req, conta);
            }
            else
            {
                // não existe próxima na corrente, e ninguém atendeu a requisição!
                // poderíamos não ter feito nada aqui, caso não fosse necessário!
                throw new Exception("Formato de resposta não encontrado");
            }

        } 
    }
}