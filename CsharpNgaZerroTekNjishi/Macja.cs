using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CsharpNgaZerroTekNjishi
{
    public class Macja : Kafsha, IVrapuesit
    {
        public string Name { get { return "Macja"; } }

        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }

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

        public void mm(object n)
        { 
            
        }
        public override void leviz()
        {
            Console.WriteLine("Ec");
        }



        public void vrapo()
        {


            Console.WriteLine("vrapon ngadale");
        }

        dynamic shembull;


        public void shenoTeskt()
        {
            shembull = "arjan dalipi";
        }

        public void shenoNumer()
        {
            shembull = 5;
        }

    }
}
