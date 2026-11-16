using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat.FizetesiModok
{
    internal class Bankkartya : IFizetesiRendszer
    {
        //fizetés:
        /*
         * - ha van elég pénzünk (egyenleg)
         *      - vonja le
         *      - írja ki, hogy "Sikeres bankkártyás fizetés"
         *      - adjon vissza 'true'-t
         * - ha nincs:
         *      - írja ki, hogy "Sikertelen bankkártyás fizetés"
         *      - adjon vissza 'false'-ot
         */
        public int Egyenleg { get ; set ; }

        public bool Fizetes(int osszeg)
        {
            if (Egyenleg >= osszeg)
            {
                Egyenleg -= osszeg;
                Console.WriteLine("Sikeres bankkártyás fizetés");
                return true;
            }
            else 
            {
                Console.WriteLine("Sikertelen bankkártyás fizetés");
                return false;
            }
        }
    }
}
