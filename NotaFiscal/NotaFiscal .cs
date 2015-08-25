using System;
using System.Collections.Generic;

namespace DesignerPaterns.NotaFiscal
{
    public class NotaFiscal 
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IList<ItemDaNota> Itens { get; private set; }
        public String Observacoes { get; private set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }
}