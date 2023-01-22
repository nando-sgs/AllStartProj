using System;
using System.Globalization;

namespace Exercicio36
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta cliente = new Conta();
            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            cliente.SetNum(num);

            Console.Write("Entre o nome da conta: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Deseja fazer um depósito inicial?(S/N): ");
            string choice = Console.ReadLine();

            if (choice == "s")
            {
                Console.Write("Entre com o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente.SetDeposit(deposito);
                Console.WriteLine($"Dados: {cliente}");


            }
            else if (choice == "n")
            {           
                Console.WriteLine($"Dados: {cliente}");

            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.GetSaque(saque);
            Console.WriteLine($"Dados atualizados: {cliente} ");

            
            
            

        }
    }
}