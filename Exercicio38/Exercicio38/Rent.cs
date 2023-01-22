using System;

namespace Exercicio38
{
    internal class Rent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }
        public override string ToString()
        {
            return Quarto + ":" + Name + "," + Email;
        }

    }
}
