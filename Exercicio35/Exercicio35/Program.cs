using System;
using System.Globalization;

namespace Exercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoedas conv = new ConversorDeMoedas();
            Console.Write("Entre com a cotação atual: ");
            conv.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares irá comprar?:U$ ");
            conv.Conversao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = conv.Converter();
            Console.WriteLine($"Valor a ser pago em reais: R${conv}");
        }
    }
}