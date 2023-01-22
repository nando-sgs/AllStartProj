using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 valores para calcular suas respectivas diferenças: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);
            Console.WriteLine($"a diferença entre os números digitados é: {diferenca}");

        }
    }
}