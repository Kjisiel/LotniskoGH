using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Samolot
    {
        protected int ID;
        private string nazwa;
        private int zasieg, liczbamiejsc;

        public Samolot(int iD, string nazwa, int zasieg, int liczbamiejsc)
        {
            ID = iD;
            this.nazwa = nazwa;
            this.zasieg = zasieg;
            this.liczbamiejsc = liczbamiejsc;
        }

        public int getID()
        {
            return this.ID;
        }

        public int getZasieg()
        {
            return this.zasieg;
        }

        public int getLiczbaMiejsc()
        {
            return this.liczbamiejsc;
        }
    }
}
