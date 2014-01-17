using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    class Faktura
    {
        public string ID_Klienta { get; set; }
        public string Data_Wystawienia { get; set; }
        public int ID_Faktury { get; set; }
        public string Nr_Faktury { get; set; }
        public string Klient { get; set; }
        public string Towar { get; set; }
        public string Ilosc { get; set; }
        public string Cena { get; set; }

        public Faktura(string id_klienta, string data_wystawienia, int id_faktury, string nr_faktury, string klient,
            string towar, string ilosc, string cena)
        {
            ID_Klienta = id_klienta;
            Data_Wystawienia = data_wystawienia;
            ID_Faktury = id_faktury;
            Nr_Faktury = nr_faktury;
            Klient = klient;
            Towar = towar;
            Ilosc = ilosc;
            Cena = cena;



        }
        public Faktura()
        {

        }
    }
}
