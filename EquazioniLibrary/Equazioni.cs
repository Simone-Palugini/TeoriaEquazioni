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
            if (a == 0 && b != 0)
            {
                risposta = true;
            }
            return risposta;
        }

        //metodo equazione indeterminata
        public static bool IsIndetermined(double a, double b)
        {
            bool risposta = false;
            if (a == 0 && b == 0)
            {
                risposta = true;
            }
            return risposta;
        }

        //metodo equazione di 2° grado
        public static string IsDegree2(double a, double b)
        {
            double risultato = 0;
            string risposta = "";
            if (IsInconsisted(a, b))
            {
                risposta = "impossibile";
            }
            else if (IsIndetermined(a, b))
            {
                risposta = "indeterminata";
            }
            else
            {
                risultato = b / a;
                risposta = $"{risultato.ToString()}";
            }
            return risposta;
        }

        //metodo calcolo del delta
        public static double Delta(double a, double b, double c)
        {
            double risultato;
            risultato = (b * b) - (4 * c * a);

            return risultato;
        }

        // metodo equazione di 1° grado
        public static string EquationDegree1(double a, double b)
        {
            double risultato = 0;
            string risposta = "";

            if (IsInconsisted(a, b))
            {
                risposta = "impossibile";
            }
            else if (IsIndetermined(a, b))
            {
                risposta = "indeterminata";
            }
            else
            {
                risultato = -b / a;
                risposta = $"{risultato.ToString()}";
            }

            return risposta;
        }
    }   
}
