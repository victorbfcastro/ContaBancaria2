using System;
namespace ContaBancaria2
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaque { get; set; }

        public Conta()
        {

        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }


    }
}
