using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignerPaterns
{
    [TestClass]
    public class CalculoTeste
    {
        //[TestMethod]
        //public void CalculaICCC()
        //{
        //    Orcamento reforma = new Orcamento(500.0);

        //    IImposto novoImposto = new ICCC();
        //    CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();
        //    calculadorDeImpostos.RealizaCalculo(reforma,novoImposto);
           
        //}
    }

    [TestClass]
    public class CalculoInvestimentoTeste
    {
        [TestMethod]
        public void CalculaICCC()
        {
            Conta conta = new Conta();
            conta.Deposita(500);

            Investimento arrojado = new Conservador();
            RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();
            realizadorDeInvestimentos.Realiza(conta,arrojado);

        }
    }
}
