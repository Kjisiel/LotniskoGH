using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace L1
{
    class BazaDanych
    {
        public static List<Klient> klienci = new List<Klient>();
        public static List<Samolot> samoloty = new List<Samolot>();
        public static List<Lotnisko> lotniska = new List<Lotnisko>();
        public static List<Trasa> trasy = new List<Trasa>();
        public static List<Lot> loty = new List<Lot>();
        public static List<Bilet> bilety = new List<Bilet>();

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

        public void zapisz()
        {
            XmlSerializer sklienci = new XmlSerializer(typeof(List<Klient>));
            StreamWriter zklienci = new StreamWriter("klienci.xml");
            sklienci.Serialize(zklienci, klienci);
            zklienci.Close();

            XmlSerializer ssamoloty = new XmlSerializer(typeof(List<Samolot>));
            StreamWriter zsamoloty = new StreamWriter("samoloty.xml");
            ssamoloty.Serialize(zsamoloty, samoloty);
            zsamoloty.Close();

            XmlSerializer slotniska = new XmlSerializer(typeof(List<Lotnisko>));
            StreamWriter zlotniska = new StreamWriter("lotniska.xml");
            slotniska.Serialize(zlotniska, lotniska);
            zlotniska.Close();

            XmlSerializer strasy = new XmlSerializer(typeof(List<Trasa>));
            StreamWriter ztrasy = new StreamWriter("trasy.xml");
            strasy.Serialize(ztrasy, trasy);
            ztrasy.Close();

            XmlSerializer sloty = new XmlSerializer(typeof(List<Lot>));
            StreamWriter zloty = new StreamWriter("loty.xml");
            sloty.Serialize(zloty, loty);
            zloty.Close();

            XmlSerializer sbilety = new XmlSerializer(typeof(List<Bilet>));
            StreamWriter zbilety = new StreamWriter("bilety.xml");
            sbilety.Serialize(zbilety, bilety);
            zbilety.Close();
        }
    }
}
