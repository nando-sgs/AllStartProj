using System;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = 1;i<= n;i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);
        }
    }
}