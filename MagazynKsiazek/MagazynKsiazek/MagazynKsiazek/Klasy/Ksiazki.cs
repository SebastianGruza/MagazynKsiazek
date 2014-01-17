using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynKsiazek.Klasy
{
    class Ksiazki
    {
        public int ISBN { get; set; }
        public string Tytul { get; set; }
        public string DaneAutora { get; set; }
        public string Wydawnictwo { get; set; }
        public string RokWydania { get; set; }
        public string Gatunek { get; set; }
        public string Ilosc { get; set; }
        public string Cena { get; set; }

        public Ksiazki(int isbn, string tytul, string daneAutora, string wydawnictwo,
        string rokwydania, string gatunek, string ilosc, string cena)
        {
            ISBN = isbn;
            Tytul = tytul;
            DaneAutora = daneAutora;
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


