using System;
using System.Globalization;

namespace Exercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();
           
            Console.WriteLine("Entre com a Largura e Altura do Triangulo: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double grandeza = r.Area();
            Console.WriteLine(grandeza.ToString("F2", CultureInfo.InvariantCulture));
            grandeza = r.Perimetro();
            Console.WriteLine(grandeza.ToString("F2", CultureInfo.InvariantCulture));
            grandeza = r.Diagonal();
            Console.WriteLine(grandeza.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
