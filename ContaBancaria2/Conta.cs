using System;
using System.Globalization;

namespace ContaBancaria2
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double LimiteDeSaque { get; set; }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaque = 300.00;
        }

        public static void AtualizaSaldo(Conta conta, double valor)
        {
            conta.Saldo -= valor;
        }

    }
}