using System;

namespace membro_estatico
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double ValorPago(double quantidade, double cotacao)
        {
            return (quantidade * cotacao) * (1 + (IOF / 100)) ;
        }
    }
}
