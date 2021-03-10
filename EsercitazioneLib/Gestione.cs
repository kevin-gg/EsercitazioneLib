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
            double p = (n * 10) / 100;
            double tot = p + n;
            return tot;
        }

        public static double AreaQuadrato(double n)
        {
            double l = Math.Sqrt(n);
            return l;
        
        }

        
    }
}
