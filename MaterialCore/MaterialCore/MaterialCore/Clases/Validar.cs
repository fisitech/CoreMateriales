using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialCore
{
    public class Validar
    {
        public static bool EsEntero(string Valor)
        {
            bool resultado;
            int numero;

            resultado = int.TryParse(Valor, out numero);

            return resultado;
        }

        public static bool EsDecimal(string Valor)
        {
            bool resultado;
            decimal numero;

            resultado = decimal.TryParse(Valor, out numero);

            return resultado;
        }

        public static bool EstaVacio(string Valor)
        {
            bool resultado = false;

            if (Valor == String.Empty)
                resultado = true;

            return resultado;
        }
    }
}
