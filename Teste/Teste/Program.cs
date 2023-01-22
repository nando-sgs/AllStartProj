using System;
namespace Teste
{
    class Program
    {
        static void IndexOutOfRangeException(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}