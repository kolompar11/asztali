using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat
{
    internal class Vasarlas
    {
        public IFizetesiRendszer FizetesiRendszer {  get; set; }

        public int Vegosszeg {  get; set; }


        public Vasarlas(IFizetesiRendszer fizetesiRendszer) 
        {
            FizetesiRendszer = fizetesiRendszer;
        }

        // hívja meg a fizetési módunk szerinti fizetést - próbáljunk Vegosszeg-nyi dolgot kigizetni
        //ha sikertelen volt: próbálja meg fele ekkora összeggel
            //ha az sikeres: írja ki, hogy leárazásban vásárolt
            //ha nem: írja ki, hogy sajnos megint sikertelen volt a vásárlás
        public void Fizetes() 
        {
            bool sikeres = FizetesiRendszer.Fizetes(Vegosszeg);
            if (sikeres == false)
            {
                Console.WriteLine("A vásárlás nem sikerült");
                bool sikeres2 = FizetesiRendszer.Fizetes(Vegosszeg / 2);
                if (sikeres2 == true)
                {
                    Console.WriteLine("Leárazásban vásárolt");
                }
            }
            else 
            {
                Console.WriteLine("Sajnos megint sikertelen volt a vásárlás");
            }
        }

        internal class Bankkartya : Vasarlas
        {
            private int v;

            public Bankkartya(int v)
            {
                this.v = v;
            }
        }
    }
}
