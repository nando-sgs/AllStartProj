using System;
using System.Globalization;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int entdados = int.Parse(Console.ReadLine());

            if (entdados < 25)
            {
                Console.WriteLine($"Está no intervalo (0-25)");

            }
            else if (entdados > 25 && entdados < 50)
            {
                Console.WriteLine($"Está no intervalo (25-50)");
            } 
            else if (entdados > 50 && entdados < 75)
            {
                Console.WriteLine($"Está no intervalo de (50-75)");

            }
            else if (entdados < 100 && entdados > 75)
            {
                Console.WriteLine($"Está no intervalo de (75-100)");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

        }
    }
}