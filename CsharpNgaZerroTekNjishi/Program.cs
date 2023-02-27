using CsharpNgaZerroTekNjishi.TestKlasa1; //keshtu duhet te thirret namespace i klases ku eshte definuar se perndryshe nuk njifet nga programi
using CsharpNgaZerroTekNjishi.TestKlasa1.jk; //keshtu duhet te thirret namespace i klases ku eshte definuar se perndryshe nuk njifet nga programi

namespace CsharpNgaZerroTekNjishi
{
    internal class Program
    {
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
    }
}