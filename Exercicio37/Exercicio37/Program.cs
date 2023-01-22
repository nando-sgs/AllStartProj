using System;
using System.Globalization;

namespace Exercicio37
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Fazer depósito inicial?(s/n): ");
            char confirm = char.Parse(Console.ReadLine());
            if (confirm == 's' || confirm == 'S')
            {
                Console.Write("Entre com o valor de deposito incial: \n");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            } else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine($"Dados da conta: {conta}");

            Console.Write("Entre com um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);

        }
    }
}