using System;
using System.Globalization;

namespace Exercicio15
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o salário e veja seu imposto de renda:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double taxa8 = (8 * salario) / 100;
            double taxa18 = (8 * 1000) / 100 + (18 * (salario - 3000)) / 100;
            double taxa28 = (8 * 1000) / 100 + (18 * ((salario - 3000) - (salario - 4500))) / 100 + (28 * (salario - 4500) / 100);

            if (salario < 2000)
            {
                Console.WriteLine("Isento de imposto de renda");
            } else if (salario > 2000 && salario < 3000)
            {
                Console.WriteLine($"A taxa sobre esse valor é de {taxa8.ToString("F2", CultureInfo.InvariantCulture)}");
            } else if (salario > 3000 && salario < 4500)
            {
                Console.WriteLine($"O imposto de renda incidente sobre {salario.ToString("F2", CultureInfo.InvariantCulture)} é {taxa18.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"A taxa sobre {salario.ToString("F2",CultureInfo.InvariantCulture)} é {taxa28.ToString("F2", CultureInfo.InvariantCulture)}");
            }
                    
        }
    }
}