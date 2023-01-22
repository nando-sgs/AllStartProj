using System.Globalization;
namespace Exercicio35
{
    internal class ConversorDeMoedas2
    {
        public double Cotacao2;
        public double Conversao2;

        public double Converter2()
        {
            return ((1.1 * Conversao2 / 100) + Conversao2) * Cotacao2;
        }
        public override string ToString()
        {
            return Converter2().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
