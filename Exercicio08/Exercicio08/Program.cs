using System;

namespace Exercicio0
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um número");
            int x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não negativo");
            }

        }
    }
}