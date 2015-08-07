using System.Collections.Generic;

namespace DesignerPaterns
{
    public class GerenciadorDeRelatorio
    {
        public void GerarRelatorio(List<Conta> contas, Relatorio relatorio)
        {
           relatorio.Imprime(contas);
        }
    }
}