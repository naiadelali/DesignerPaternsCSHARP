using System;

namespace DesignerPaterns.NotaFiscal
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("salvando no banco");
        }
    }
}