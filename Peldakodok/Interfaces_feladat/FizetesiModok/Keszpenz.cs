using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat.FizetesiModok
{
    //implementálja a IFizetésiRendszer interfészt
    internal class Keszpenz : IFizetesiRendszer
    {
        public int Egyenleg { get ; set; }

        public bool Fizetes(int Osszeg) 
        {
            if (Egyenleg >= Osszeg)
            {
                Egyenleg -= Osszeg;
                Console.WriteLine("Sikeres készpénzes fizetés");
                return true;
            }
            else 
            {
                Console.WriteLine("Sikertelen készpénzes fizetés");
                return false;
            }
        }

        bool IFizetesiRendszer.Fizetes(int osszeg)
        {
            throw new NotImplementedException();
        }
        //fizetés:
        /*
         * - ha van elég pénzünk (egyenleg)
         *      - vonja le
         *      - írja ki, hogy "Sikeres készpénzes fizetés"
         *      - adjon vissza 'true'-t
         * - ha nincs:
         *      - írja ki, hogy "Sikertelen készpénzes fizetés"
         *      - adjon vissza 'false'-ot
         */
    }
}
