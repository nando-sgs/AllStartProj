using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio39
{
    class Program
    {
        static void Main(string[] args) {

            Console.Write("Quantos empregados serão avaliados?: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> func = new List<Funcionario>();
            for (int i=0;i < n; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Add(new Funcionario(id, name, salario));
                Console.WriteLine();
            }

            Console.Write("Qual empregado terá o salario aumentado: ");
            int searchid = int.Parse(Console.ReadLine());
            Funcionario emp = func.Find(x => x.Id == searchid);
            if (emp != null)
            {
                Console.Write("Adicione a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("Id inexistente.");
            }
            Console.WriteLine("Dados Atualizados");
            foreach(Funcionario obj in func)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
