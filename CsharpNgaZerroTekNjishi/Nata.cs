

using System.Runtime.CompilerServices;

namespace CsharpNgaZerroTekNjishi.TestKlasa1.jk //namespace eshte grupimi i klasave
{
    //definimi i klases public class EMRI
    public class Nata
    {
        //klasa mund te kete objekte te tipit te klasave tjera, por nuk guxojme te kemi lidhje dyfishe
        //nuk mundet Dita te kete Nata, dhe ne te njejten kohe Nata te kete Dita
        //Dita ditaJone = new Dita(3,5 );//ketu kemi krijuar nji anetare privat te tipit Dita te quajtur ditaJone

        //definimi i anetarit (vetise) MyProperty
        //qe direkt definojme se cfare vlere kthen ky anetare kur i qasemi si MyProperty
        //dhe ku e dergon vleren, kur i japim vlere duke e thire MyProperty = 10
        public int MyProperty 
        {
            get { return x; }

            set { x = value; } 
        
        }

        public void JepeVleren(int vlera)
        { 
            KlasaStatike.variableEpare = vlera;
        }


        public void caktovlerenNumrit(int x, out int y)
        {
            y = x;
        }

        //ketu definojme nji anetare (veti) te tipit int dhe vleren e kthimin dhe caktimin e vleres e mbane per veti jo per x si rasti me larte
        public int MyProperty1 { get; set; }

        //definojme nje variabel private e quajtur x dhe i caktojme vleren 0
        int x = 0;

        //funksion qe kthen int (vlere te numrit te plot) dhe konkretisht kthen vleren e x
        public int GetMyProperty2() 
        {
            return x;
        }

        //per dallim nga funksionet, metodat nuk kthejne vlera dhe kane fjalen void para emrit, keto bejne nje ose disa pune dhe aq pa kthim vlere
        public void SetMyProperty2(int var1) //kerkon nji variabel te tipit int
        { 
            x += var1; //rrit vleren e x per aq sa eshte vlera e variables var1
        }
    }
}
