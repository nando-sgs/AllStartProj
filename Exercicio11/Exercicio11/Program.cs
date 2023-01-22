using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial do jogo: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora final do jogo: ");
            int fim = int.Parse(Console.ReadLine());
            if (inicio > 12 && fim < 12)
            {
                fim += 24;
                int resultA = fim - inicio;
                Console.WriteLine($"O jogo durou {resultA}hora(s)");
            } else if (inicio == fim)
            {
                Console.WriteLine("O jogo durou 24 hora(s)");
            }
            else
            {
                Console.WriteLine($"O jogo durou {fim-inicio}hora(s)");  
            }
        }
    }
}