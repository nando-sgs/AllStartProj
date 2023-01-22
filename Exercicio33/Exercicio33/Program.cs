using System;
using System.Globalization;

namespace Exercicio33
{
    class Program
    {
        static void Main(string[] args) {

            Aluno a1;
            a1 = new Aluno();
            Console.Write("Nome do Aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do Aluno");
            a1.Semestre1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Semestre2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Semestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine($"Nota Final: {a1.Total().ToString("F2", CultureInfo.InvariantCulture)} ");
            if (a1.Avaliacao())
            {
                Console.WriteLine("Aprovado");
            }else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltam: {a1.Restante()} Pontos");
            }


        }
    }
}