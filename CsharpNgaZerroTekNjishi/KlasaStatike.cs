using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNgaZerroTekNjishi
{
    public static class KlasaStatike
    {
        public static int variableEpare { get; set; }
        public static int[] vektoriGlobal { get; set; }


        public static string tekstiMbrapa(this string teksti)
        {
            int madhesia = teksti.Length;

            char[] vektor = new char[madhesia];
            vektor = teksti.ToCharArray();

            string tesktiPerTuKthy = "";

            for (int i = madhesia-1; i >= 0; i--)
            {
                tesktiPerTuKthy += vektor[i];
            }

            return tesktiPerTuKthy;
        }

        public static string numerNeTekst(this int x) 
        {
            return x.ToString();
        }


    }
}
