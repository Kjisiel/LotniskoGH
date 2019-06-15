using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Samolot
    {
        public int ID { get; set; }
        public string nazwa { get; set; }
        public int zasieg { get; set; }
        public int liczbamiejsc { get; set; }

        public Samolot() { }

        public Samolot(int iD, string nazwa, int zasieg, int liczbamiejsc)
        {
            ID = iD;
            this.nazwa = nazwa;
            this.zasieg = zasieg;
            this.liczbamiejsc = liczbamiejsc;
        }
    }
}
