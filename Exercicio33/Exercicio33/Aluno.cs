using System;
using System.Globalization;

namespace Exercicio33
{
    internal class Aluno
    {
        public string Nome;
        public double Semestre1, Semestre2, Semestre3;
        public double Total()
        {
            return Semestre1 + Semestre2 + Semestre3;
        }
        public bool Avaliacao()
        {
            if (Total() < 60)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public double Restante()
        {
            if (Avaliacao())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Total();
            }
        }
    }
}   
