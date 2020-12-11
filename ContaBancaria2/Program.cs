using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = CriarConta();

        }
        public static Conta CriarConta()
        {
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Entre com o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            return new Conta(numero, titular, saldo);
        }
    }
}
