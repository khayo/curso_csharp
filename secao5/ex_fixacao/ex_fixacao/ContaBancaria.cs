using System.Globalization;

namespace ex_fixacao
{
    class ContaBancaria
    {
        //atributos
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        //construtores
        public ContaBancaria(int numero, string nome )
        {
            Numero = numero;
            Nome = nome;
        }
        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial);
        }

        //métodos
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        //ToString
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
