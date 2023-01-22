using System;
using System.Globalization;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código da peça: ");
            int codpeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peças");
            int quantpeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço da peça: ");
            double precopeca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Código da peça 2: ");
            int codpeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peças 2 ");
            int quantpeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço da peça 2: ");
            double precopeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valortotal = (quantpeca * precopeca) + (quantpeca2 * precopeca2);
            Console.WriteLine($"O valor a pagar é {valortotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}