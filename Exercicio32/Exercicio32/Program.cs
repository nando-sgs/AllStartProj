using System;
using System.Globalization;

namespace Exercicio32
{
    class Program
    {
        static void Main(string[] args) {

            Funcionario f1;
            f1 = new Funcionario();

            Console.WriteLine("Dados do funcionário");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.SalarioLiquido();
            Console.WriteLine($"Funcionario: {f1}");

            Console.Write("Porcetagem de aumento de salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            f1.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados Atualizados: {f1}");
        
        }
    }
}