using System.Globalization;

namespace exercicio1
{
    class Funcionarios
    {
        //atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        ////construtor
        //public Funcionarios (int id, string nome, double salario)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Salario = salario;
        //}

        //método
        public void Aumento(double porcentagem)
        {
            Salario += (Salario * (porcentagem / 100));
        }

        //ToString
        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
