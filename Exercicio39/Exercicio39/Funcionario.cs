using System;
using System.Globalization;
namespace Exercicio39
{
    internal class Funcionario
    {
        public int Id { private set; get; }
        public string Name { set; get; }
        public double Salario { private set; get; }

        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void IncreaseSalary(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }
        public override string ToString()
        {
            return Id + " - "
                   + Name + " - "
                   + "R$" + Salario.ToString("F2", CultureInfo.InvariantCulture);
                
        }

    }
}
