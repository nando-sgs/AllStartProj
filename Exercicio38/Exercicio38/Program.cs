using System;
using System.Globalization;

namespace Exercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Rent[] vect = new Rent[10];
            Console.Write("Quantas Pessoas irão alugar os quartos?: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("Aluguel #"+ i );
                Console.Write("Nome do cliente: ");
                string name = Console.ReadLine();
                Console.Write("Email do cliente: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                if (vect[quarto] == null)
                {
                    vect[quarto] = new Rent {Quarto = quarto, Name = name, Email = email };
                } else
                {
                    Console.WriteLine("Quarto ocupado");
                    Console.Write("Escolha outro quarto: ");
                    quarto = int.Parse(Console.ReadLine());
                }
                
                
            }

            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0;i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
                
            }

        }
       
    }
}
