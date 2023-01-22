
using System;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            string[] vet = Console.ReadLine().Split(' ');
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
            string b = (string)vet[0];
            var v = vet[1];
            string c = v;
            Console.WriteLine(b);
            Console.WriteLine(c);

            if (vet is null)
            {
                throw new Exception("cores não pode ser null");
            }
        }
    }
}