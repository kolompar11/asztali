using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat
{
    internal interface IFizetesiRendszer
    {
        public int Egyenleg {  get; set; }

        public bool Fizetes(int osszeg);
        //property
        /*
         * - egyenleg
         */
        
        //metódus
        /*
         * - bool Fizetes(int osszeg)
         *           
         */

    }
}
