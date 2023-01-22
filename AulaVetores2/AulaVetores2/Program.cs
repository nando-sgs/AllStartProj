using System;
using System.Globalization;

namespace AulaVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];
            for (int i = 0;i < n; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for(int i = 0;i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = $" + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}