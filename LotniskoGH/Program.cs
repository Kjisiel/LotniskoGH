using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L1;

namespace LotniskoGH
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID=0;
            string miejscestartu, miejscedocelowe;
            foreach (Bilet bilet in BazaDanych.bilety)
            {
                if (bilet.ID > ID)
                {
                    ID = bilet.ID + 1;
                }
            }
            bool posrednikczynie;
            if (posrednikczynie == true)
            {
                string nazwa;
                Posrednik posrednik = new Posrednik(ID, nazwa);
                //I tutaj trzeba jakoś zrobić dobieranie lotu do tego co chce klient
                int liczbabiletow;
                for(int i=0; i<liczbabiletow; i++)
                {

                }

            }
            else
            {
                string imie, nazwisko;
                Indywidualny indywidualny = new Indywidualny(ID, imie, nazwisko);

            }

        }
    }
}
