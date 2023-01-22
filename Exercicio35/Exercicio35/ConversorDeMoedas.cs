using System.Globalization;
namespace Exercicio35
{
    internal class ConversorDeMoedas
    {
        public double Cotacao;
        public double Conversao;
        
        public double Converter()
        {
            return ((6 * Conversao / 100) + Conversao) * Cotacao;
        }
        public override string ToString()
        {
            return Converter().ToString("F2", CultureInfo.InvariantCulture);
                
        }

    }
}
