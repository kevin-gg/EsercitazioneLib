using System;

namespace EsercitazioneLib
{
    public class Gestione
    {
        public static double PercentualeDiUnNumero(double n)
        {

            double p = (n * 10) / 100;
            return p;

        }
        public static double Incremento(double n)
        {
            double p = (n * 50) / 100;
            double tot = p + n;
            return tot;
        }

        public static double AreaQuadrato(double n)
        {
            double l = Math.Sqrt(n);
            return l;
        
        }

        public static double Somma(double a, double b)
        {
            double somma = a + b;
            return somma;
        }

        public static double Sottrazione(double a, double b)
        {
            double Sottrazione = a - b;
            return Sottrazione;
        }

        public static double Moltiplicazione(double a, double b)
        {
            double Moltiplicazione = a * b;
            return Moltiplicazione;
        }

        public static double Divisione(double a, double b)
        {
            double Divisione = a / b;
            return Divisione;
        }

        //public static double Potenza(double n, int a)
        //{
        //    double risultato = 0;
        //    for(int i = 0; i < a; i++)
        //    {

        //    }
        //}

        public static string DaDecimaleABinario(int a)
        {
            string binario = Convert.ToString(a, 2);
            return binario;

        }


    }
}
