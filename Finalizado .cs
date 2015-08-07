using System;

namespace DesignerPaterns
{
    public class Finalizado :EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não pode alterar o estado.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não pode alterar o estado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não pode alterar o estado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não pode alterar o estado.");
        }
    }
}