using System;

namespace DesignerPaterns
{
    public class Moderado 
    {
        private Random random;
        public Moderado()
        {
            this.random = new Random();
        }
        public double calcula(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.007;
        } 
    }
}