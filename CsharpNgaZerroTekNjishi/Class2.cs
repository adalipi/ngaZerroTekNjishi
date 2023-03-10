using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNgaZerroTekNjishi
{
    public partial class Class1
    {
        public int Vetia2 { get; set; }


        public (int, int, int) funksioniMledhjeDyNumra(int x, int y)
        {
            return (x+y, x, y);
        }

        public Struktura2 test1()
        { 
            return new Struktura2() { v1 = 5, v2 = 7, v3 = 9, v4 = 11 };
        }
    }

    public struct Struktura2
    {
        public int v1 { get; set; }
        public int v4 { get; set; }
        public int v3 { get; set; }
        public int v2 { get; set; }
    }
}
