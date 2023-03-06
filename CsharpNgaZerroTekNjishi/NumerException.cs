using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNgaZerroTekNjishi
{
    public class NumerException : Exception
    {
        public NumerException() : base("Problem numri") { }
    }
}
