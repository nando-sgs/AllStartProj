using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do raio para calcular a área: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = 3.14159 * (raio * raio);

            Console.WriteLine($"O valor da area calculada é {result.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}