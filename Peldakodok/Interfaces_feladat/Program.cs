using Interfaces_feladat.FizetesiModok;

namespace Interfaces_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");

            Bankkartya bankkartya = new Bankkartya();
            bankkartya.Egyenleg = 1000;
            Vasarlas bankkartyasfizetes = new Vasarlas(bankkartya);
            bankkartyasfizetes.Vegosszeg = 2000;
            bankkartyasfizetes.Fizetes();

            //hozz létre egy új vásárlást Bankkártyával
            /*állíts be 1000 kezdeti egyenleget
            * próbálj vásárolni 2000 értékben
            * => először nem sikerül, aztán igen
            */


            //hozz létre egy új vásárlást készpénzzel
            /*állíts be 1000 kezdeti egyenleget
            * próbálj vásárolni 500 értékben
            * => elsőre sikerül
            */


            //hozz létre egy új vásárlást revolut-al
            /*állíts be 1000 kezdeti egyenleget
            * próbálj vásárolni 3000 értékben
            * => elsőre és másodikra se fog sikerülni
            */

        }
    }
}
