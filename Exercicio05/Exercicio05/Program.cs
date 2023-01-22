using System;
using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do funcionario:");
            int codigofunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas: ");
            int horasfunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário por hora: ");
            double salariofunc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salariocount = horasfunc * salariofunc; 
            Console.WriteLine($"O salario do funcionario número {codigofunc} é ${salariocount.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}