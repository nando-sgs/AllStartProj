using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("1 - Álcool, 2 - Gasolina, 3 - Diesel");
            Console.Write("Qual o combustivel de sua preferência?: ");
            int entrada = int.Parse(Console.ReadLine());
            int alcool = 0;
            int diesel = 0;
            int gasolina = 0;
            while (entrada != 4)
            {
                
                if (entrada == 1)
                {
                    alcool += 1;
                }
                else if (entrada == 2)
                {
                    gasolina += 1;
                }
                else if (entrada == 3)
                {
                    diesel += 1;
                }
                else
                {
                    Console.WriteLine("Número inválido");
                    Console.Write("Tente novamente: ");
                    entrada = int.Parse(Console.ReadLine());
                }
                Console.Write("Qual o combustivel de sua preferência?: ");
                entrada = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine($"Alcool: {alcool} \n" +
                                 $"Gasolina: {gasolina} \n" +
                                 $"Diesel: {diesel}");
        }
    }
}