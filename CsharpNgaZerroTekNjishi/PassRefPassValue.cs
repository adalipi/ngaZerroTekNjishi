using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNgaZerroTekNjishi
{
    public class PassRefPassValue
    {
        public void PasoSiReference(ref int x)
        {
            x += 10;
            Console.WriteLine(x);
        }

        public void PasoSiVlere(int x)
        {
            x += 10;
            Console.WriteLine(x);
        }
    }
}
