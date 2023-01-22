using System;

namespace Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;i<=n; i++)
            {
                int mult = (i * i) * i;
                Console.WriteLine($"{i} {i * i} {mult}");
            }
        }
    }
}