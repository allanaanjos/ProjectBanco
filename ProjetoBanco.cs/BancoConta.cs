using System.Globalization;

namespace ProjetoBanco.cs
{
    internal class BancoConta
    {
   
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } 

      
        public BancoConta(int numconta, string titular)
        {
            NumConta = numconta;
            Titular = titular;
        }

        public BancoConta(int numconta, string titular, double saldo) : this(numconta, titular)
        {
            Saldo = saldo;
        }

        public void Deposite(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta: " + NumConta + ", Titular: " + Titular + ", Saldo "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
