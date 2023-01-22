using System;
using System.Globalization;

namespace Exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A, B;
            A = new Funcionario();
            B = new Funcionario();

            Console.WriteLine("Dados do primeiro Funcionário");
            Console.Write("Nome: ");
            A.nome = Console.ReadLine();
            Console.Write("Salário: ");
            A.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo Funcionário");
            Console.Write("Nome: ");
            B.nome = Console.ReadLine();
            Console.Write("Salário: ");
            B.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medsalario = (A.salario + B.salario) / 2;
            Console.WriteLine($"O salário médio dos funcionários é {medsalario.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}