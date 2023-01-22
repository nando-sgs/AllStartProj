using System;
using System.Globalization;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas medias serãos analisadas: ");
            int alunos = int.Parse(Console.ReadLine());
            string[] total;
            double media1 = 0;
            for(int i = 0;i<alunos;i++)
            {
             Console.Write($"Nota: ");
             string[] notas = Console.ReadLine().Split(' ');
             double nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
             double nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
             double nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
             media1 = (nota1 + nota2 + nota3) / 3;
             Console.WriteLine($"{media1.ToString("F1", CultureInfo.InvariantCulture)}");
            }
          
        }
    }
}