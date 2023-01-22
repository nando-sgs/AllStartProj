using System;
using System.Globalization;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do lanche: ");
            int codlanche = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que irá querer");
            int quant = int.Parse(Console.ReadLine());
            double[] lanches = { 0.00, 4.00, 4.50, 5.00, 2.00, 1.50 };
            double preco = quant * lanches[codlanche];
            if (codlanche == 1)
            {
                Console.WriteLine($"{quant} cachorro quente, o valor total é R${preco.ToString("F2", CultureInfo.InvariantCulture)}");
            } else if (codlanche == 2)
            {
                Console.WriteLine($"{quant} x-saladas , o valor total é R${preco.ToString("F2", CultureInfo.InvariantCulture)}");

            } else if (codlanche == 3)
            {
                Console.WriteLine($"{quant} X-Bacon, o valor total é R${preco.ToString("F2", CultureInfo.InvariantCulture)}");

            } else if (codlanche == 4)
            {
                Console.WriteLine($"{quant} torrada simples, o valor total é R${preco.ToString("F2", CultureInfo.InvariantCulture)}");

            } else if (codlanche == 5)
            {
                Console.WriteLine($"{quant} refrigerante, o valor total é R${preco.ToString("F2", CultureInfo.InvariantCulture)}");

            }
        }
    }
}