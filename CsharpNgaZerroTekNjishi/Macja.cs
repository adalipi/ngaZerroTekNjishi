using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CsharpNgaZerroTekNjishi
{
    public class Macja : Kafsha
    {

        public override void fol()
        {
            Console.WriteLine("mjaullon");
        }

        public void test1()
        { 
            this.fol();
        }

        public void test2()
        {
            base.fol();
        }

        public override void leviz()
        {
            Console.WriteLine("Ec");
        }

    }
}
