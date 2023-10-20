using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoBanco
{
    internal class Conta
    {

        public double Taxa = 5;


        // Propriedades autoimplementadas
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; private set; }

        public double Saldo { get; private set; }


        // Construtores

        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            NomeTitular = nome;
        }

        public Conta(int numeroConta, double saldo, string nome)
        {
            NumeroConta = numeroConta;
            Saldo = 0;
            NomeTitular = nome;
        }



        // Métodos

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo = (Saldo - valor) - Taxa;
        }

        public void AlterarNomeTitular(string nome)
        {
            NomeTitular = nome;
        }


        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: $ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}

