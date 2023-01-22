using System;
using System.Globalization;

namespace AulaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas pessoas irão pesar?; ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0;i < n; i++)
            {
                Console.Write("Entre com o dados: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for(int i = 0;i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));
             

        }
    }
}