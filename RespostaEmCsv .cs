﻿using System;

namespace DesignerPaterns
{
    public class RespostaEmCsv 
    {
        public Resposta OutraReposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraReposta.Responde(req, conta);
            }
        } 
    }
}