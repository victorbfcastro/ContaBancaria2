using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    class SistemaBanco
    {
        public static void CriarConta()
        {
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular: ");
            string titular = Console.ReadLine();

            Console.Write("Entre com o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            Conta conta = new Conta(numero, titular, saldo);

            Console.WriteLine($"\nConta de {conta.Titular} criada com sucesso!");

            MenuConta(conta);
        }

        public static void MenuConta(Conta conta)
        {
            Console.WriteLine("\n>> Menu da Conta");
            Console.Write($">> Olá, {conta.Titular}! Escolha uma opção abaixo:\n" +
                "\n[1] Sacar\n" +
                "[2] Ver Saldo\n" +
                "[3] Sair\n" +
                "\nOpção: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    {
                        Console.Write("Informe o valor para saque: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        Saque(conta, valorSaque);

                        break;
                    }
                case 2:
                    {
                        InformaSaldo(conta);
                        break;
                    }
                case 3:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
            MenuConta(conta);

        }
        public static void Saque(Conta conta, double valor)
        {
            if (conta.Saldo < valor)
            {
                Console.WriteLine("\n> Erro: Saldo insuficiente!");
            }
            else if (valor > conta.LimiteDeSaque)
            {
                Console.WriteLine($"\n>Erro: Valor excedeu o limite de saque! (Seu limite: {conta.LimiteDeSaque})");
            }
            else
            {
                Conta.AtualizaSaldo(conta, valor);
                InformaSaldo(conta);
            }

        }
        public static void InformaSaldo(Conta conta)
        {
            Console.WriteLine($"\n> Saldo de {conta.Titular}: ");
            Console.WriteLine($"R$ {conta.Saldo.ToString("F2")}");
        }

    }
}
