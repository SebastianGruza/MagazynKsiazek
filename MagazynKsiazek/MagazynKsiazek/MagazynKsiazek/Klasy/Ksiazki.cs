using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    class Ksiazki
    {
        public int ID_Ksiazki { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public string Wydawnictwo { get; set; }
        public string RokWydania { get; set; }
        public string Gatunek { get; set; }
        public string Ilosc { get; set; }

        public string Cena { get; set; }

        public Ksiazki(int id_ksiazki, string tytul, string autor, string wydawnictwo,
        string rokwydania, string gatunek, string ilosc, string cena)
        {
            ID_Ksiazki = id_ksiazki;
            Tytul = tytul;
            Autor = autor;
            Wydawnictwo = wydawnictwo;
            RokWydania = rokwydania;
            Gatunek = gatunek;
            Ilosc = ilosc;
            Cena = cena;

        }

        public Ksiazki()
        {
            // TODO: Complete member initialization
        }

    }
}


