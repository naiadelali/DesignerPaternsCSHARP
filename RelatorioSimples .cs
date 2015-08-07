using System;
using System.Collections.Generic;

namespace DesignerPaterns
{
    public class RelatorioSimples :Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine(conta.Titular + " - " + conta.Saldo);
            }
        }
    }
}