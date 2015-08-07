using System;

namespace DesignerPaterns
{
    public class Conta
    {
        public double Saldo { get;  set; }
        public String Titular { get; private set; }
        public String Agencia { get; private set; }
        public int Numero { get; private set; }
        public EstadoDaConta Estado { get; set; }

        public Conta(double saldo, string titular, string agencia, int numero)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.Agencia = agencia;
            this.Numero = numero;
        }

        public Conta()
        {
            
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }

      

       
    }
}