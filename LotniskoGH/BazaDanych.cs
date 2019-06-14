using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class BazaDanych
    {
        static List<Klient> klienci = new List<Klient>();
        static List<Samolot> samoloty = new List<Samolot>();
        static List<Lotnisko> lotniska = new List<Lotnisko>();
        static List<Trasa> trasy = new List<Trasa>();
        static List<Lot> loty = new List<Lot>();
        static List<Bilet> bilety = new List<Bilet>();

        public static void dodajKlienta(Klient klient)
        {
            klienci.Add(klient);
        }

        public static void dodajSamolot(Samolot samolot)
        {
            samoloty.Add(samolot);
        }

        public static void dodajLotnisko(Lotnisko lotnisko)
        {
            lotniska.Add(lotnisko);
        }

        public static void dodajTrase(Trasa trasa)
        {
            trasy.Add(trasa);
        }

        public static void dodajLot(Lot lot)
        {
            loty.Add(lot);
        }

        public static void dodajBilet(Bilet bilet)
        {
            bilety.Add(bilet);
        }
    }
}
