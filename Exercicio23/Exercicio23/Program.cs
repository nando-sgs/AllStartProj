using System;
using System.Globalization;

namespace Exercicio23
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0;i<n;i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                int divi = int.Parse(num[0]);
                int denom = int.Parse(num[1]);
                if (denom == 0)
                {
                    Console.WriteLine("Divisão Impossivel");

                }
                else
                {
                    int divisao = divi / denom;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                
              
            }
        }
    }
}