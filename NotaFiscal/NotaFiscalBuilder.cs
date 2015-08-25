using System;
using System.Collections.Generic;

namespace DesignerPaterns.NotaFiscal
{
    public class NotaFiscalBuilder  
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public String Observacoes { get; private set; }
        public IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();

        public NotaFiscal Constroi()
        {
            NotaFiscal notaFiscal= new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);


            foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }


            return notaFiscal;
        }

        

        public NotaFiscalBuilder()
        {
            this.todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }


        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }
 
    }
}