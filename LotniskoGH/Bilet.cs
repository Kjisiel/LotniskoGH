using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Bilet
    {
        protected int ID;
        private int miejsce;
        private float kwota;
        Klient klient;
        Lot lot;

        public Bilet(int iD, int miejsce, float kwota, Klient klient, Lot lot)
        {
            ID = iD;
            this.miejsce = miejsce;
            this.kwota = kwota;
            this.klient = klient;
            this.lot = lot;
        }

        public int getID()
        {
            return this.ID;
        }
    }
}
