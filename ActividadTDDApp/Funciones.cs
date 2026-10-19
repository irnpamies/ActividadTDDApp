using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public static long CalcularFactorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0 || n == 1) return 1;

            return n * CalcularFactorial(n - 1);
        }

        public static bool EsContrasenyaValida(string contrasenya)
        {
            throw new NotImplementedException();
        }
    }
}
