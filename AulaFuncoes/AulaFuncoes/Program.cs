using System;
using System.Globalization;

namespace AulaFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva 3 números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            double result = Maior(num1, num2, num3);
            Console.WriteLine($"{result} é o maior número");  
        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}