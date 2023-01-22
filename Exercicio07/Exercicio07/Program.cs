using System;
using System.Globalization;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * (c * c);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine($"O triangulo tem area de {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A area do circulo é de {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A area do trapezio é de {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A area do quadrado é de {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A area do retangulo é de {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}