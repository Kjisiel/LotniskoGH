using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Trasa
    {
        protected int ID;
        Lotnisko odlot;
        Lotnisko przylot;
        private int odleglosc, czaslotu;

        public Trasa(int iD, Lotnisko odlot, Lotnisko przylot, int odleglosc, int czaslotu)
        {
            ID = iD;
            this.odlot = odlot;
            this.przylot = przylot;
            this.odleglosc = odleglosc;
            this.czaslotu = czaslotu;
        }

        public int getID()
        {
            return this.ID;
        }
    }
}
