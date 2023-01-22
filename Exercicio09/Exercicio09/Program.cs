using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int usuario = int.Parse(Console.ReadLine());

            if (usuario % 2 == 0 )
            {
                Console.WriteLine("PAR!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
        }
     }
}