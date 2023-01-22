using System;
using System.Globalization;

namespace Exercicio36
{
    internal class Conta
    {
        private int _numconta;
        public string Nome;
        private double _saldo;


        public void SetNum(int num)
        {
            if (_numconta == 0 && _numconta.ToString().Length < 4)
            {
                _numconta = num;
            } else
            {
                Console.WriteLine("Não é possivel alterar o numero da conta");
            }
        }
        public int GetNum(int num)
        {
            return _numconta; 
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetDeposit(double deposito)
        {
            _saldo += deposito;
        }   

        public void GetSaque(double saque)
        {
            if (saque > _saldo)
            {
                Console.WriteLine("Saldo indisponivel!");
            }
            else
            {
                _saldo -= saque;
            }
        }
        public override string ToString()
        {
            return "Numero da conta: " + _numconta + "\n"
                + "Nome: " + Nome + "\n"
                + "Saldo: R$" + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
