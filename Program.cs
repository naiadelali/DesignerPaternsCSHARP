using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DesignerPaterns.NotaFiscal;


namespace DesignerPaterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*************CALCULO DE DESCONTO *************/
            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(500.0, new List<Item>());
            //orcamento.AdicionaItem(new Item("CANETA",250));
            //orcamento.AdicionaItem(new Item("LAPIS",250));

            //var desconto = calculador.Calcula(orcamento);

            //Console.WriteLine(desconto);

            /******************IMPOSTO - METHOD TEMPLATE ************************/
            //CalculadorDeImpostos calculadorDeImpostos =  new CalculadorDeImpostos();

            //Orcamento orcamento = new Orcamento(500.0, new List<Item>());
            //orcamento.AdicionaItem(new Item("CANETA", 250));
            //orcamento.AdicionaItem(new Item("LAPIS", 250));
            //IImposto ikcv = new IHIT();
            //calculadorDeImpostos.RealizaCalculo(orcamento,ikcv);

            /******************* RELATORIOS - METHOD TEMPLATE ********************/
       
            //List<Conta> contas = new List<Conta>(){new Conta(500,"Naiade","xxx-xx",111222)};
            //GerenciadorDeRelatorio gerenciadorDeRelatorio = new GerenciadorDeRelatorio();
            //Relatorio complexo = new RelatorioComplexo();

            //gerenciadorDeRelatorio.GerarRelatorio(contas, complexo );

            //*********************IMPOSTO - DECORATOR********************

            //IImposto impostoComplexo = new IKCV(new ICPP());

            //Orcamento orcamento = new Orcamento(500.0);

            //double valor = impostoComplexo.Calcula(orcamento);

            //Console.WriteLine(valor);

            /************ STATE - ORÇAMENTO******************/

            //Orcamento reforma = new Orcamento(500.0);

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
            //reforma.Aprova(); // aprova nota!

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

            //reforma.Finaliza();

            //// reforma.AplicaDescontoExtra(); lancaria excecao, pois não pode dar desconto nesse estado
            //// reforma.Aprova(); lança exceção, pois não pode ir para aprovado

            //Conta conta= new Conta(500,"naiade","xxx-xx",111222);
            //EstadoDaConta estadoDaConta = new Negativo();
            //estadoDaConta.Deposita(conta, 200);

            /********************BUILDER****************/
            //NotaFiscalBuilder criador = new NotaFiscalBuilder();
            //criador.ParaEmpresa("Caelum");
            //criador.ComCnpj("123.456.789/0001-10");
            //criador.ComItem(new ItemDaNota("item 1", 100.0));
            //criador.ComItem(new ItemDaNota("item 2", 200.0));
            //criador.ComItem(new ItemDaNota("item 3", 300.0));
            //criador.ComObservacoes("entregar nf pessoalmente");
            //criador.NaDataAtual();

            //NotaFiscal.NotaFiscal nf = criador.Constroi();

            //Console.WriteLine(nf.Cnpj);
            //Console.ReadKey();

            /************Observer1****************/

            //NotaFiscalBuilder builder = new NotaFiscalBuilder();
            //builder.AdicionaAcao(new EnviadorDeEmail());
            //builder.AdicionaAcao(new NotaFiscalDao());
            //builder.AdicionaAcao(new EnviadorDeSms());
          

            //NotaFiscal.NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
            //                    .ComCnpj("123.456.789/0001-10")
            //                    .ComItem(new ItemDaNota("item 1", 100.0))
            //                    .ComItem(new ItemDaNota("item 2", 200.0))
            //                    .ComItem(new ItemDaNota("item 3", 300.0))
            //                    .ComObservacoes("entregar notaFiscal pessoalmente")
            //                    .NaDataAtual()
            //                    .Constroi();

            /************Observer2****************/
            //NotaFiscalBuilder builder = new NotaFiscalBuilder();
            //builder.AdicionaAcao(new Multiplicador(2));
            //builder.AdicionaAcao(new Multiplicador(3));
            //builder.AdicionaAcao(new Multiplicador(5.5));

            //NotaFiscal.NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
            //    .ComCnpj("123.456.789/0001-10")
            //    .ComItem(new ItemDaNota("item 1", 100.0))
            //    .ComItem(new ItemDaNota("item 2", 200.0))
            //    .ComItem(new ItemDaNota("item 3", 300.0))
            //    .ComObservacoes("entregar notaFiscal pessoalmente")
            //    .NaDataAtual()
            //    .Constroi();
            //Console.ReadKey();

        }

      


    }
}
