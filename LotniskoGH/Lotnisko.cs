using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Lotnisko
    {
        protected int ID;
        private string nazwa, panstwo, miasto;
        private double szerokoscGeo, wysokoscGeo;

        public Lotnisko(int iD, string nazwa, string panstwo, string miasto, double szerokoscGeo, double wysokoscGeo)
        {
            ID = iD;
            this.nazwa = nazwa;
            this.panstwo = panstwo;
            this.miasto = miasto;
            this.szerokoscGeo = szerokoscGeo;
            this.wysokoscGeo = wysokoscGeo;
        }

        public int getID()
        {
            return this.ID;
        }
    }
}
