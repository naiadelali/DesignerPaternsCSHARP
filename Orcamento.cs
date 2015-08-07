using System.Collections.Generic;

namespace DesignerPaterns
{
    public class Orcamento
    {
        public double Valor { get;  set; }
        public List<Item> Itens { get; private set; }
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public Orcamento(double valor, List<Item>  itens)
        {
            this.Valor = valor;
            this.Itens = itens;
            this.EstadoAtual = new EmAprovacao();
        }
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.EstadoAtual = new EmAprovacao();
            
        }

      

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
           this.Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }

   
}
