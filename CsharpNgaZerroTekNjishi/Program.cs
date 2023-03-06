using CsharpNgaZerroTekNjishi.TestKlasa1; //keshtu duhet te thirret namespace i klases ku eshte definuar se perndryshe nuk njifet nga programi
using CsharpNgaZerroTekNjishi.TestKlasa1.jk; //keshtu duhet te thirret namespace i klases ku eshte definuar se perndryshe nuk njifet nga programi
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CsharpNgaZerroTekNjishi
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {

            //keshtu deklarohet nji objekt i tipit Nata
            Nata n = new Nata();

            
            //vleren 10 po ja japim antarit te quajtur MyProperty qe i takon objektit n (i cili objekt eshte i tipit Nata - shih vijen 12)
            int v2 = n.MyProperty = 10;

            //caktojme vleren 20 antarit MyProperty1 te objektit n
            n.MyProperty1 = 20;


            //vlera e antarit MyProperty te objektit n, i jepet nji variable te quajtur v1 qe e deklaruam ketu direkt,dmth deklarim dhe inicializim
            int v1 = n.MyProperty1;

            //ne komandat e meposhtme po e thirrim metoden SetMyProperty2 dy here rresh, njiher me numrin 5 per parametrin e metodes
            //dhe heren e dyte me vleren 7
            //KUJDES: se cka ben kjo metode nuk e dijm nga ketu, duhet ta shofim punen e saj ne klasen (class) Nata
            //ne rastin konkret: nuk ja jep vleren nji variable lokale (brenda klasese cila eshte x) por po i mbledh vlerat qe i jepen x
            n.SetMyProperty2(5);
            n.SetMyProperty2(7);

            //shenojme ne konzole tekstin dhe ia bashkojme atij teksti ne fund vleren qe e kthen metoda GetMyProperty2() e objektit n
            Console.WriteLine("Vlera e varibles x te objektit Nata eshte " + n.GetMyProperty2());


            //krijojme nji objekt me emrin dita1 te tipit Dita dhe direkt i japim vlerat 2 dhe 3 ne konstruktor
            //konstruktori eshte si parametrat hyres te objektit, me saktesisht nese dojme te japim disa vlera ne momentin qe krijohet objekti
            Dita dita1 = new Dita(2, 3);
            
            dita1.y = 1;//japim vleren 1 anetarit y
            dita1.x = 2;//japim vleren 2 anetarit x
            dita1.Ejashtme();//thirrim (ekzekutojme) metoden Ejashtme() te objektit dita1

            //krijojme nji objekt tjeter te tipit Dita e qe e ka emrin dita2, objekt i njejte me dita1 - tipi i njejte, objekti ndryshe
            //secili objekt ka vetite (vlerat e anetareve) te vetat ndersa metodat e kane punen e ngjajshme per te mos thene te njejte
            //sepse njejt i kane hapat e punes, por ndryshojne dhe mledhin apo bejne kalkulime per vanetaret e objektit te vet
            //psh: metoda e Ejashtme() eshte e njejte tek te dy objektet dita1 dhe dita2, por secila ndryshon vleren e anetareve perkatese
            //nuk mundet thirrja e dita1.Ejashtme() te ndryshoje vleren e ndonje anetari te objektit dita2, 
            //secili objekt ka fushe veprimin e tij, dhe vetite - vlerat e veta
            Dita dita2 = new Dita(0,0);
            dita2.y = 3;

            dita1.y = 8;
            dita1.Ejashtme();

            dita2.Ejashtme();



            int fillimi = 1; //deklarojme nje variabel te tipit int (numer i plote) dhe japim vleren 1
            
            //pyesim ose caktojme se perderisa vlera e variables fillimi eshte me e vogel baraz me 10
            //ekzekuto bllokun e kodin brenda kllapave te medhaja
            while (fillimi <= 10) 
            { //....ketu fillon blloku.....
                if (fillimi == 5) //nese vlera e variables fillimi eshte 5 atehere hyn brenda bllokut dhe ekzekuto shprehjet:
                {
                    fillimi = 6;//jepja vleren 6 variables fillimi
                    continue;//keceje hapin aktual, apo injoro ekzekutimin e hapin aktual (te ciklit)
                             //qe dmth nuk ekzekutohen shprehjet, apo komandat e ardhshme te ciklit while,
                             //injorohet Console,WriteLine dhe rritja e vleres se variables fillimi
                }
                Console.WriteLine("Hello, World: " + fillimi);
                fillimi += 1;
            }//....dhe ketu mbaron blloku.....


            //dallimi ne mes while dhe do while eshte se while pyet njiher se a plotesohet kushti qe te futet ne cikel
            //ndersa do while njiher hyn ne cikel e ne fund pyet, qe dmth heren e pare edhe po qe se nuk plotesohet kushti
            //prape hyn ne cikel, por vetem 1 her, sepse menjiher ne hapin e dyte kushti nuk lejon ekzekutimin
            do
            {
                Console.WriteLine("Hello, Vetem 1 here!");

            }
            while (fillimi < 10);

        }
    
    */

        static void Main(string[] args)
        {






            ////pjesa e pare
            //Console.WriteLine("Sheno 1 per mace, ndersa 2 per qen");            
            //int hyrje = int.Parse(Console.ReadLine());

            //IVrapuesit ivrapokafsh;

            //switch (hyrje)
            //{
            //    case 1:
            //    ivrapokafsh = new Macja();
            //        break;
            //    case 2:
            //        ivrapokafsh = new Qeni();
            //        break;
            //    default:
            //        ivrapokafsh = new Macja();
            //        break;

            //}
            //Console.Write(ivrapokafsh.Name +" ");
            //ivrapokafsh.vrapo();


            ////pjesa dyte:
            //using (Qeni qen = new Qeni())
            //{
            //    qen.fol();
            //}
            //Console.WriteLine("Fundi");



            //pjesa e trete
            //Upcasting
            //Kafsha[] kafshet = new Kafsha[2];
            //kafshet[0] = new Qeni();
            //kafshet[1] = new Macja();


            //foreach (Kafsha item in kafshet)
            //{

            //    Donwcasting
            //    if (item is Qeni)
            //    {

            //    }
            //}


            //pjesa e katert
            //PassRefPassValue passRefValue = new PassRefPassValue();
            //PassRefPassValue passRefValue1 = new PassRefPassValue();
            //PassRefPassValue passRefValue2 = new PassRefPassValue();


            //passRefValue.PasoSiVlere(numri);


            //Console.WriteLine(numri);

            //Console.WriteLine((Vakti)3);

            //MyStruct myStruct = new MyStruct();
            //myStruct.MyProperty = 23;

            //MyStruct myStruct1 = new MyStruct();


            //pjesa 5
            //int numri = 50;

            //object obj = numri; //boxing

            //int y = (int)obj; //unboxing

            //int nr;


            //int x = 10;

            //x = 11;

            //var dicka = 10.8;
            //var qen = new Qeni();
            //var xx = 6;


            //pjesa 6
            //dynamic test = 6;
            //Console.WriteLine(test + 6);

            //test = "fjale ";
            //Console.WriteLine(test + 6);

            //pjesa 7
            //int nr = 1;
            //try
            //{
            //   nr  = int.Parse(Console.ReadLine());
            //   while(nr == 1) 
            //   {
            //        nr = int.Parse(Console.ReadLine());
            //   }
            //}
            //catch (NumerException)
            //{
            //    nr = int.Parse(Console.ReadLine());
                
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}


            //Console.WriteLine($"numeri qe shenuat eshte: {nr}");



            //pjesa 8
            DateTime data = DateTime.UtcNow;

            Console.WriteLine(data.ToString(), TimeZoneInfo.Local);

            DateTime njiDate = DateTime.Now.AddDays(-10);
            //var cultura = CultureInfo.CreateSpecificCulture("sq-sq");

            //Console.WriteLine(njiDate.ToString("dddd", cultura));


        }
    }
}