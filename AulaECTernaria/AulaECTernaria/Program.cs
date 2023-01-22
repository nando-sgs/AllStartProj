using System;
using System.Globalization;

namespace AulaECTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*if (preco > 20)
            {
                Console.WriteLine("Desconto de 20%");
                Console.WriteLine("Valor descontado" + ":" + preco * 20 / 100);

            }
            else if (preco < 20)
            {
                Console.WriteLine("Desconto de 15%");
                Console.WriteLine("Valor descontado" + ":" + preco * 15 / 100);
            }*/
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);

        }
    }
}