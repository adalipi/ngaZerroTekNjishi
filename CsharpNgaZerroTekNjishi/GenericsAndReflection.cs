using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNgaZerroTekNjishi
{
    public class GenericsAndReflection<T> where T: class
    {
        public void ListoVetite()
        {
            var vetite = typeof(T).GetProperties();
            foreach (var item in vetite)
            {
                Console.WriteLine(item.Name);// + ": ");
                //Console.WriteLine(item.GetValue(x));
            }

        }
    }
}
