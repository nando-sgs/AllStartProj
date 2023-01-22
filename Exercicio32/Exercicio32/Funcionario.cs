using System.Globalization;
namespace Exercicio32
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        

        public double SalarioLiquido()
        {
            return SalarioBruto = SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = ((SalarioBruto + Imposto) * porcentagem) / 100 + SalarioBruto;
        }
        public override string ToString()
        {
            return Nome
                   + ", Salário: $"+ SalarioBruto.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
