using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Klient
    {
        protected int ID;

        public Klient(int ID)
        {
            this.ID = ID;
        }

        public int getID()
        {
            return this.ID;
        }
    }
}
