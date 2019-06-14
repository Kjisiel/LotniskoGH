using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Lot
    {
        protected int ID;
        private int wykupioneMiejsca;
        Trasa trasa;
        Samolot samolot;

        public Lot(int iD, int wykupioneMiejsca, Trasa trasa, Samolot samolot)
        {
            ID = iD;
            this.wykupioneMiejsca = wykupioneMiejsca;
            this.trasa = trasa;
            this.samolot = samolot;
        }

        public int getID()
        {
            return this.ID;
        }

        public int getWykupioneMiejsca()
        {
            return this.wykupioneMiejsca;
        }
    }
}
