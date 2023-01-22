using System;

namespace Exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1, p2;
            p1 = new Pessoas();
            p2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"{p1.nome} é mais velho[a]");
            } else
            {
                Console.WriteLine($"{p2.nome} é mais velho[a]");
            }
           

        }
    }
}