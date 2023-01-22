using System;
using System.Globalization;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida!");
                Console.Write("Tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");

         }

     }
}