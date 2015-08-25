using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPaterns.NotaFiscal
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando por e-mail");
        }
    }
}
