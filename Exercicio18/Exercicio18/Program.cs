using System;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor de x e um de y: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                } else
                {
                    Console.WriteLine("Quarto quadrante"); 
                }
                Console.WriteLine("Entre com outros valores:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valor nulo");
        }
    }
}