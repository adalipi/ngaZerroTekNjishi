using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNgaZerroTekNjishi
{
    public abstract class Kafsha
    {
        private int _private;
        public string _ngjyra;

        protected int x;

        public virtual void fol()
        {
            Console.WriteLine("kafsha po bertet");
        }

        public abstract void leviz();
        
    }
}
