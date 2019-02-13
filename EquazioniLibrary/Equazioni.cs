using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class Equazioni
    {
        //metodo equazione determinata
        public static bool IsDetermined(double a)
        {
            bool risposta = true;
            if (a == 0)
            {
                risposta = false;

            }
            return risposta;
        }

        //metodo equazione impossibile
        public static bool IsInconsisted(double a, double b)
        {
            bool risposta = false;
            if (a == 0 && b == 0)
            {
                risposta = true;
            }
            return risposta;
        }

        //metodo equazione indeterminata
        public static bool IsIndetermined(double a, double b)
        {
            bool risposta = false;
            if (a / b == 0)
            {
                risposta = true;
            }
            return risposta;
        }

        //metodo equazione di secondo grado
        public static bool IsDegree2(double a)
        {
            bool risposta = true;
            if (a == 0)
            {
                risposta = false;
            }
            return risposta;
        }
    }
}
