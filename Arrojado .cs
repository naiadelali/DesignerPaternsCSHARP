﻿using System;

namespace DesignerPaterns
{
    public class Arrojado 
    {
        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }
        public double calcula(Conta conta)
        {
            int chute = random.Next(10);
            if (chute >= 0 && chute <= 1) return conta.Saldo * 0.5;
            else if (chute >= 2 && chute <= 4) return conta.Saldo * 0.3;
            else return conta.Saldo * 0.006;
        } 
    }
}