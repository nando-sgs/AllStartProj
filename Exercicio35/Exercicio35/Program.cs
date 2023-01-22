using System;
using System.Globalization;

namespace Exercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoedas conv = new ConversorDeMoedas();
            ConversorDeMoedas2 conv2 = new ConversorDeMoedas2();

            Console.Write("Escolha a moeda que deseja converter: Yen : ¥ , Euro : € , Libra Esterlina: £ , Dolar: $ : ");
            string moeda = Console.ReadLine().ToUpper().ToString(CultureInfo.InvariantCulture);

            Console.Write("Qual será a forma de pagamento?: Cartão de Crédito/Débito - C , Dinheiro em espécie: D: ");
            string formadepagamento = Console.ReadLine().ToUpper().ToString(CultureInfo.InvariantCulture);

            if (formadepagamento == "D")
            {
                if (moeda == "¥")
                {
                    Console.Write("Entre com a cotação atual: ");
                    conv2.Cotacao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantos Ienes irá comprar?:¥ ");
                    conv2.Conversao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (moeda == "€")
                {
                    Console.Write("Entre com a cotação atual: ");
                    conv2.Cotacao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantos Euros irá comprar?: €");
                    conv2.Conversao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (moeda == "£")
                {
                    Console.Write("Entre com a cotação atual: ");
                    conv2.Cotacao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantas Libras irá comprar?:£ ");
                    conv2.Conversao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (moeda == "$")
                {
                    Console.Write("Entre com a cotação atual: ");
                    conv2.Cotacao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantos dólares irá comprar?:U$ ");
                    conv2.Conversao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                else
                {
                    Console.WriteLine("Valor Inválido");
                }
                double total2 = conv2.Converter2();
                Console.WriteLine("Valor a ser pago em reais: R$" + conv2);

            }
            else if (formadepagamento == "C")
            {
                if (moeda == "¥")
                {
                    Console.Write("Entre com a cotação atual: ");
                    conv.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantos Ienes irá comprar?:¥ ");
                    conv.Conversao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (moeda == "€")
                {
                    Console.Write("Entre com a cotação atual: ");
                    conv.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantos Euros irá comprar?: €");
                    conv.Conversao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (moeda == "£")
                {
                    Console.Write("Entre com a cotação atual: ");
                    conv.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantas Libras irá comprar?:£ ");
                    conv.Conversao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (moeda == "$")
                {
                    Console.Write("Entre com a cotação atual: ");
                    conv.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantos dólares irá comprar?:U$ ");
                    conv.Conversao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.WriteLine("Valor Inválido");
                }
                double total = conv.Converter();
                Console.WriteLine("Valor a ser pago em reais: R$" + conv);

            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }

        }
    }
}