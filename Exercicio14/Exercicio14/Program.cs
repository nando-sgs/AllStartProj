using System;
using System.Globalization;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número do eixo X:");
            double eixox = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com um número do eixo Y:");
            double eixoy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (eixox == eixoy && eixox == 0 && eixoy == 0)
            {
                Console.WriteLine("Origem do plano cartesiano");
            } 
            else if (eixox > 0 && eixoy > 0) {
                Console.WriteLine("Q1");
            } 
            else if (eixox < 0 && eixoy > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (eixox < 0 && eixoy < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (eixoy < 0 && eixox > 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}