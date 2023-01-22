using System;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um número de 1 a 1000");
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i<=num1;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}