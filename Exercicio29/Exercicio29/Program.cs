using System;
using System.Globalization;

namespace Exercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Dados do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine($"Area X : {areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area Y: {areay.ToString("F4", CultureInfo.InvariantCulture)}");
            if (areax > areay)
            {
                Console.WriteLine("Area x é maior");
            } else
            {
                Console.WriteLine("Area Y é maior");
            }


        }
    }
}
