using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Bilet
    {
        public int ID { get; set; }
        public int miejsce { get; set; }
        public float kwota { get; set; }
        public Klient klient;
        public Lot lot;

        public Bilet() { }

        public Bilet(int iD, int miejsce, float kwota, Klient klient, Lot lot)
        {
            ID = iD;
            this.miejsce = miejsce;
            this.kwota = kwota;
            this.klient = klient;
            this.lot = lot;
        }
    }
}
