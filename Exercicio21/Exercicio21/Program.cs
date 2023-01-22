using System;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número qualquer: ");
            int n = int.Parse(Console.ReadLine());
            int contin = 0;
            int contout = 0;
            for(int i = 0;i<n;i++)
            {
                Console.Write("Digite mais um número: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contin += 1;
                }
                else
                {
                    contout += 1;
                }
            }
            Console.WriteLine($"{contin} in \n" +
                $"{contout} out");

        }
    }
}