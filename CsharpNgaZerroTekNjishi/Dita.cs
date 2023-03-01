
namespace CsharpNgaZerroTekNjishi.TestKlasa1
{
    public class Dita
    {
        //Dita dita = new Dita(3,4);  keshtu nuk ben, nuk mundet objekti te krijoje vet veten - brenda vetes

        //konstruktori apo metoda e cila thirret automatikisht kur e definojme nji objekt te ketij tipi (Dita)
        public Dita(int n1, int n2)//me parametra  
        {
            
            Console.WriteLine("Objekti u krijua, me numrat: " + n1 + " dhe " + n2);
        }

        public int x;//defino variabel publike me emrin x, KUJDES jo VETI (anetare - veti) por anetare variabel, shih ne klasen Dita si definohet Vetia-anetari
        public int y;//defino variabel publike me emrin y,

        //metode publike qe mund te qaset nga jashte dhe qe thirr 2 funksione lokale (te brendshme) dhe 1 metode lokale (te brendshme)
        public void Ejashtme(int numri_i_pare)
        {

            int shuma = mbledhjaDyNumrave(numri_i_pare, KlasaStatike.variableEpare);

            string shumaSiTekst = KlasaStatike.numerNeTekst(shuma);
            
            shenoNeConsole(shumaSiTekst);

            
        }
        
        //metode lokale, mbingarkim, sepse ekzistojne edhe dy metoda me emrin e njejte por numrin ose tipin e parametrave e kane tjeter
        private int mbledhjaDyNumrave(int param2, double param1)
        {
            return 0;//vlera kthyse, ne kete rast 0
        }
        
        //metode lokale, mbingarkim, sepse ekzistojne edhe dy metoda me emrin e njejte por numrin ose tipin e parametrave e kane tjeter
        int mbledhjaDyNumrave(int param2, double param1, double param3)
        {
            return 0;
        }

        //metode lokale, mbingarkim, sepse ekzistojne edhe dy metoda me emrin e njejte por numrin ose tipin e parametrave e kane tjeter
        int mbledhjaDyNumrave(int parametri2, int parametri1)
        { 
            return parametri1 + parametri2;//mlidhi vlerat e dy parametrave dhe mbaji ne variablen shuma
            //return shuma;//ktheje vleren e variables shuma
        }

        //metode lokale - private qe mund te thirret vetem nga brenda metodat e kesaj klase dhe jo nga jasht sepse nuk e ka public para void
        void shenoNeConsole(string teksti)
        {
            Console.WriteLine(teksti);
        }
    }

    
}
