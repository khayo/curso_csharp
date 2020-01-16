namespace ex_aula72
{
    class Calculadora
    {
        public static int Sum(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }
    }
}
