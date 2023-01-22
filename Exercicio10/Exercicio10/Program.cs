using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Digite 2 números");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("É múltiplo");
            } else
            {
                Console.WriteLine("Não é múltiplo");
            }
        }
    }
}